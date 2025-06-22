
namespace ConsoleApp1.Infrastructure
{
    /// <summary>
    /// Абстрактный класс некой клетки.
    /// </summary>
    public abstract class Cell : IMyCloneable<Cell>, ICloneable
    {
        public Cell (string name) 
        {
            Name = name;
            Console.WriteLine($"{this.ToString()}: create new cell {name}.");
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

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
