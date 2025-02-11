using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure
{
    /// <summary>
    /// Конкретная реализация клетки мозга
    /// </summary>
    public class CellOfBrain : Cell
    {
        public CellOfBrain(string name) : base(name)
        {
        }
        /// <summary>
        /// Воспомимнания или память
        /// </summary>
        List<string> Memorys = new List<string>();
        /// <summary>
        /// Даем возможность думать, сама по себе она, конечно, не думает, но для абстракции представим что это так. 
        /// </summary>
        public override void Ability()
        {
            Console.WriteLine($"My name is {Name} and I can think.");
        }
        /// <summary>
        /// Клонируем клетку мозга
        /// </summary>
        /// <returns></returns>
        public override CellOfBrain MyClone()
        {
            //return this.MemberwiseClone() as CellOfBrain;
            return new CellOfBrain("");
        }
        
        /// <summary>
        /// Запоминаем что нибудь
        /// </summary>
        /// <param name="think"></param>
        public void MemorizeSomeThing( string think)
        {
            Memorys.Add(think);
        }
        public void GetMemorys()
        {
            foreach (string s in Memorys) { Console.WriteLine(s); }
        }
    }
}
