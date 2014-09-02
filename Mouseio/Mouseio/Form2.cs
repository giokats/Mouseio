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
    public partial class Form2 : Form
    {
        // Music Player variable. Για να μην έχουμε απόλυτα μονοπάτια θα πρέπει να προστίθενται
        // οι τυχόν επιλογές στο Resources.resx
        private System.Media.SoundPlayer music_player = new System.Media.SoundPlayer(Mouseio.Properties.Resources.The_More_I_Want);
  

        public Form2()
        {
            InitializeComponent();
        }

        private void μενούToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            this.Hide();
            myform.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 myform = new Form4();
            this.Hide();
            myform.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void εμπρόςToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {          
            music_player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            music_player.Stop();
        }
    }
}
