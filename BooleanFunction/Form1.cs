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
using WpfMath;

namespace BooleanFunction
{
    public partial class Form1 : Form
    {
        public int CountVariable { get; set; }
        public int[,] TableOfVerity;
        public int[] FuncOfBoolean;
        public Bitmap bmp;
        public PictureBox pb;
        public TableLayoutPanel tableLayoutPanel1;
        public TableLayoutPanel tableLayoutPanel2;

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1 = new TableLayoutPanel()
            {
                RowCount = 0,
                ColumnCount = 0,
                AutoSize = true,
            };
            tableLayoutPanel2 = new TableLayoutPanel()
            {
                AutoSize = true,
                Margin = new Padding(20,0,0,0)
            };

        }

        private void Count_Of_Variables_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Count_Of_Variables.Text != "")
                {
                    tableLayoutPanel1.Controls.Clear();
                    tableLayoutPanel2.Controls.Clear();
                    CountVariable = int.Parse(Count_Of_Variables.Text);
                    tableLayoutPanel1.ColumnCount = CountVariable;
                    Create_Forms.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нужны цифры");
                Count_Of_Variables.Text = "";
            }
        }
        private void FillTable()
        {

            List<List<int>> arr = new List<List<int>>();
            int temp = (int)Math.Pow(2, CountVariable);
            TableOfVerity = new int[CountVariable, temp];
            TableOfVerity = FillTableOfVerity();
            FuncOfBoolean = new int[temp];
            decimal bottomsymbol = 8321;
            decimal[] symbolsx = new decimal[CountVariable];
            string tem = "" + 'F'+"(";
            for (int i = 0; i < CountVariable; i++)
            {
                Label label4 = new Label()
                {

                    AutoSize = true,
                    Font = new Font(Font.Name, 15),
                    Text = "x" + (char)bottomsymbol,
                };
                tem +="x" + (char)bottomsymbol + ",";
                
                tableLayoutPanel1.Controls.Add(label4,i,0);
                for (int j = 0; j < temp; j++)
                {
                    TextBox textBox = new TextBox()
                    {
                        Width = 20,
                        Height = 20,
                        Text = TableOfVerity[i, j].ToString(),
                        Enabled=false,
                    };
                    tableLayoutPanel1.Controls.Add(textBox, i, j+1);
                }
                bottomsymbol++;
            }
            tem = tem.Remove(tem.Length - 1);
            tem += ")";
            Label label = new Label()
            {
                AutoSize = true,
                Font = new Font(Font.Name, 15),
                Text=tem,
            };

            tableLayoutPanel2.Controls.Add(label, 0, 0);
            for (int j = 0; j < temp; j++)
            {
                
                TextBox textBox = new TextBox()
                {
                    Width = 20,
                    Height = 20,
                    Text = "0",
                };

                tableLayoutPanel2.Controls.Add(textBox, 0, j+1);
            }

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel2);
        }
        private int[,] FillTableOfVerity()
        {
            int ei = CountVariable - 1;
            string str = "",end="",res="";
            for (int i = 0; i < CountVariable; i++)
            {
                str += "0";
            }
            end = str.Replace('0', '1');
            res = str; 
            while (str != end)
            {
                if (str.EndsWith("1"))
                {
                    for (int i = ei; i >= 0; i--)
                    {
                        if (str[i] == '1')
                        {
                            StringBuilder somestring = new StringBuilder(str);
                            somestring[i] = '0';
                            str = somestring.ToString();
                        }
                        else
                        {
                            StringBuilder somestring = new StringBuilder(str);
                            somestring[i] = '1';
                            str = somestring.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    StringBuilder somestring = new StringBuilder(str);
                    somestring[ei] = '1';
                    str = somestring.ToString();
                }
                res += str;
                //matrix = ToList(str);
            }
            return ToMatrix(res);
        }
        private int [,]ToMatrix(string res)
        {
            int[,] m = new int[(int)Math.Pow(2, CountVariable),CountVariable];
            var d=res.ToArray();
            int t = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i,j] = Convert.ToInt32(d[t].ToString());
                    t++;
                }
            }
            return Transposition(m); 
        }

        private int [,] Transposition(int[,] p)
        {
            int[,] trans = new int[CountVariable, (int)Math.Pow(2, CountVariable)];
            for (int i = 0; i < p.GetLength(1); i++)
            {
                for (int j = 0; j < p.GetLength(0); j++)
                {
                    trans[i,j] = p[j, i];

                }
            }
            return trans;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Count_Of_Variables.Text == "")
            {
                MessageBox.Show("Заполните!");
                return;
            }
            if (Convert.ToInt32(Count_Of_Variables.Text)>6)
            {
                MessageBox.Show("Больше 6 переменных не потяну");
                return;
            }
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel2.Controls.Clear();
            FillTable();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            Create_Forms.Visible = true;
        }
        private void FillMatrix()
        {
            List<TextBox> boxes = new List<TextBox>();
            boxes = tableLayoutPanel2.Controls.OfType<TextBox>().ToList();
            bool check = false;
            for (int i = 0; i < FuncOfBoolean.Length; i++)
            {
                if (int.Parse(boxes[i].Text) == 0 || int.Parse(boxes[i].Text) == 1)
                {
                    FuncOfBoolean[i] = int.Parse(boxes[i].Text);
                }
                else
                {
                    if (!check)
                    {
                        MessageBox.Show("Значение булевой функций принимает только 1 и 0");
                        check = true;
                    }
                    MessageBox.Show($"Элемент на {i+1} строке будет обнулен");
                    boxes[i].Text = "0";
                    continue;
                }
            }
        }
        private void ShowFuncOfBoolean()
        {
            string res = "";
            for (int i = 0; i < FuncOfBoolean.Length; i++)
            {
                res += FuncOfBoolean[i];
            }
            MessageBox.Show(res);
        }
        private void ClearDesition()
        {
            if (pb != null)
            {
                pb.Image.Dispose();
                pb.Dispose();
            }
        }
        private void Create_Forms_Click(object sender, EventArgs e)
        {
           
            ClearDesition();
            FillMatrix();
            bool checkSDNF = false;
            bool checkSKNF = false;
            string F = "F(";
            for (int i = 0; i < CountVariable; i++)
            {
                if (i==CountVariable-1)
                {
                    F += $"x_{i + 1}";
                }
                else
                {
                    F += $"x_{i + 1},";
                }
            }
            F += @")=\\";
            string SKNFstr = @"\text{СКНФ:}\\"+F, SDNFstr= @"\text{СДНФ:}\\"+F;
            for (int j= 0; j < FuncOfBoolean.Length; j++)
            {
                if (FuncOfBoolean[j]==0)
                {
                    checkSKNF = true;
                    SKNFstr += "(";
                    for (int i = 0; i < CountVariable; i++)
                    {
                        if (TableOfVerity[i,j]==1)
                        {
                            if (i == CountVariable - 1)
                            {
                                SKNFstr += @"\overline{x_" + (i + 1) + "}";
                                continue;
                            }
                            SKNFstr += @"\overline{x_"+(i+1)+@"}\wedge ";
                        }
                        else
                        {
                            if (i == CountVariable - 1)
                            {
                                SKNFstr += @"x_" + (i + 1);
                                continue;
                            }
                            SKNFstr+= @"x_" + (i + 1) + @"\wedge ";
                        }
                        
                    }
                    SKNFstr += @")\vee\\";
                }
                if (FuncOfBoolean[j]==1)
                {
                    checkSDNF = true;
                    SDNFstr += "(";
                    for (int i = 0; i < CountVariable; i++)
                    {
                        if (TableOfVerity[i,j]==0)
                        {
                            if (i == CountVariable - 1)
                            {
                                SDNFstr += @"\overline{x_" + (i + 1)+"}";
                                continue;
                            }
                            SDNFstr += @"\overline{x_" + (i + 1) + @"}\vee ";
                        }
                        else
                        {
                            if (i == CountVariable - 1)
                            {
                                SDNFstr += @"x_" + (i + 1);
                                continue;
                            }
                            SDNFstr += @"x_" + (i + 1) + @"\vee ";
                        }
                    }
                    SDNFstr += @")\wedge\\";
                }
                if(j==FuncOfBoolean.Length-1)
                {
                    if (checkSDNF)
                        SDNFstr = SDNFstr.Remove(SDNFstr.Length - 8, 8);
                    else
                        SDNFstr = "";
                    if (checkSKNF)
                        SKNFstr = SKNFstr.Remove(SKNFstr.Length - 6, 6);
                    else
                        SKNFstr = "";
                    SKNFstr += @"\\";
                }
            }
            string result = SKNFstr + SDNFstr;
            PrintLatex(result);
            SetPicture();
        }

       
        private void SetPicture()
        {
            Bitmap bitmap = new Bitmap(1000, 10000);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (Image im=bmp)
                {
                    g.DrawImage(im, new PointF(0, 0));
                }
            }
            scrollBox(bitmap);
        }
        private void scrollBox(Bitmap bitmap)
        {
            pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Image = bitmap;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pb);
        }
        private void PrintLatex(string latex)
        {
            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);

            var pngBytes = formula.RenderToPng(20.0, 10.0, 0.0, "Arial");
            using (var ms = new MemoryStream(pngBytes))
            {
                bmp = new Bitmap(ms);
            }
        }
      
    }
}
