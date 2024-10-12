using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPatternPrototypeResearch
{
    /// <summary>
    /// Класс, отражающий клетку
    /// </summary>
    public class Cell : IMyCloneable
    {
        /// <summary>
        /// Ядро клетки
        /// </summary>
        public Nucleus Nucleus { get; set; }

        /// <summary>
        /// Кол-во митохондрий в клетке
        /// </summary>
        public int MitochondriaCount {  get; set; }

        public Cell(Nucleus nucleus, int mitochondriaCount)
        {
            Nucleus = nucleus;
            MitochondriaCount = mitochondriaCount;
        }

        public IMyCloneable Clone (bool flag)
        {
            var nucleus = Nucleus.Clone() as Nucleus;

            return new Cell(nucleus, MitochondriaCount);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Базовая клетка организма. Кол-во митохондрий - {MitochondriaCount}.\nЯдро клетки следующее - {Nucleus.ToString()}";
        }

    }
}
