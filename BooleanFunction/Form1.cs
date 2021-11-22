using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooleanFunction
{
    public partial class Form1 : Form
    {
        public int CountVariable { get; set; }
        public int[,] Matrix;

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.ColumnCount = 0;
        }

        private void Count_Of_Variables_TextChanged(object sender, EventArgs e)
        {
            if (Count_Of_Variables.Text != "")
            {
                tableLayoutPanel1.Controls.Clear();
                CountVariable = int.Parse(Count_Of_Variables.Text);
                tableLayoutPanel1.ColumnCount = CountVariable;
            }
        }
        private void FillTable()
        {

            List<List<int>> arr = new List<List<int>>();
            var temp = Math.Pow(2, CountVariable);
            var t = 0;
            for (int i = 0; i < CountVariable; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    t = (int)(temp / Math.Pow(2, i));
                    int c = t+1;
                    if(j<t)
                    {
                        TextBox textBox = new TextBox()
                        {
                            Width = 20,
                            Height = 20,
                            Text = "0",

                            Enabled = false,
                        };
                        tableLayoutPanel1.Controls.Add(textBox, i, j);
                    }
                    else
                    {
                        TextBox textBox = new TextBox()
                        {
                            Width = 20,
                            Height = 20,
                            Text = "1",

                            Enabled = false,
                        };
                        tableLayoutPanel1.Controls.Add(textBox, i, j);
                    }
                    
                }
            }
            for (int j = 0; j < temp; j++)
            {
                TextBox textBox = new TextBox()
                {
                    Width = 20,
                    Height = 20,
                    Text = "0",
                };
                tableLayoutPanel2.Controls.Add(textBox, 0, j);
            }

            Matrix = new int[CountVariable, CountVariable];
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            FillTable();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            Create_Forms.Visible = true;
        }
    }
}
