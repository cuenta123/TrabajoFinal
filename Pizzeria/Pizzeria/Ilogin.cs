using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    interface Ilogin
    {
        void button1_Click(object sender, EventArgs e);
        void LinkNewRegistre(object sender, LinkLabelLinkClickedEventArgs e);
        void textBox1_KeyPress(object sender, KeyPressEventArgs e);
        void textBox2_KeyPress(object sender, KeyPressEventArgs e);
    }
}
