using System;
using System.Drawing;

namespace MemoryTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            var bitmap = (Bitmap)Image.FromFile("cat.jpg");

            // Тестирование пользовательского метода SetPixel
            var timerBitmapEditor = new Timer();
            using (timerBitmapEditor.StartTimer())
            {
                using (var bitmapEditor = new BitmapEditor(bitmap))
                {
                    for (var i = 0; i < bitmap.Width; i++)
                        for (var j = 0; j < bitmap.Height; j++)
                            bitmapEditor.SetPixel(i, j, 255, 255, 255);
                }
            }
            Console.WriteLine($"BitmapEditor SetPixel = {timerBitmapEditor.ElapsedMilliseconds} milliseconds");

            // Тестирование стандартного метода SetPixel
            var timerSetPixel = new Timer();
            using (timerSetPixel.StartTimer())
            {
                for (int i = 0; i < bitmap.Width; i++)
                    for (int j = 0; j < bitmap.Height; j++)
                        bitmap.SetPixel(i, j, Color.Azure);
            }
            Console.WriteLine($"Standart SetPixel = {timerSetPixel.ElapsedMilliseconds} milliseconds");

            Console.ReadLine();
        }
    }
}
