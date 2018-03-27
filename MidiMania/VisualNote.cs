using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class VisualNote
    {
        public Vector2 position;
        public Texture2D texture;
        public static float scalar = 1;
        public static Vector2 origin;
        public float rotation;


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, scalar, SpriteEffects.None, 0);
            spriteBatch.End();
        }

        public void Update()
        {
            position.Y += (float)((Settings.height / 1000) * Clock.getTimeSinceLastUpdate());

            
        }
    }
}
