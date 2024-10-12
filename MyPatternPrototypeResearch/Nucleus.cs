namespace MyPatternPrototypeResearch
{
    /// <summary>
    /// Класс, отражающий орган ЯДРО в клетке
    /// </summary>
    public class Nucleus : IMyCloneable, ICloneable
    {
        /// <summary>
        /// Кол-во ядер в органе
        /// </summary>
        public int NucleusCount { get; }

        public Nucleus(int nucleusCount) 
        { 
            NucleusCount = nucleusCount;
        }

        public IMyCloneable Clone (bool flag)
        {
            return new Nucleus(NucleusCount);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Ядро организма. Кол-во ядер - {NucleusCount}";
        }
    }
}
