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

namespace My_Text_Editor_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isChanged=false;
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
            string text = txtText.Text;
            numChar.Text = "";
            numChar.Text = "Number Of Characters: "+text.Length;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            //openFileDialog1.ShowDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog1.FileName);
                txtText.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(txtText.Text);
                writer.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(txtText.Text);
                writer.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyAll_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtText.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtText.SelectedText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtText.SelectedText);
            txtText.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Text += Clipboard.GetText();  
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Undo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtText.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtText.ForeColor = colorDialog1.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor Version 1");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(txtText.Text);
                writer.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtText.SelectedText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtText.SelectedText);
                txtText.SelectedText = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader;
                //openFileDialog1.ShowDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    reader = new StreamReader(openFileDialog1.FileName);
                    txtText.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }

    }
}
