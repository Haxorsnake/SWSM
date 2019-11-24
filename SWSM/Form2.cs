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
    public partial class Form2 : Form
    {
        //DRAGGABLE WINDOW VARS
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Current Save Loc
        private string saveLoc;
        private string fileDir = Directory.GetCurrentDirectory();
        //SAVES
        public Label currentSave;
        Form1 firstForm = new Form1();

        

        public Form2()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

        }

        //DRAGGABLE WINDOW
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(fileDir + "/savedinfo.txt");

            folderLocation.Text = sr.ReadLine();
            sr.Close();

            saveLoc = folderLocation.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dirArray = System.IO.Directory.GetFiles(saveLoc);
            foreach(string filename in dirArray)
            {
                System.Diagnostics.Debug.WriteLine(filename);
            }


        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            Form3 chooseForm = new Form3();
            chooseForm.manageSave(currentSave1);
            chooseForm.Show();

        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            Form3 chooseForm = new Form3();
            chooseForm.manageSave(currentSave2);
            chooseForm.Show();
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            Form3 chooseForm = new Form3();
            chooseForm.manageSave(currentSave3);
            chooseForm.Show();
        }

        private void buttonSave4_Click(object sender, EventArgs e)
        {
            Form3 chooseForm = new Form3();
            chooseForm.manageSave(currentSave4);
            chooseForm.Show();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            //CHECK SAVE DIR
            string[] gameDir = Directory.GetDirectories(saveLoc);
            string gameBackup = saveLoc + "/SWSMBackup";

            //NEW SAVES
            string savesPath = fileDir + "/saves/";
            List<string> savesText = new List<string>();
            Label[] currentSaves = {currentSave1, currentSave2, currentSave3, currentSave4};


            foreach (Label save in currentSaves)
            {
                if (save.Text == null || save.Text == "")
                {
                    continue;
                }
                else
                {
                    savesText.Add(save.Text);
                }
            }

            if (savesText == null || savesText.Count == 0)
            {
                MessageBox.Show("Please Select Saves!");
            }
            else
            {
                //Check game dir and make backup folder if not present
                if (gameDir == null || gameDir.Length == 0)
                {
                    MessageBox.Show("Creating backups!");
                    Directory.CreateDirectory(gameBackup);
                }

                if (Directory.GetFiles(saveLoc) != null || Directory.GetFiles(saveLoc).Length != 0)
                {
                    if(Directory.GetFiles(gameBackup) == null || Directory.GetFiles(gameBackup).Length == 0)
                    {
                        foreach (var file in Directory.GetFiles(saveLoc))
                        {
                            if (Path.GetFileName(file) == "GameUserSettings.sav")
                            {
                                File.Copy(file, (gameBackup + "/" + Path.GetFileName(file)));
                                continue;
                            }
                            System.Diagnostics.Debug.WriteLine(file);
                            string newDest = gameBackup + "/" + Path.GetFileName(file);
                            File.Move(file, newDest);
                        }
                    }
                    else
                    {
                        foreach (var file in Directory.GetFiles(saveLoc))
                        {
                            if (Path.GetFileName(file) == "GameUserSettings.sav")
                            {
                                continue;
                            }
                            File.Delete(file);
                        }
                    }
                }

                foreach (var (save, index) in savesText.WithIndex())
                {
                    string path = savesPath + save;
                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        System.Diagnostics.Debug.WriteLine(fileName);
                        if (fileName == "SaveGame04.sav")
                        {
                            string newFilename = "/SaveGame0" + (index + 1) + ".sav";
                            File.Copy(file, (saveLoc + newFilename));
                        }
                        else if (fileName == "Backup04.sav")
                        {
                            string newFilename = "/Backup0" + (index + 1) + ".sav";
                            File.Copy(file, (saveLoc + newFilename));
                        }
                        else
                        {
                            MessageBox.Show("Error! Filename not correct!");
                        }
                        System.Diagnostics.Debug.WriteLine(file);
                    }
                    
                }

            }

            MessageBox.Show("Success! Saves Loaded!");
        }
    }
}
