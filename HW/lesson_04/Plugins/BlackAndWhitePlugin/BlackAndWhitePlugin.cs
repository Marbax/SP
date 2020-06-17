using Interface;
using System.Drawing;

namespace BlackAndWhitePlugin
{
    public class BlackAndWhitePlugin : Interface.IPlugin
    {
        public string Name => "Trasnform to black and white";

        public string Version => "1.0";

        public string Author => "Marbax";

        public void Transform(IMainApp app)
        {
            Bitmap bitmap = app.Image;

            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                var gray_matrix = new float[][] {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] { 0,      0,      0,      1, 0 },
                new float[] { 0,      0,      0,      0, 1 }
            };

                var ia = new System.Drawing.Imaging.ImageAttributes();
                ia.SetColorMatrix(new System.Drawing.Imaging.ColorMatrix(gray_matrix));
                ia.SetThreshold(0.8f);
                var rc = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                gr.DrawImage(bitmap, rc, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, ia);
            }

            app.Image = bitmap;
        }
    }
}
