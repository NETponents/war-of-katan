using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Katan.Graphics;

namespace Katan
{
    namespace Screens
    {
        public class GameScreen : Screen, ISuspendable
        {
            /// <summary>
            /// Defualt public initializer for GameScreen object.
            /// </summary>
            public GameScreen()
            {

            }
            /// <summary>
            /// Loads all needed content into memory.
            /// </summary>
            /// <param name="gameInstance">Instance of current Game1 object.</param>
            public override void LoadContent(Game1 gameInstance)
            {
                base.LoadContent(gameInstance);
            }
            /// <summary>
            /// Updates all content inside Screen object.
            /// </summary>
            /// <param name="gameInstance">Instance of current Game1 object.</param>
            public override void Update(ref Game1 gameInstance)
            {
                base.Update(ref gameInstance);
            }
            /// <summary>
            /// Draws current Screen object to the graphics object.
            /// </summary>
            /// <param name="gameInstance">Instance of current Game1 object.</param>
            public override void Draw(ref Game1 gameInstance)
            {
                base.Draw(ref gameInstance);
            }
            /// <summary>
            /// Unloads all content from the appended Screen object.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Prepares the Screen object for temporary suspension.
            /// </summary>
            public void Suspend()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Prepares the Screen object to be brought out of suspension.
            /// </summary>
            public void Resume()
            {
                throw new NotImplementedException();
            }
        }
    }
}
