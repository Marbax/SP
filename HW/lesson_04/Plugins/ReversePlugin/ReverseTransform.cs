﻿using System.Drawing;

namespace ReversePlugin
{
    public class ReverseTransform : Interface.IPlugin
    {
        public string Name {
            get { return "Переворот изображения"; }
        }

        public string Version {
            get { return "1.0"; }
        }

        public string Author {
            get { return "Proger"; }
        }

        public void Transform(Interface.IMainApp app)
        {
            Bitmap bitmap = app.Image;

            for (int i = 0; i < bitmap.Width; ++i)
                for (int j = 0; j < bitmap.Height / 2; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, bitmap.GetPixel(i, bitmap.Height - j - 1));
                    bitmap.SetPixel(i, bitmap.Height - j - 1, color);
                }

            app.Image = bitmap;
        }
    }
}
