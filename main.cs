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
using System.Drawing.Printing;
namespace lamp_src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        



        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string title = "new";
            TabPage myTabPage = new TabPage(title);
            Files.TabPages.Add(myTabPage);

            
            RichTextBox myTextBox = new RichTextBox();
            
             myTextBox.Parent = myTabPage;
            myTextBox.Height = 417;
            myTextBox.Width = 778;
            
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
            System.Diagnostics.Process.Start("http://google.com");
        }
    }
}
