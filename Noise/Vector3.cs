using System.Numerics;

namespace Noise
{
    public class Vector3<T> where T : INumber<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
        public Vector3()
        {
            X = T.CreateChecked(0);
            Y = T.CreateChecked(0);
            Z = T.CreateChecked(0);
        }
        public Vector3(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector3(int x, int y, int z)
        {
            X = T.CreateChecked(x);
            Y = T.CreateChecked(y);
            Z = T.CreateChecked(z);
        }
        public void Set(T x, T y, T z)
        {
            X = x; Y = y; Z = z;
        }
    }
}
