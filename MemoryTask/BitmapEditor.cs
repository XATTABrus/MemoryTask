using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MemoryTask
{
    internal class BitmapEditor : IDisposable
    {
        private readonly Bitmap _bitmap;
        private readonly BitmapData _bitmapData;

        public BitmapEditor(Bitmap bitmap)
        {
            _bitmap = bitmap;
            _bitmapData = _bitmap.LockBits(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), ImageLockMode.ReadWrite, _bitmap.PixelFormat);
        }

        public void SetPixel(int x, int y, byte red, byte green, byte blue)
        {
            if(x >= _bitmap.Width || y >= _bitmap.Height)
                throw new ArgumentException("Данная точка выходит за границы изображения!");

            var color = new[] {blue, green, red};
            Marshal.Copy(color, 0, IntPtr.Add(_bitmapData.Scan0, y * _bitmapData.Stride + x * 3), 3);
        }

        #region IDisposable Support
        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _bitmap.UnlockBits(_bitmapData);
                }
                _disposedValue = true;
            }
        }

        ~BitmapEditor()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}