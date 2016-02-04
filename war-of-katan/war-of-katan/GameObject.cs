using Microsoft.Xna.Framework.Content;

namespace Katan
{
    namespace GameObjects
    {
        public interface IGameObject
        {
            void Update();
            void LoadContent(ContentManager cm);
            void UnloadContent(ContentManager cm);
        }
        public interface IManagedDrawObject
        {
            void Draw();
        }
    }
}
