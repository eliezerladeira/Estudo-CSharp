using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;

            MessageBox.Show("x = " + x);
            MessageBox.Show("The value of x + x is " + (x + x));
            MessageBox.Show("x = ");
            MessageBox.Show((x + y) + " = " + (y + x));
        }
    }
}