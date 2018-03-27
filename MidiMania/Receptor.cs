using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class Receptor
    {
        public Texture2D texture;
        public Vector2 position;
        public float rotation;
        public static float scalar = 1;
        public Vector2 origin;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, scalar, SpriteEffects.None, 0);
            spriteBatch.End();

        }

        public void Update()
        {
            scalar = .95f;
        }

    }
}
