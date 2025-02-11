using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure
{
    /// <summary>
    /// Интерфей, который говорит, что наслдники умеют клонироваться
    /// Дженерик класс
    /// </summary>
    public interface IMyCloneable<T>
    {
        public abstract T MyClone();
    }
}
