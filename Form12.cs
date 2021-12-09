using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab28
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void WriteFile()
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow row in Slovar.Rows)
                if (row.Cells[0].Value != null)
                if (row.Cells[0].Value.ToString() != "" || row.Cells[1].Value.ToString() != "")
                    list.Add(row.Cells[0].Value + "/" + row.Cells[1].Value);
            File.WriteAllLines("dictionary.txt", list);
        }
        private void ReadFile()
        {
            List<string> list = new List<string>();
            foreach (string str in File.ReadAllLines("dictionary.txt"))
                list.Add(str);
            Slovar.RowCount = list.Count + 1;
            foreach (DataGridViewRow row in Slovar.Rows)
            {
                if (list.Count != 0)
                {
                    row.Cells[0].Value = list[0].Split('/')[0];
                    row.Cells[1].Value = list[0].Split('/')[1];
                    list.RemoveAt(0);
                }
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("dictionary.txt"))
                ReadFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Бажаєте зберегти зміни в словнику?", 
                "Увага!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                WriteFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (textBoxStart.Text == "")
            {
                labelPodsk.Visible = true;
                labelPodskazka.Visible = false;
                textBoxFinal.Text = "";
                return;
            }
            else
            {
                labelPodsk.Visible = false;
                textBoxFinal.Text = "Немає в словнику!";
            }
                
            foreach (DataGridViewRow row in Slovar.Rows)
            { 
                if (row.Cells[0].Value != null & row.Cells[1].Value != null) { 
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(textBoxStart.Text.ToLower()))
                {
                    label4.Visible = true;
                    labelPodskazka.Visible = true;
                    labelPodskazka.Text = row.Cells[0].Value.ToString();
                    labelPodskazka.Click += PodClick;
                }
                if (row.Cells[1].Value.ToString().ToLower().StartsWith(textBoxStart.Text.ToLower()))
                {
                    label4.Visible = true;
                    labelPodskazka.Visible = true;
                    labelPodskazka.Text = row.Cells[1].Value.ToString();
                    labelPodskazka.Click += PodClick;
                }
                if (row.Cells[0].Value.ToString().ToLower() == textBoxStart.Text.ToLower())
                {
                    textBoxFinal.Text = row.Cells[1].Value.ToString();
                    label4.Visible = false;
                    labelPodskazka.Visible = false;
                }
                if (row.Cells[1].Value.ToString().ToLower() == textBoxStart.Text.ToLower())
                {
                    textBoxFinal.Text = row.Cells[0].Value.ToString();
                    label4.Visible = false;
                    labelPodskazka.Visible = false;
                }
                }
            }
        }
        private void PodClick(object sender, EventArgs e)
        {
            textBoxStart.Text = ((Label)sender).Text;
        }
    }
}
