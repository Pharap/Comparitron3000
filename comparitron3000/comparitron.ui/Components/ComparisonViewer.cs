using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace comparitron.ui
{
    class ComparisonViewer : PictureBox
    {
        private Image imageTV, imageBD, imageMX;
        private string pathTV, pathBD, pathMX;

        public int Frame = 0;

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

        public string basepath = @"";

        private void Reload()
        {
            var digits = 6;
            string frameIndex = Frame.ToString("D" + digits);

            pathTV = basepath + "TV-" + frameIndex + ".jpg";
            imageTV = Image.FromFile(pathTV);
            pathBD = basepath + "BD-" + frameIndex + ".jpg";
            imageBD = Image.FromFile(pathBD);
            pathMX = basepath + "MX-" + frameIndex + ".jpg";
            imageMX = Image.FromFile(pathMX);
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
