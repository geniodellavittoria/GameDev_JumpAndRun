
namespace Assets.GameObjects.GameCharacter
{
    public interface IGameCharacter
    {
        double Height { get; set; }
        double Speed { get; set; }
        double Life { get; set; }
        double Strength { get; set; }
        bool IsDead { get; set; }

        void Attack();

        void Die();

        void Move();

        void TakeDamage(double damage);
    }
}