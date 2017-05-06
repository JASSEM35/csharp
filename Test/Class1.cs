using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Class1
    {
        int Number;
        string Name;
        public Class1(string name)
        {
            Name = name;
        }

    public Class1(int number)
        {
            Number = number;    
        }

        public int numberMethod()
         {
            return Number;
         }

        public static void Jassem(string jassem)
        {
            MessageBox.Show(jassem);
        }
        public static void Jassem(int jassem)
        {
            MessageBox.Show(jassem.ToString());
        }
    }
}
