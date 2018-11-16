﻿namespace Application
{
    public interface ICharacter
    {
        double Height { get; set; }
        double Speed { get; set; }
        double Life { get; set; }
        double Strength { get; set; }
        bool IsEnemy { get; set; }
        bool IsDead { get; set; }

        void jump();

        void move();

        void attack();

        void die();

        void takeDamage();
    }
}