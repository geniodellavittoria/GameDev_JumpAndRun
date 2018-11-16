using System;
using Assets.GameObjects.GameCharacter;

namespace Assets.GameObjects.Hero
{
    public interface IHero : IGameCharacter
    {
        void Jump();
    }
}
