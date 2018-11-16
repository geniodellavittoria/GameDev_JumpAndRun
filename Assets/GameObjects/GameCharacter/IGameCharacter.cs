namespace Assets.GameObjects.GameCharacter
{
    public interface IGameCharacter
    {
        double Height { get; set; }
        double Speed { get; set; }
        double Life { get; set; }
        double Strength { get; set; }
        bool IsEnemy { get; set; }
        bool IsDead { get; set; }

        void Jump();



        void Attack();

        void Die();

        void TakeDamage(double damage);
    }
}