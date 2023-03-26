using System.Numerics;

namespace Noise
{
    public class WhiteNoise<T> : Noise<T> where T : IFloatingPoint<T>, ITrigonometricFunctions<T>
    {
        public WhiteNoise() : base() { }
        public WhiteNoise(T seed) : base(seed) { }

        protected override T GetUnscaled(T x)
        {
            return Hash(new Vector3<T>(x, T.Zero, T.Zero));
        }
        protected override T GetUnscaled(T x, T y)
        {
            return Hash(new Vector3<T>(x, y, T.Zero));
        }
        protected override T GetUnscaled(T x, T y, T z)
        {
            return Hash(new Vector3<T>(x, y, z));
        }

        T Hash(Vector3<T> vector)
        {
            T random = Dot(vector, new Vector3<T>(T.CreateChecked(12.9898), T.CreateChecked(78.233), T.CreateChecked(37.719)));
            return Frac(T.Sin(random * Seed) * T.CreateChecked(143758.5453));
        }

        private T Dot(Vector3<T> lhs, Vector3<T> rhs) => lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;
        private T Frac(T value) => value - T.Floor(value);
    }
}
