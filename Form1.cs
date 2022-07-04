using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.FileName = "";
            var open = openFileDialog1.ShowDialog();
            if (open == DialogResult.OK)
            {
                openFileDialog1.Filter = "Archivos de Texto|*.txt;*.text";
                System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
                r = archivo.ReadToEnd();
                richTextBox1.Text = r.ToString();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmt = fontDialog1.ShowDialog();
            if (fmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
