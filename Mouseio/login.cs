using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouseio
{
    public partial class login : Form
    {
        private ChangeColor colors = new ChangeColor();


        public login()
        {
            InitializeComponent();
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length == 0)
            { MessageBox.Show("Λάθος όνομα!"); }
            else if (textBoxCode.Text.Length < 8)
            {
                MessageBox.Show("Λάθος κωδικός!");
            }
            else
            {
                Form2 myform = new Form2();
                this.Hide();
                myform.ShowDialog();
                this.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelWelcome.ForeColor = colors.returnColor();
            colors.changeColor();
        }

    }
}
