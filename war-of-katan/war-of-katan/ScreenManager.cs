using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katan.Graphics;

namespace Katan
{
    namespace Graphics
    {
        class ScreenManager
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
            public void Update()
            {
                screenList[currentScreen].Update();
            }
            /// <summary>
            /// Runs draw method for currently selected Screen object.
            /// </summary>
            public void Draw()
            {
                screenList[currentScreen].Draw();
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
            public void SwitchScreen(string _name)
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
                loadScreen(_name);
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
            public Task AsyncPreloadScreen(string _name)
            {
                Task result = new Task(() => loadScreen(_name));
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
            private void loadScreen(string _name)
            {
                if (screenList[_name] is ISuspendable)
                {
                    (screenList[_name] as ISuspendable).Resume();
                }
                else
                {
                    screenList[_name].LoadContent();
                }
            }
        }
    }
}
