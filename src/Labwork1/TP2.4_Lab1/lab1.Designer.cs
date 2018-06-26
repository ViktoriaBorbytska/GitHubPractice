namespace TP2._4_Lab1
{
    partial class lab1
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
            this.multiply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(469, 179);
            this.multiply.Margin = new System.Windows.Forms.Padding(5);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(155, 67);
            this.multiply.TabIndex = 1;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(34, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 39);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод слогаемых";
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(635, 257);
            this.equal.Margin = new System.Windows.Forms.Padding(5);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(154, 67);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Location = new System.Drawing.Point(635, 20);
            this.square.Margin = new System.Windows.Forms.Padding(5);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(154, 66);
            this.square.TabIndex = 4;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.Location = new System.Drawing.Point(635, 102);
            this.sin.Margin = new System.Windows.Forms.Padding(5);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(154, 67);
            this.sin.TabIndex = 5;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial.Location = new System.Drawing.Point(635, 179);
            this.factorial.Margin = new System.Windows.Forms.Padding(5);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(154, 69);
            this.factorial.TabIndex = 6;
            this.factorial.Text = "Factorial";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(469, 20);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(155, 67);
            this.add.TabIndex = 7;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(469, 102);
            this.sub.Margin = new System.Windows.Forms.Padding(5);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(155, 67);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.Location = new System.Drawing.Point(469, 257);
            this.div.Margin = new System.Windows.Forms.Padding(5);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(155, 67);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 785);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.square);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.multiply);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "lab1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        //private System.Windows.Forms.Button factorial;
    }
}

