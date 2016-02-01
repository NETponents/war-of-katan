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
            protected bool isInvalidated;
            /// <summary>
            /// Default constructor for Screen object.
            /// </summary>
            public Screen()
            {
                loaded = false;
                isInvalidated = true;
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
                
            }
            /// <summary>
            /// Draws all components of the Screen object to the active graphics object.
            /// </summary>
            public virtual void Draw()
            {
                ResetInvalidation();
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
            public bool IsRectangleInvalidated()
            {
                return isInvalidated;
            }
            public void Invalidate()
            {
                isInvalidated = true;
            }
            private void ResetInvalidation()
            {
                isInvalidated = false;
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
