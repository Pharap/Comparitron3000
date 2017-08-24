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

        public string BasePath { get; set; } = @"";

        private void Reload()
        {
            //Unmagick these strings at some point;
            var digits = 6;
            string frameIndex = Frame.ToString("D" + digits);

            pathTV = BasePath + "OLD/TV-" + frameIndex + ".jpg";
            if(File.Exists(pathTV))
                imageTV = Image.FromFile(pathTV);

            pathBD = BasePath + "NEW/BD-" + frameIndex + ".jpg";
            if(File.Exists(pathBD))
                imageBD = Image.FromFile(pathBD);

            pathMX = BasePath + "MIX/MX-" + frameIndex + ".jpg";
            if(File.Exists(pathMX))
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
