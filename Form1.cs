using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Get_Password
{
    public partial class PASSWORD : Form
    {
        public PASSWORD()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
           
            string PASS = "";
            for(short i = 1; i <= 16;i++)
            {
                
                if (ran.Next(1,3) == 1)
                {
                    PASS += (Convert.ToChar(ran.Next(65, 91)));
                }
                else
                {
                    PASS += (Convert.ToString(ran.Next(0, 10)));
                }
                if (i % 4 == 0 && i != 16)
                    PASS += " - ";
            }
            textBox1.Text = PASS;
        }

     

      
       

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
