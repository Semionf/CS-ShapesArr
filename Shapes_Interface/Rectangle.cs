using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Interface
{
    internal class Rectangle:IShape
    {
        private string myColor;

        public string MyColor
        {
            get { return myColor; }
            set { if (myColor == null) myColor = value; }
        }

        private int width;

        public int MyWidth
        {
            get { return width; }
            set { if(width == 0) width = value; }
        }

        private int height;

        public int MyHeight
        {
            get { return height; }
            set { if(height == 0) height = value; }
        }


        public string color()
        {
            return this.myColor;
        }

        public float frameWidth()
        {
            return (float)this.width * this.height;
        }

        public int KodkodimCount()
        {
            return 4;
        }
    }
}
