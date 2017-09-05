using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Text;
using System.ComponentModel;

namespace comparitron.ui
{
    class ComparisonViewer : PictureBox
    {
        public Settings settings { get; set;  } = null;

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

        [System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DisplayType Mode
        {
            get { return mode; }
            set
            {
                this.mode = value;
                if (!Slave) { this.Reload(); }
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
            //Sometimes settings goes null and I haven't figured out why. Since it's kinda integral to this working, just abort until it's fixed.
            /*
            if (settings == null)
                return;
            */

            // Paths!
            var digits = 5;
            string frameIndex = Frame.ToString("D" + digits);

            pathTV = BasePath + @"\" + settings.TVFolder + @"\" + settings.TVPrefix + frameIndex + @"." + settings.ImageFormat;
            pathBD = BasePath + @"\" + settings.BDFolder + @"\" + settings.BDPrefix + frameIndex + @"." + settings.ImageFormat;
            pathMX = BasePath + @"\" + settings.MXFolder + @"\" + settings.MXPrefix + frameIndex + @"." + settings.ImageFormat;

            //Only load needed images
            if (mode == DisplayType.Difference)
            {
                if ((imageMX != null) && (!Slave))
                    imageMX.Dispose();

                if (File.Exists(pathMX))
                {
                    imageMX = Image.FromFile(pathMX);
                }
            }
            else
            {
                if ((imageTV != null) && (!Slave))
                    imageTV.Dispose();
                
                if (File.Exists(pathTV))
                {
                    imageTV = Image.FromFile(pathTV);
                }

                if ((imageBD != null) && (!Slave))
                    imageBD.Dispose();
                
                if (File.Exists(pathBD))
                {
                    imageBD = Image.FromFile(pathBD);
                }
            }

        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics graphics = pe.Graphics;

            Point ImageSize = new Point();
            ImageSize.X = this.Size.Width;
            ImageSize.Y = this.Size.Height;

            PointF ImageScale = new PointF(1.0f,1.0f);
            if (imageMX != null)
            {
                ImageScale.X = this.Size.Width / 1280.0f;
                ImageScale.Y = this.Size.Height / 720.0f;
            }

            switch (mode)
            {
                case DisplayType.Difference:
                    {
                        if (imageMX != null)
                        {
                            graphics.DrawImage(imageMX, 0, 0);
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
                            graphics.DrawImage(imageTV,
                                new Rectangle(0, 0, ImageSize.X , ImageSize.Y),
                                new Rectangle(0, 0, imageBD.Width , imageBD.Height),
                                GraphicsUnit.Pixel);
                        }
                        
                        if (imageBD != null)
                        {
                            mid = (int)(imageBD.Width * (transition / 100));

                            graphics.DrawImage(imageBD,
                                new Rectangle((int)(mid * ImageScale.X), 0, (int)((imageBD.Width - mid) * ImageScale.X), ImageSize.Y),
                                new Rectangle(mid, 0, imageBD.Width - mid, imageBD.Height),
                                GraphicsUnit.Pixel);

                            graphics.DrawRectangle(new Pen(Color.Black), new Rectangle((int)(mid * ImageScale.X) - 3, 0, 6, ImageSize.Y)); //grab bar thing
                        }


                    }; break;
            }

            if(Slave)
                graphics.DrawRectangle(new Pen(Color.Black), 0, 0, 16, 16);
            else
            {
                //Bleh.
                using (System.Drawing.Font font = new System.Drawing.Font("Arial", 16))
                {
                    using (System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black))
                    {
                        graphics.DrawString(pathTV + "\r\n" + pathBD + "\r\n" + pathMX, font, brush, new Point(0, 0));
                    }
                }
            }

            base.OnPaint(pe);
        }
    }
}
