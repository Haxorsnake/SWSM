using SWSM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace SWSM
{

    public partial class Form1 : Form
    {
        //FILE VARS
        private string SAVE_LOCATION;
        private string fileDir = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
            InitCustomLabelFont();

            StartPosition = FormStartPosition.CenterScreen;

        }

        //CUSTOM FONT
        public void InitCustomLabelFont()
        {
            //LABEL LIST
            List<Label> labelList = new List<Label>();

            foreach (var lbl in Controls)
            {
                if (lbl.GetType() == typeof(Label))
                {
                    labelList.Add((Label)lbl);
                }
            }

            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Starjedi.ttf"
            int fontLength = Properties.Resources.Starjedi.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Starjedi;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            //After that we can create font and assign font to label
            foreach (var label in labelList)
            {
                label.Font = new Font(pfc.Families[0], label.Font.Size);
            }
        }
        //EXIT BUTTON
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //FILE SELECT
        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SAVE_LOCATION = fbd.SelectedPath;
                TextWriter tw = new StreamWriter(fileDir + "/savedinfo.txt");
                tw.WriteLine(SAVE_LOCATION);
                tw.Close();

                if (validateLocation(SAVE_LOCATION))
                {
                    changeForms();
                } 
                else
                {
                    MessageBox.Show("Location Invalid! Please correct path!");
                }
            }
        }

        //CHANGE FORMS
        private void changeForms()
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(fileDir + "/savedinfo.txt");


            if (lines.Length == 1 && validateLocation(lines[0]))
            {
                System.Diagnostics.Debug.WriteLine("Its 1");
                changeForms();
            }
        }
        private bool validateLocation(string location)
        {
            if (location == "")
            {
                return false;
            }
            else
            {
                if (System.IO.Directory.GetParent(location).Name == "Respawn")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

}
