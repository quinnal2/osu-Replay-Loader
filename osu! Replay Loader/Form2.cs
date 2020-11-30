using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace osu__Replay_Loader
{
    public partial class Form2 : Form
    {
        Form1 previousForm;
        private string folderName;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 pf)
        {
            previousForm = pf;
            folderName = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            previousForm.Activate();
        }

        private void chooseReplayButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Select the folder that contains your local osu! replays";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog.SelectedPath;
                Console.WriteLine(folderName);
            }
        }

        public string getReplayFolder()
        {
            return folderName;
        }
    }
}
