using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_prototype
{
    public partial class NoteApp : Form
    {
        
        public NoteApp()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shows the openFileDialog
            openFileDialog1.ShowDialog();
            //Reads the text file
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            //Displays the text file in the textBox
            richTextBox1.Text = OpenFile.ReadToEnd();
            //Closes the proccess
            OpenFile.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Determines the text file to save to
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(openFileDialog1.FileName);
            //Writes the text to the file
            SaveFile.WriteLine(richTextBox1.Text);
            //Closes the proccess
            SaveFile.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the saveFileDialog
            saveFileDialog1.ShowDialog();
            //Determines the text file to save to
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
            //Writes the text to the file
            SaveFile.WriteLine(richTextBox1.Text);
            //Closes the proccess
            SaveFile.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}