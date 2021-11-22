
namespace BooleanFunction
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Count_Of_Variables = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Create = new System.Windows.Forms.Button();
            this.Create_Forms = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество переменных";
            // 
            // Count_Of_Variables
            // 
            this.Count_Of_Variables.Location = new System.Drawing.Point(113, 70);
            this.Count_Of_Variables.Name = "Count_Of_Variables";
            this.Count_Of_Variables.Size = new System.Drawing.Size(20, 20);
            this.Count_Of_Variables.TabIndex = 10;
            this.Count_Of_Variables.TextChanged += new System.EventHandler(this.Count_Of_Variables_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 496);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(232, 42);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(57, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Создать пустую матрицу";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Create_Forms
            // 
            this.Create_Forms.Location = new System.Drawing.Point(23, 614);
            this.Create_Forms.Name = "Create_Forms";
            this.Create_Forms.Size = new System.Drawing.Size(167, 31);
            this.Create_Forms.TabIndex = 19;
            this.Create_Forms.Text = "Создать СКНФ и СДНФ";
            this.Create_Forms.UseVisualStyleBackColor = true;
            this.Create_Forms.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(286, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(51, 496);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Create_Forms);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Count_Of_Variables);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Count_Of_Variables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Create_Forms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

