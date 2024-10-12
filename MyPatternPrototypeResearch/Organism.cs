
namespace MyPatternPrototypeResearch
{
    /// <summary>
    /// Класс, отражающий некоторый живой организм
    /// </summary>
    public class Organism : IMyCloneable, ICloneable
    {
        /// <summary>
        /// Признак одноклеточности
        /// </summary>
        bool IsUnicellular { get; }

        int OrganismIndex { get; }

        bool IsClone {  get; }

        /// <summary>
        /// Какая клетка состовляет организм (берётся одна, обобщённая)
        /// </summary>
        Cell CommonCell { get; }

        public Organism(bool isUnicellular, Cell cell, int organismIndex)
        {
            IsUnicellular = isUnicellular;
            CommonCell = cell;
            OrganismIndex = organismIndex;
        }

        public Organism(bool isUnicellular, Cell cell, int organismIndex, bool isClone) : this(isUnicellular, cell, organismIndex)
        {
            IsClone = isClone;
        }

        public IMyCloneable Clone(bool flag)
        {
            var cell = CommonCell.Clone() as Cell;

            return new Organism(IsUnicellular, cell, OrganismIndex+1, true);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"\nОрганизм {OrganismIndex} существует.\nЯвляется клоном - {IsClone.ToString()}\nПризнак одноядерности - {IsUnicellular.ToString()}.\nБазовая клетка организма следующая - {CommonCell.ToString()}\n";
        }

        public void DescribeOrganism()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
