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
using System.Windows;
using System.Drawing.Printing;
namespace lamp_src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }


        string content;

        

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string title = "new";
            TabPage myTabPage = new TabPage(title);
            Files.TabPages.Add(myTabPage);

            
            RichTextBox myTextBox = new RichTextBox();
            
             myTextBox.Parent = myTabPage;
            myTextBox.Height = 417;
            myTextBox.Width = 778;
            myTextBox.Name = title;
            
            while (true)
            {
                wait(1000);
                content = myTextBox.Text;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            
            Files.SelectedTab.Text = openFile.FileName;
            // Sets the SeletectedTab property's text to the file name
            var put = File.ReadAllText(@openFile.FileName);

            richTextBox1.Text = put;
        }

        private void openFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            // Opens file
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Files.TabPages.Remove(Files.SelectedTab);
        }

        private void saveFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(@saveFile.FileName, richTextBox1.Text);

            Files.SelectedTab.Text = saveFile.FileName;
        }

        private void printFileToolStripMenuItem_Click(object sender, EventArgs e)
        { 
           printDialog1.ShowDialog();

           
        }

        private void lampSourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/deniboi123/lamp-src/");
        }

        private void saveContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@Files.SelectedTab.Text, content);
            
            if (content == "")
            {
                File.WriteAllText(@Files.SelectedTab.Text, richTextBox1.Text);
            }
            else { File.WriteAllText(@Files.SelectedTab.Text, richTextBox1.Text); File.WriteAllText(@Files.SelectedTab.Text, content); }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // do something if the form loads, like show a message.

            richTextBox1.Text = "Welcome to Lamp-Text-Editor, you are currently running v0.2b. This verison includes 'Save Contents' button and this message. See the changes at https://github.com/deniboi123/lamp-src/. Full help is at https://lamp-now.web.app/help. Hopefully you enjoy using 'Lamp' and enjoy the free (software and price view) experience. ";
        }
    }
}
