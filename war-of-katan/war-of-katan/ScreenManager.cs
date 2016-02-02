using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katan.Graphics;

namespace Katan
{
    namespace Graphics
    {
        public class ScreenManager
        {
            private Dictionary<string, Screen> screenList;
            private string currentScreen;
            private List<Task> runningOperations;
            private bool switchOperationRequested;
            private string switchOperationArgument;

            /// <summary>
            /// Default constructor for ScreenManager object.
            /// </summary>
            public ScreenManager()
            {
                screenList = new Dictionary<string, Screen>();
                currentScreen = "";
                runningOperations = new List<Task>();
                switchOperationRequested = false;
            }
            /// <summary>
            /// Runs update method for currently selected Screen object.
            /// </summary>
            public void Update(Game1 gameInstance)
            {
                // Check to see if the previous frame requested a switch context operation.
                if (switchOperationRequested)
                {
                    loadScreen(switchOperationArgument, gameInstance);
                    switchOperationRequested = false;
                    switchOperationArgument = "";
                }
                // Now is a good time to check if any background tasks have finished.
                // TODO: Move to a new thread.
                foreach (Task i in runningOperations)
                {
                    if(i.IsCompleted)
                    {
                        runningOperations.Remove(i);
                    }
                }
                // Run the currently selected screen update function if
                // it is loaded, otherwise throw an exception.
                if (screenList[currentScreen].IsLoaded())
                {
                    screenList[currentScreen].Update(ref gameInstance);
                }
                // Throw an exception.
                else
                {
                    throw new ScreenNotLoadedException();
                }
            }
            /// <summary>
            /// Runs draw method for currently selected Screen object.
            /// </summary>
            public void Draw(Game1 gameInstance)
            {
                if (screenList[currentScreen].IsLoaded())
                {
                    // Checks to see if the screen was invalidated to avoid redrawing the same frame.
                    if (screenList[currentScreen].IsRectangleInvalidated())
                    {
                        gameInstance.GraphicsDevice.Clear(Color.Black);
                        screenList[currentScreen].Draw(ref gameInstance);
                    }
                    // Otherwise do nothing since nothing visually changed.
                }
                else
                {
                    throw new ScreenNotLoadedException();
                }
            }
            /// <summary>
            /// Adds a Screen object to private screen collection.
            /// </summary>
            /// <param name="_name">Name of screen.</param>
            /// <param name="_screen">Screen object to add.</param>
            public void AddScreen(string _name, Screen _screen)
            {
                screenList.Add(_name, _screen);
            }
            /// <summary>
            /// Switches display context to a new screen by unloading the current
            /// screen and loading the new screen. Can also suspend/resume if the 
            /// screen object inherits the ISuspendable interface.
            /// </summary>
            /// <param name="_name">Name of screen to switch to.</param>
            public void SwitchScreen(string _name, Game1 gameInstance)
            {
                Console.WriteLine("[DEBUG] Switched to " + _name + ".");
                // Check to see if screen exists
                if (!screenList.ContainsKey(_name))
                {
                    throw new ScreenNotFoundException();
                }
                // Check if there is already an active screen
                if (currentScreen != "")
                {
                    // There is a screen already taking up memory, unload it
                    runningOperations.Add(new Task(() => unloadScreen(_name)));
                    runningOperations[runningOperations.Count - 1].Start();
                }
                // Load the new screen
                loadScreen(_name, gameInstance);
                currentScreen = _name;
            }
            public void SwitchPreloadedScreen(string _name)
            {
                // Check to see if screen exists
                if (!screenList.ContainsKey(_name))
                {
                    throw new ScreenNotFoundException();
                }
                // Check if there is already an active screen
                if (currentScreen != "")
                {
                    // There is a screen already taking up memory, unload it
                    runningOperations.Add(new Task(() => unloadScreen(_name)));
                    runningOperations[runningOperations.Count - 1].Start();
                }
                // Load the new screen
                currentScreen = _name;
            }
            /// <summary>
            /// Spawns a task that will asyncronously load a new screen into memory.
            /// </summary>
            /// <param name="_name">Name of Screen object to load.</param>
            public Task AsyncPreloadScreen(string _name, Game1 gameInstance)
            {
                Task result = new Task(() => loadScreen(_name, gameInstance));
                return result;
            }
            /// <summary>
            /// Unloads a Screen object from memory.
            /// </summary>
            /// <param name="_name">Name of Screen object to unload.</param>
            private void unloadScreen(string _name)
            {
                if (screenList[_name] is ISuspendable)
                {
                    (screenList[_name] as ISuspendable).Suspend();
                }
                else
                {
                    screenList[_name].UnloadContent();
                }
            }
            /// <summary>
            /// Loads a Screen object into memory.
            /// </summary>
            /// <param name="_name">Name of Screen object to load.</param>
            private void loadScreen(string _name, Game1 gameInstance)
            {
                if (screenList[_name] is ISuspendable)
                {
                    (screenList[_name] as ISuspendable).Resume();
                }
                else
                {
                    screenList[_name].LoadContent(gameInstance);
                }
            }
        }
    }
}
