namespace MinotaurLabyrinth
{
    public interface IMovable
    {
        bool DisplaySense(Hero hero, int heroDistance);
        void Activate(Hero hero, Map map);
        void Move(Hero hero, Map map);
    }
}