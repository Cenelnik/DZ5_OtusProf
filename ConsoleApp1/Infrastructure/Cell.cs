
namespace ConsoleApp1.Infrastructure
{
    /// <summary>
    /// Абстрактный класс некой клетки.
    /// </summary>
    public abstract class Cell : IMyCloneable<Cell>
    {
        public Cell (string name) 
        {
            Name = name;
        }
        public abstract Cell MyClone();

        /// <summary>
        /// Имя\название клетки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Каждая клетка имеет какую то особенность 
        /// </summary>
        public abstract void Ability();
    }
}
