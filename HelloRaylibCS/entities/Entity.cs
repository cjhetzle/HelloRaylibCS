using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;

namespace RaylibCS.entities
{
    internal abstract class Entity
    {
        protected Texture2D sprite;
        protected Vector2 position;
        protected Rectangle drawBox;
        protected Rectangle[] hitBoxes;
        // add something to contain movement instructions

        public Entity()
        {
            hitBoxes = new Rectangle[0];
        }

        public virtual void Build(Texture2D texture, Rectangle rectangle, Vector2 position, Rectangle[] hitBoxes)
        {
            this.sprite = texture;
            this.drawBox = rectangle;
            {
                drawBox.X = 0;
                drawBox.Y = 0;
            }
            this.position = position;
            this.hitBoxes = hitBoxes;
        }
        public virtual void Draw()
        {
            DrawTextureRec(sprite, drawBox, position, Color.WHITE);
        }
        public abstract void Unload();
        public abstract void Update(float deltaTime);
    }
}
}
