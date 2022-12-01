using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Interface
{
    internal class Triangle:IShape
    {
        private string myColor;

        public string MyColor
        {
            get { return myColor; }
            set { if (myColor == null) myColor = value; }
        }

        private int baseWidth;

		public int MyBaseWidth
		{
			get { return baseWidth; }
			set { if(baseWidth == 0) baseWidth = value; }
		}
		private int height;

		public int MyHeight
		{
			get { return height; }
			set { if(height == 0)height = value; }
		}

        public string color()
        {
            return this.myColor;
        }

        public float frameWidth()
        {
            return (float)height *baseWidth/2;
        }

        public int KodkodimCount()
        {
            return 3;
        }
    }
}
