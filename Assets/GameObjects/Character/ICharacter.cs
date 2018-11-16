namespace Assets.GameObjects.Character
{
    public interface ICharacter
    {
        double Height { get; set; }
        double Speed { get; set; }
        double Life { get; set; }
        double Strength { get; set; }
        bool IsEnemy { get; set; }
        bool IsDead { get; set; }

        void Jump();

        void Move();

        void Attack();

        void Die();

        void TakeDamage(double damage);
    }
}