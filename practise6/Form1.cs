using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise6
{
    public partial class Form1 : Form
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                Solution generator = new Solution(rnd.Next(99, 9999), rnd.Next(99, 9999), rnd.Next(99, 9999), rnd.Next(99,9999));
                int i = rnd.Next(99, 9999);
                double x = Solution.ICG(5, 2, 3, i);
                double y = Solution.ICG(5, 2, 3, i + 1);
                double b = Solution.ICG(5, 2, 3, i + 2);
                double a = Solution.ICG(5, 2, 3, i + 3);
                Console.WriteLine(generator.Calculate(x, y, b, a));
                Console.WriteLine("----------------------------------------- Eyhenauera");
            }
            if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                int seed = rnd.Next(99, 9999);
                LinearCong generator = new LinearCong(seed);
                double x = generator.NextDouble();
                double y = generator.NextDouble();
                double b = generator.NextDouble();
                double a = generator.NextDouble();

                Solution solution = new Solution(x, y, b, a);
                Console.WriteLine(solution.Calculate(x, y, b, a));
                Console.WriteLine("----------------------------------------- LCG");

            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                throw new Exception("Ero!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!AllocConsole())
                MessageBox.Show("Failed");

            Console.WriteLine("test");
        }
    }
}
