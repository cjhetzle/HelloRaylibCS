using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.KeyboardKey;

namespace RaylibCS.entities
{
    internal abstract class ControllableEntity : Entity
    {
        protected float speed;
        protected float strength;

        public abstract void Update(float deltaTime, KeyboardKey keys);
    }
}
