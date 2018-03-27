using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    class AssetLoader
    {
        public static Dictionary<string, Texture2D> lnAsstets;
        public static Dictionary<string, Texture2D> noteTextures;
        public static Dictionary<string, Texture2D> judgments;
        public static Texture2D receptor;

        public AssetLoader()
        {
            lnAsstets = new Dictionary<string, Texture2D>();
            noteTextures = new Dictionary<string, Texture2D>();
            judgments = new Dictionary<string, Texture2D>();

        }

        public void loadNoteTextures(ContentManager content)
        {
            noteTextures.Add("fullNote", content.Load<Texture2D>("fullNote"));
            noteTextures.Add("halfNote", content.Load<Texture2D>("halfNote"));
            noteTextures.Add("quarterNote", content.Load<Texture2D>("quarterNote"));
            noteTextures.Add("eighthNote", content.Load<Texture2D>("eighthNote"));
            noteTextures.Add("sixteenthNote", content.Load<Texture2D>("sixteenthNote"));
            noteTextures.Add("thirtyTwoethNote", content.Load<Texture2D>("thirtyTwoethNote"));
            noteTextures.Add("sixtyFourthNote", content.Load<Texture2D>("sixtyFourthNote"));
            noteTextures.Add("smallestNote", content.Load<Texture2D>("smallestNote"));
        }

        public void loadJudgments(ContentManager content)
        {
            judgments.Add("Boo", content.Load<Texture2D>("boo"));
            judgments.Add("good", content.Load<Texture2D>("good"));
            judgments.Add("great", content.Load<Texture2D>("great"));
            judgments.Add("miss", content.Load<Texture2D>("miss"));
            judgments.Add("marvelous", content.Load<Texture2D>("marvelous"));
            judgments.Add("perfect", content.Load<Texture2D>("perfect"));

        }

        public void loadReceptor(ContentManager content)
        {
            receptor = content.Load<Texture2D>("receptor");
        }

        public void loadLnAssets(ContentManager content)
        {
            lnAsstets.Add("body", content.Load<Texture2D>("LnBody"));
            lnAsstets.Add("cap", content.Load<Texture2D>("LnCapFixed"));

        }

    }
}
