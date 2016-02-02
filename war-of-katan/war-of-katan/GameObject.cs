using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace GameObjects
    {
        public interface IGameObject
        {
            void Update();
            void LoadContent();
            void UnloadContent();
        }
        public interface IManagedDrawObject
        {
            void Draw();
        }
    }
}
