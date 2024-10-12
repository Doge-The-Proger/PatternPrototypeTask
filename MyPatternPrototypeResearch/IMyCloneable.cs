namespace MyPatternPrototypeResearch
{
    /// <summary>
    /// Интерфес, реализующий паттерн Prototype
    /// </summary>
    public interface IMyCloneable
    {
        /// <summary>
        /// Метод неполного копирования объекта
        /// </summary>
        /// <param name="flag">параметр-заглушка для одновременной работы с ICloneable интерфейсом</param>
        /// <returns></returns>
        IMyCloneable Clone(bool flag);
    }
}
