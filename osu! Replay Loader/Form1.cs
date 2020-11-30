using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace osu__Replay_Loader
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            this.Activated += new EventHandler(Form1_Activated);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
            form2.Activate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Console.WriteLine("form 1 shown");
            string folderName = form2.getReplayFolder();

            if (!folderName.Equals(""))
            {
                string[] files = Directory.GetFiles(folderName);

                for (int i = 0; i < files.Length; i++)
                {
                    Label fileNameLabel = new Label();
                    FileAttributes attributes = File.GetAttributes(files[i]);

                    if(!attributes.HasFlag(FileAttributes.Directory))
                    {
                        fileNameLabel.AutoSize = true;
                        fileNameLabel.Text = files[i].Substring(files[i].LastIndexOf('\\') + 1);
                        flowLayoutPanel1.Controls.Add(fileNameLabel);
                    }
                }
            }
        }
    }
}
