using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Interface
{
    internal class Moon : IShape
    {
        private string myColor;

        public string MyColor
        {
            get { return myColor; }
            set { if (myColor == null) myColor = value; }
        }

        private int distance;

        public int MyDistance
        {
            get { return distance; }
            set { distance = value; }
        }


        public string color()
        {
            return myColor;
        }

        public float frameWidth()
        {
            return distance * (float)3.14;
        }

       

        public void roll()
        {
            MessageBox.Show("You rolled the moon!");
        }

        public int KodkodimCount()
        {
            return 2;
        }
    }
}
