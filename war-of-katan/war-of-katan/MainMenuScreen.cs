using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Katan.Graphics;

namespace Katan
{
    namespace Screens
    {
        class MainMenuScreen : Screen
        {
            private SpriteFont sf_menuTitle;
            private SpriteFont sf_menuItem;
            private Texture2D tx_menuBG;
            private Song sg_bgMusic;
            /// <summary>
            /// Creates and instance of the MainMenu object.
            /// </summary>
            public MainMenuScreen()
            {

            }
            /// <summary>
            /// Loads all needed content for the MainMenuScreen object.
            /// </summary>
            public override void LoadContent(Game1 gameInstance)
            {
                sf_menuTitle = gameInstance.Content.Load<SpriteFont>("Screens/MainMenu/Fonts/MenuTitle");
                sf_menuItem = gameInstance.Content.Load<SpriteFont>("Screens/MainMenu/Fonts/MenuItem");
                tx_menuBG = gameInstance.Content.Load<Texture2D>("Screens/MainMenu/Sprites/MenuBG");
                sg_bgMusic = gameInstance.Content.Load<Song>("Screens/MainMenu/Audio/bgMusic");
                base.LoadContent(gameInstance);
            }
            /// <summary>
            /// Updates the Screen object.
            /// </summary>
            public override void Update(ref Game1 gameInstance)
            {
                if(MediaPlayer.State == MediaState.Stopped)
                {
                    MediaPlayer.Play(sg_bgMusic);
                }
                base.Update(ref gameInstance);
            }
            /// <summary>
            /// Draws the Screen object.
            /// </summary>
            public override void Draw(ref Game1 gameInstance)
            {
                base.Draw(ref gameInstance);
            }
            /// <summary>
            /// Unloads the Screen object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                sf_menuTitle = null;
                sf_menuItem = null;
                tx_menuBG = null;
                sg_bgMusic = null;
                base.UnloadContent();
            }
        }
    }
}
