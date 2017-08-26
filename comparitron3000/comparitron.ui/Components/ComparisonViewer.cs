using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Text;

namespace comparitron.ui
{
    class ComparisonViewer : PictureBox
    {
        private Image imageTV;
        private Image imageBD;
        private Image imageMX;

        public string pathTV { get; set; } = null;
        public string pathBD { get; set; } = null;
        public string pathMX { get; set; } = null;

        public string BasePath { get; set; } = @"";

        private int frame = 1;
        public int Frame
        {
            get
            {
                return this.frame;
            }
            set
            {
                if (value != frame)
                {
                    Reload();
                    Invalidate();
                }
                this.frame = value;
            }
        }

        private static int freeCountMax = 10;
        private int freeCount = 10;

        private DisplayType mode = DisplayType.Split;
        private float transition = 50;

        public DisplayType Mode
        {
            get { return mode; }
            set
            {
                this.mode = value;
                this.Reload();
                this.Invalidate();
            }
        }

        public float Transition
        {
            get { return this.transition; }
            set
            {
                this.transition = value;
                this.Invalidate();
            }
        }


        private void Reload()
        {
            //Unmagick these all these things at some point;
            var digits = 5;
            string frameIndex = Frame.ToString("D" + digits);

            //Free images every 50 frames so you don't run out of memory
            if(--freeCount < 0)
            {
                if (imageMX != null)
                    imageMX.Dispose();
                if (imageTV != null)
                    imageTV.Dispose();
                if (imageBD != null)
                    imageBD.Dispose();
                freeCount = freeCountMax;
            }

            //Only load needed images
            if (mode == DisplayType.Difference)
            {
                pathMX = BasePath + @"\mix\MX-" + frameIndex + ".jpg";
                if (File.Exists(pathMX))
                {
                    imageMX = Image.FromFile(pathMX);
                }
            }
            else
            {
                pathTV = BasePath + @"\old\TV-" + frameIndex + ".jpg";
                if (File.Exists(pathTV))
                {
                    imageTV = Image.FromFile(pathTV);
                }

                pathBD = BasePath + @"\new\BD-" + frameIndex + ".jpg";
                if (File.Exists(pathBD))
                {
                    imageBD = Image.FromFile(pathBD);
                }
            }

        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics graphics = pe.Graphics;

            switch (mode)
            {
                case DisplayType.Difference:
                    {
                        if (imageMX != null)
                            graphics.DrawImage(imageMX, 0, 0);

                    };break;
                case DisplayType.Crossfade:
                    {
                        if (imageTV != null)
                            graphics.DrawImage(imageTV, 0, 0);

                        if(imageBD != null)
                        {

                        }

                    };break;
                case DisplayType.Split:
                    {
                        int mid = 0;
                        if (imageTV != null)
                        {
                            graphics.DrawImage(imageTV, 0, 0);
                        }
                        
                        if (imageBD != null)
                        {
                            mid = (int)(imageBD.Width * (transition / 100));

                            graphics.DrawImage(imageBD,
                                new Rectangle(mid, 0, imageBD.Width - mid, imageBD.Height),
                                new Rectangle(mid, 0, imageBD.Width - mid, imageBD.Height),
                                GraphicsUnit.Pixel);

                            graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(mid - 3, 0, 6, imageBD.Height)); //grab bar thing
                        }


                    }; break;
            }
            base.OnPaint(pe);
        }
    }
}
