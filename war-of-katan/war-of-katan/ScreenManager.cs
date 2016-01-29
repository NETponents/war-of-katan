using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katan.Graphics;

namespace Katan
{
    namespace Graphics
    {
        class ScreenManager
        {
            private Dictionary<string, Screen> screenList;
            private string currentScreen;

            /// <summary>
            /// Default constructor for ScreenManager object.
            /// </summary>
            public ScreenManager()
            {

            }
            /// <summary>
            /// Runs update method for currently selected Screen object.
            /// </summary>
            public void Update()
            {

            }
            /// <summary>
            /// Runs draw method for currently selected Screen object.
            /// </summary>
            public void Draw()
            {

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
                    unloadScreen(_name);
                }
                // Load the new screen

            }
            /// <summary>
            /// Unloads a Screen object from memory.
            /// </summary>
            /// <param name="_name">Name of Screen object to unload.</param>
            private void unloadScreen(string _name)
            {
                if (screenList[currentScreen] is ISuspendable)
                {
                    (screenList[currentScreen] as ISuspendable).Suspend();
                }
                else
                {
                    screenList[currentScreen].UnloadContent();
                }
            }
            /// <summary>
            /// Loads a Screen object into memory.
            /// </summary>
            /// <param name="_name">Name of Screen object to load.</param>
            private void loadScreen(string _name)
            {
                if (screenList[currentScreen] is ISuspendable)
                {
                    (screenList[currentScreen] as ISuspendable).Resume();
                }
                else
                {
                    screenList[currentScreen].LoadContent();
                }
            }
        }
    }
}
