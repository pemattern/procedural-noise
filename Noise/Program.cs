using Noise;
using System.Drawing;
using System.Numerics;

WhiteNoise<double> noise = new WhiteNoise<double>();
Color GetClosestColor<T>(T v) where T : IFloatingPoint<T>
{
    int brightness = int.CreateChecked(v * T.CreateChecked(255));
    Color color = Color.FromArgb(255, brightness, brightness, brightness);
    return color;
}

Bitmap bitmap = new Bitmap(1024, 1024);

for (int x = 0; x < bitmap.Width; x++)
{
    for (int y = 0; y < bitmap.Height; y++)
    {
        bitmap.SetPixel(x, y, GetClosestColor<double>(noise.Get(x, y)));
    }
}

bitmap.Save("...");

bitmap.Save("C:\\Users\\pemat\\source\\repos\\Noise\\Noise\\noise.bmp");