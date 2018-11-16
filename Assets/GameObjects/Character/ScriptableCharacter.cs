using System;
using UnityEngine;

namespace Assets.GameObjects.Character
{
    public class ScriptableCharacter : MonoBehaviour, ICharacter
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

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Die()
        {

            IsDead = true;
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            Life -= damage;
        }
    }
}
