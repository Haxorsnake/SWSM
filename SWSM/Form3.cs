using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSM
{
    public partial class Form3 : Form
    {

        Form2 mainForm = new Form2();
        private Label cSave;
        public Form3()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        public void manageSave(Label save)
        {
            cSave = save;
        }
        //SAVE BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            cSave.Text = button1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cSave.Text = button2.Text;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cSave.Text = button3.Text;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cSave.Text = button4.Text;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cSave.Text = button5.Text;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cSave.Text = button6.Text;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cSave.Text = button7.Text;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cSave.Text = button8.Text;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cSave.Text = button9.Text;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cSave.Text = button10.Text;
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cSave.Text = button11.Text;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cSave.Text = button12.Text;
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cSave.Text = button13.Text;
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cSave.Text = button14.Text;
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cSave.Text = button15.Text;
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cSave.Text = button16.Text;
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cSave.Text = button17.Text;
            this.Close();
        }
    }
}
