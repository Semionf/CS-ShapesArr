using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Interface
{
    internal partial class Circle:IShape
    {
        private string myColor;

        public string MyColor
        {
            get { return myColor; }
            set { if (myColor == null) myColor = value; }
        }
		private int radius;

        public int MyRadius
		{
			get { return radius; }
			set { if(radius == 0) radius = value; }
		}
        public string color()
        {
            return this.myColor;
        }

        public float frameWidth()
        {
            return 2*(float)3.14*radius;
        }

        public int KodkodimCount()
        {
            return 0;
        }
    }
    internal partial class Circle
    {
        private int radius2;

        public int MyRadius2
        {
            get { return radius2; }
            set { if (radius2 == 0) radius2 = value; }
        }
        public float frameWidthElipsa()
        {
            return radius2* (float)3.14 * radius;
        }

        public void roll()
        {
            MessageBox.Show("You have rolled the shape");
        }
    }
}
