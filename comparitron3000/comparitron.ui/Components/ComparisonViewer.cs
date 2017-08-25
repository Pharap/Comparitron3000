using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace comparitron.ui
{
    class ComparisonViewer : PictureBox
    {
        private Image imageTV, imageBD, imageMX;
        public string pathTV { get; set; }
        public string pathBD { get; set; }
        public string pathMX { get; set;}

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
            var digits = 6;
            string frameIndex = Frame.ToString("D" + digits);

            //Only load needed images
            if (mode == DisplayType.Difference)
            {
                pathMX = BasePath + "mix/MX-" + frameIndex + ".jpg";
                if (File.Exists(pathMX))
                    imageMX = Image.FromFile(pathMX);
            }
            else
            {
                pathTV = BasePath + "old/TV-" + frameIndex + ".jpg";
                if (File.Exists(pathTV))
                    imageTV = Image.FromFile(pathTV);

                pathBD = BasePath + "new/BD-" + frameIndex + ".jpg";
                if (File.Exists(pathBD))
                    imageBD = Image.FromFile(pathBD);
            }
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            switch(mode)
            {
                case DisplayType.Difference:
                    {
                        
                    };break;
                case DisplayType.Crossfade:
                    {

                    };break;
                case DisplayType.Split:
                    {

                    }; break;
            }
            base.OnPaint(pe);
        }
    }
}
