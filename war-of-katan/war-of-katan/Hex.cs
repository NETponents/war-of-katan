using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Katan
{
    namespace GameObjects
    {
        public class Hex : IGameObject
        {
            protected int hexNumber;
            private Vector2 hexPosition;

            /// <summary>
            /// Default public constructor for Hex game object.
            /// </summary>
            public Hex()
            {

            }
            /// <summary>
            /// Loads all content for the Hex game object.
            /// </summary>
            public virtual void LoadContent(ContentManager cm)
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Unloads all content for the Hex game object.
            /// </summary>
            public virtual void UnloadContent()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Runs the update cycle for the given Hex object.
            /// </summary>
            public virtual void Update()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Gets the position of the hex relative to the parent
            /// World game object origin.
            /// </summary>
            /// <returns>2D location of Hex object.</returns>
            public Vector2 GetHexLocation()
            {
                return hexPosition;
            }
            /// <summary>
            /// Sets the position of the hex relative to the parent
            /// World game object origin.
            /// </summary>
            /// <param name="position">New position of Hex object.</param>
            public void SetHexLocation(Vector2 position)
            {
                hexPosition = position;
            }
            public virtual Texture2D GetHexTexture()
            {
                return null;
            }
        }
        public interface IHexRollable
        {
            int getHexNumber();
            void setHexNumber(int value);
            void isBlocked();
        }
        public class SeaHex : Hex
        {
            /// <summary>
            /// Public default constructor for SeaHex game object.
            /// </summary>
            public SeaHex()
            {
                
            }
            /// <summary>
            /// Loads all needed content into memory for the current SeaHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Updates the SeaHex object if needed.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all SeaHex content from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
        public class WheatHex : Hex, IHexRollable
        {
            /// <summary>
            /// Public default constructor for WheatHex game object.
            /// </summary>
            public WheatHex()
            {

            }
            /// <summary>
            /// Loads all needed content for WheatHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Runs any needed updates for the WheatHex object.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all content for the WheatHex object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Gets the rollable number of the Hex.
            /// </summary>
            public int getHexNumber()
            {
                return hexNumber;
            }
            /// <summary>
            /// Checks to see if the tile is blocked by the robber, a siege, or an event.
            /// </summary>
            public void isBlocked()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Sets the rollable hex number for the tile.
            /// </summary>
            public void setHexNumber(int value)
            {
                hexNumber = value;
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
        public class BrickHex : Hex, IHexRollable
        {
            public BrickHex()
            {

            }
            /// <summary>
            /// Loads all needed content for BrickHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Runs any needed updates for the BrickHex object.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all content for the BrickHex object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Gets the rollable number of the Hex.
            /// </summary>
            public int getHexNumber()
            {
                return hexNumber;
            }
            /// <summary>
            /// Checks to see if the tile is blocked by the robber, a siege, or an event.
            /// </summary>
            public void isBlocked()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Sets the rollable hex number for the tile.
            /// </summary>
            public void setHexNumber(int value)
            {
                hexNumber = value;
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
        public class SheepHex : Hex, IHexRollable
        {
            public SheepHex()
            {

            }
            /// <summary>
            /// Loads all needed content for SheepHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Runs any needed updates for the SheepHex object.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all content for the SheepHex object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Gets the rollable number of the Hex.
            /// </summary>
            public int getHexNumber()
            {
                return hexNumber;
            }
            /// <summary>
            /// Checks to see if the tile is blocked by the robber, a siege, or an event.
            /// </summary>
            public void isBlocked()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Sets the rollable hex number for the tile.
            /// </summary>
            public void setHexNumber(int value)
            {
                hexNumber = value;
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
        public class StoneHex : Hex, IHexRollable
        {
            public StoneHex()
            {

            }
            /// <summary>
            /// Loads all needed content for StoneHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Runs any needed updates for the StoneHex object.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all content for the StoneHex object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Gets the rollable number of the Hex.
            /// </summary>
            public int getHexNumber()
            {
                return hexNumber;
            }
            /// <summary>
            /// Checks to see if the tile is blocked by the robber, a siege, or an event.
            /// </summary>
            public void isBlocked()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Sets the rollable hex number for the tile.
            /// </summary>
            public void setHexNumber(int value)
            {
                hexNumber = value;
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
        public class WoodHex : Hex, IHexRollable
        {
            public WoodHex()
            {

            }
            /// <summary>
            /// Loads all needed content for WoodHex object.
            /// </summary>
            public override void LoadContent(ContentManager cm)
            {
                base.LoadContent(cm);
            }
            /// <summary>
            /// Runs any needed updates for the WoodHex object.
            /// </summary>
            public override void Update()
            {
                base.Update();
            }
            /// <summary>
            /// Unloads all content for the WoodHex object from memory.
            /// </summary>
            public override void UnloadContent()
            {
                base.UnloadContent();
            }
            /// <summary>
            /// Gets the rollable number of the Hex.
            /// </summary>
            public int getHexNumber()
            {
                return hexNumber;
            }
            /// <summary>
            /// Checks to see if the tile is blocked by the robber, a siege, or an event.
            /// </summary>
            public void isBlocked()
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Sets the rollable hex number for the tile.
            /// </summary>
            public void setHexNumber(int value)
            {
                hexNumber = value;
            }
            public override Texture2D GetHexTexture()
            {
                throw new NotImplementedException();
            }
        }
    }
}
