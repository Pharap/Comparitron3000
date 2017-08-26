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
        public Image imageTV;
        public Image imageBD;
        public Image imageMX;

        public string pathTV { get; set; } = null;
        public string pathBD { get; set; } = null;
        public string pathMX { get; set; } = null;

        public string BasePath { get; set; } = @"";

        public bool Slave { get; set; } = false;

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
                    if(!Slave)
                        Reload();

                    Invalidate();
                }
                this.frame = value;
            }
        }

        //View properties
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

        public void importImage(Image imageTV, Image imageBD, Image imageMX)
        {
            this.imageTV = imageTV;
            this.imageBD = imageBD;
            this.imageMX = imageMX;
        }

        private void Reload()
        {
            //Unmagick these all these things at some point;
            var digits = 5;
            string frameIndex = Frame.ToString("D" + digits);

            //Only load needed images
            if (mode == DisplayType.Difference)
            {
                if ((imageMX != null) && (!Slave))
                    imageMX.Dispose();

                pathMX = BasePath + @"\mix\MX-" + frameIndex + ".jpg";
                if (File.Exists(pathMX))
                {
                    imageMX = Image.FromFile(pathMX);
                }
            }
            else
            {
                if ((imageTV != null) && (!Slave))
                    imageTV.Dispose();

                pathTV = BasePath + @"\old\TV-" + frameIndex + ".jpg";
                if (File.Exists(pathTV))
                {
                    imageTV = Image.FromFile(pathTV);
                }

                if ((imageBD != null) && (!Slave))
                    imageBD.Dispose();

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
                        {
                            try { graphics.DrawImage(imageMX, 0, 0); }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine("Exception information: {0}", e);
                            }
                            
                        }

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

            if(Slave)
                graphics.DrawRectangle(new Pen(Color.Black), 0, 0, 16, 16);

            base.OnPaint(pe);
        }
    }
}
