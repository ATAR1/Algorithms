namespace Algorithms.Sort
{
    public static class Utils
    {
        public static void Swap<T>(T[] mass, int leftIndex, int rightIndex)
        {
            T temp = mass[leftIndex];
            mass[leftIndex] = mass[rightIndex];
            mass[rightIndex] = temp;
        }
    }
}
