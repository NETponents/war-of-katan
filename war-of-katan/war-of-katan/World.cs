using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katan
{
    namespace GameObjects
    {
        public class World
        {
            List<Hex> hexList;
            /// <summary>
            /// Public default constructor for the in-game World object.
            /// </summary>
            public World()
            {
                hexList = new List<Hex>();
            }
            /// <summary>
            /// Loads all needed content for the in-game World object.
            /// </summary>
            public void LoadContent()
            {
                // TODO: call world initializer
                
            }
            /// <summary>
            /// Updates all objects in the game World object.
            /// </summary>
            public void Update()
            {

            }
            /// <summary>
            /// Draws the game world to the current Graphics object.
            /// </summary>
            public void Draw()
            {

            }
            /// <summary>
            /// Unloads all content in the game World object from memory.
            /// </summary>
            public void UnloadContent()
            {

            }
            /// <summary>
            /// Generates a collection of hexes arranged in a world format.
            /// </summary>
            /// <param name="seed">Seed to use for generation.</param>
            /// <returns>List<> of hexes.</returns>
            public static List<Hex> GenerateWorld(int seed)
            {
                List<Hex> genList = new List<Hex>();
                genList.Add(new WheatHex());
            }
        }
    }
}
