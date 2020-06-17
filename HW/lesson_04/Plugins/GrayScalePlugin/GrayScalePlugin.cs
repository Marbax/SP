using Interface;
using System;
using System.Drawing;

namespace GrayScalePlugin
{
    public class GrayScalePlugin : Interface.IPlugin
    {
        public string Name => "Trasnform to gray scale";

        public string Version => "1.0";

        public string Author => "Marbax";

        public void Transform(IMainApp app)
        {
            Bitmap bitmap = app.Image;

            int rgb;
            Color c;

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    c = bitmap.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    bitmap.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
        }
    }
}
