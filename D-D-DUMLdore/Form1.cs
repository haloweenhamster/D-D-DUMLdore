using System;
using System.Windows.Forms;

namespace DDDUMLdore
{

    public partial class Form1 : Form
    {  

        public Form1()
        {
            
        }

        private void btnDUML_Click(object sender, EventArgs e)
        {
            DUMLdore.Form1 DUML = new DUMLdore.Form1();
            DUML.Show();
        }

        private void btnDDD_Click(object sender, EventArgs e)
        {
            cs2000.Form1 DDD = new cs2000.Form1();
            DDD.Show();
        }

        private void dDDmu_Click(object sender, EventArgs e)
        {
            cs2000.Form1 DDD = new cs2000.Form1();
            DDD.Show();
        }

        private void dUMLmu_Click(object sender, EventArgs e)
        {
            DUMLdore.Form1 DUML = new DUMLdore.Form1();
            DUML.Show();
        }
        
    }
}