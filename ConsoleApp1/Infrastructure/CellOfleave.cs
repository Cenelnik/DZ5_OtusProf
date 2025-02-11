using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure
{
    /// <summary>
    /// Конкретная реализация клетки - клетки-растения.
    /// </summary>
    internal class CellOfleave : Cell, ICloneable
    {
        public CellOfleave(string name) : base(name)
        {

        }

        /// <summary>
        /// Клетки разстений делают кислород 
        /// </summary>
        public override void Ability()
        {
            Console.WriteLine($"I can create oxygen. And i have {CountOfchloroplasts} of chloroplasts and count of chlorophyll = [{CountofChlorophyll.Count}]");
        }

        /// <summary>
        /// Деление клеток.
        /// </summary>
        /// <returns></returns>
        public override CellOfleave MyClone()
        {
            return new CellOfleave(Name) as CellOfleave;
        }

        /// <summary>
        /// Это не глубокое клонирование, которое реализовано через существующие методы. 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Каждая клетка имеет хотябы один хлоропласт
        /// </summary>
        public int CountOfchloroplasts { get; set; } = 1;
        /// <summary>
        /// Кол-во хлорофила для фотосинтеза
        /// </summary>
        public List<Chlorophyll> CountofChlorophyll = new List<Chlorophyll>();
    }

    
}
