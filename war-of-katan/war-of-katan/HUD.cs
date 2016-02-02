using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace Graphics
    {
        namespace UI
        {
            public class HUD
            {
                private bool isInvalidated;

                public HUD()
                {

                }
                public void LoadContent()
                {

                }
                public void Update()
                {

                }
                public void Draw()
                {
                    ResetInvalidation();
                }
                public void UnloadContent()
                {

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
        }
    }
}
