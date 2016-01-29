using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace Graphics
    {
        class Screen
        {
            protected bool loaded;
            /// <summary>
            /// Default constructor for Screen object.
            /// </summary>
            public Screen()
            {
                loaded = false;
            }
            /// <summary>
            /// Loads all content needed for Screen object instance.
            /// </summary>
            public virtual void LoadContent()
            {
                loaded = true;
            }
            /// <summary>
            /// Runs any logic needed for any components within the Screen object container.
            /// </summary>
            public virtual void Update()
            {
                if(!loaded)
                {
                    throw new ScreenNotLoadedException();
                }
            }
            /// <summary>
            /// Draws all components of the Screen object to the active graphics object.
            /// </summary>
            public virtual void Draw()
            {
                if (!loaded)
                {
                    throw new ScreenNotLoadedException();
                }
            }
            /// <summary>
            /// Frees all unneeded resources before deleting the Screen object.
            /// </summary>
            public virtual void UnloadContent()
            {
                loaded = false;
            }
            public bool IsLoaded()
            {
                return loaded;
            }
        }
        class ScreenNotLoadedException : Exception
        {
            public ScreenNotLoadedException()
            {

            }
        }
        class ScreenNotFoundException : Exception
        {
            public ScreenNotFoundException()
            {

            }
        }
    }
}
