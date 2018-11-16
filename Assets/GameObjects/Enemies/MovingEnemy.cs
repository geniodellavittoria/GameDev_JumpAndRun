using System;
using UnityEngine;

namespace Assets.GameObjects.Enemies
{
    public class MovingEnemy : MonoBehaviour, IEnemy
    {
        public MovingEnemy()
        {
        }

        [SerializeField]
        private double _speed;

        [SerializeField]
        private double _life;

        [SerializeField]
        private double _strength;

        [SerializeField]
        private bool _isEnemy;

        [SerializeField]
        private bool _isDead;

        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public double Life
        {
            get
            {
                return _life;
            }
            set
            {
                _life = value;
            }
        }

        public double Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                _strength = value;
            }
        }

        public bool IsEnemy
        {
            get
            {
                return _isEnemy;
            }
            set
            {
                _isEnemy = value;
            }
        }

        public bool IsDead
        {
            get
            {
                return _isDead;
            }
            set
            {
                _isDead = value;
            }
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }


    }
}
