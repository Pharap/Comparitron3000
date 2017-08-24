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
        Image imageTV, imageBD, imageMX;

        private DisplayType mode = DisplayType.Split;
        private float transition = 50;

        public DisplayType Mode
        {
            get { return mode; }
            set
            {
                this.mode = value;
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
