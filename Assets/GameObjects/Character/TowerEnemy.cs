using System;
using UnityEngine;

namespace Application
{
    public class ScriptableCharacter : ScriptableObject, ICharacter
    {
        public ScriptableCharacter()
        {
        }


        public double Height { get; set; }

        public double Speed { get; set; }

        public double Life { get; set; }

        public double Strength { get; set; }

        public bool IsEnemy { get; set; }

        public bool IsDead { get; set; }

        public void attack()
        {
            throw new NotImplementedException();
        }

        public void die()
        {
            throw new NotImplementedException();
        }

        public void jump()
        {
            throw new NotImplementedException();
        }

        public void move()
        {
            throw new NotImplementedException();
        }

        public void takeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
