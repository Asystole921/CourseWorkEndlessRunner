﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Skelet : Transform
    {

        int srcX = 0;
        int srcY = 0;
        int srcW = 0;
        int srcH = 0;
        public int frameCount = 0;
        public int animationCount = 0;

        public Skelet(PointF pos, Size size) : base(pos, size)
        {


        }

        public override void DrawSprite(Graphics g)
        {
            frameCount++;
            if (frameCount <= 500)
            {
                srcX = 340;
                srcY = 240;
                srcW = 90;
                srcH = 60;
                animationCount = 0;
            }
            else if (frameCount > 500 && frameCount <= 550)
            {
                srcX = 440;
                srcY = 240;
                srcW = 90;
                srcH = 60;
                animationCount = 1;
            }
            else if (frameCount > 550 && frameCount <= 600)
            {
                srcX = 10;
                srcY = 360;
                srcW = 130;
                srcH = 60;
                animationCount = 2;
            }
            else if (frameCount > 600 && frameCount <= 650)
            {
                srcX = 140;
                srcY = 330;
                srcW = 100;
                srcH = 90;

                animationCount = 3;
            }
            else if (frameCount > 650 && frameCount <= 700)
            {
                srcX = 280;
                srcY = 330;
                srcW = 100;
                srcH = 90;
                animationCount = 4;
            }
            else if (frameCount > 700 && frameCount <= 750)
            {
                srcX = 410;
                srcY = 330;
                srcW = 100;
                srcH = 90;
                animationCount = 5;
            }

            if (frameCount > 750)
            {
                srcX = 410;
                srcY = 330;
                srcW = 100;
                srcH = 90;
            }


            g.DrawImage(GameController.halloween, new Rectangle((int)position.X, (int)position.Y, (int)size.Width, size.Height),
                srcX, srcY, srcW, srcH, GraphicsUnit.Pixel);
        }

    }
}
