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
            public class UIControl
            {
                private bool isInvalidated;
                public UIControl()
                {
                    isInvalidated = true;
                }
                public virtual void LoadContent()
                {

                }
                public virtual void Update()
                {

                }
                public virtual void Draw()
                {
                    ResetInvalidation();
                }
                public virtual void UnloadContent()
                {

                }
                public bool IsInvalidated()
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
