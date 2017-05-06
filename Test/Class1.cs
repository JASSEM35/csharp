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

        string fname;
        public Class1(string name)
        {
            fname = name;
            FirstName = name;
        }

        public string FirstName
        {
            get{ return fname; }
        }

    }
}
