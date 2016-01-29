using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace Graphics
    {
        interface ISuspendable
        {
            void Suspend();
            void Resume();
        }
    }
}
