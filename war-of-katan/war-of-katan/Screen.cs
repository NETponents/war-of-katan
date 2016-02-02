using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace Graphics
    {
        public class Screen : IInvalidator
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
            public virtual void LoadContent(Game1 gameInstance)
            {
                loaded = true;
            }
            /// <summary>
            /// Runs any logic needed for any components within the Screen object container.
            /// </summary>
            public virtual void Update(ref Game1 gameInstance)
            {
                
            }
            /// <summary>
            /// Draws all components of the Screen object to the active graphics object.
            /// </summary>
            public virtual void Draw(ref Game1 gameInstance)
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
            /// <summary>
            /// Checks to see if the current screen is fully loaded into memory.
            /// </summary>
            /// <returns>Load state of screen.</returns>
            public bool IsLoaded()
            {
                return loaded;
            }
            /// <summary>
            /// Checks to see if any components on the screen have been invalidated or changed.
            /// </summary>
            /// <returns>Invalidation state of Screen object.</returns>
            public bool IsRectangleInvalidated()
            {
                return isInvalidated;
            }
            /// <summary>
            /// Invalidates the Screen object, marking it for update on next Draw() cycle.
            /// </summary>
            public void Invalidate()
            {
                isInvalidated = true;
            }
            /// <summary>
            /// Resets the validation flag on current Screen object, marking all
            /// components as 'unchanged'.
            /// </summary>
            public void ResetInvalidation()
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
