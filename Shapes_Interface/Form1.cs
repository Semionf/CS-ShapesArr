namespace Shapes_Interface
{
    public partial class Form1 : Form
    {
        int index = 0;
        IShape[] arr = new IShape[100];
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < 100)
            {
                if (checkBox1.Checked)
                {

                    arr[index] = new Moon();
                    index++;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    arr[index] = new Rectangle();
                    index++;
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    arr[index] = new Triangle();
                    index++;
                    checkBox3.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    arr[index] = new Circle();
                    index++;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    arr[index] = new Circle();
                    index++;
                    checkBox5.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberOfKodkodim = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Triangle) 
                {
                    Triangle t1 = (Triangle)arr[i];
                    numberOfKodkodim += t1.KodkodimCount();
                }
                if (arr[i] is Moon)
                {
                    Moon m1 = (Moon)arr[i];
                    numberOfKodkodim += m1.KodkodimCount();
                }
                if (arr[i] is Rectangle)
                {
                    Rectangle r1 = (Rectangle)arr[i];
                    numberOfKodkodim += r1.KodkodimCount();
                }
            }
            label1.Text = numberOfKodkodim.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void click1(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }
        private void click2(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }
        private void click3(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }
        private void click4(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }
        private void click5(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }
    }
}