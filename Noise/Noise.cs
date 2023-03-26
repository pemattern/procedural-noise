using System.Numerics;

namespace Noise
{
    public abstract class Noise<T> where T : IFloatingPoint<T>
    {
        public Vector3<T> Scale { get; set; }
        public T Seed { get; set; }

        public Noise() { Seed = GenerateSeed(); Scale = new Vector3<T>(T.CreateChecked(1), T.CreateChecked(1), T.CreateChecked(1)); }
        public Noise(T seed) { Seed = seed; Scale = new Vector3<T>(T.CreateChecked(1), T.CreateChecked(1), T.CreateChecked(1)); }

        public T Get(int x) => GetUnscaled(T.CreateChecked(x) * Scale.X);
        public T Get(int x, int y) => GetUnscaled(T.CreateChecked(x) * Scale.X, T.CreateChecked(y) * Scale.Y);
        public T Get(int x, int y, int z) => GetUnscaled(T.CreateChecked(x) * Scale.X, T.CreateChecked(y) * Scale.Y, T.CreateChecked(z) * Scale.Z);

        public void SetScale(T x) { Scale.X = x; }
        public void SetScale(T x, T y) { Scale.X = x; Scale.Y = y; }
        public void SetScale(T x, T y, T z) { Scale.X = x; Scale.Y = y; Scale.Z = z; }

        protected abstract T GetUnscaled(T x);
        protected abstract T GetUnscaled(T x, T y);
        protected abstract T GetUnscaled(T x, T y, T z);

        private static T GenerateSeed()
        {
            int i = new Random(Guid.NewGuid().GetHashCode()).Next();
            return (T.CreateChecked(i) / T.CreateChecked(int.MaxValue));
        }
    }
}
