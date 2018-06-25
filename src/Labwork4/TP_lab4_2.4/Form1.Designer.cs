namespace TP_lab4_2._4
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
            this.xdem = new System.Windows.Forms.TextBox();
            this.ydem = new System.Windows.Forms.TextBox();
            this.getArr = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.op1 = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.Button();
            this.Cnum = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xdem
            // 
            this.xdem.Location = new System.Drawing.Point(17, 62);
            this.xdem.Name = "xdem";
            this.xdem.Size = new System.Drawing.Size(103, 22);
            this.xdem.TabIndex = 0;
            // 
            // ydem
            // 
            this.ydem.Location = new System.Drawing.Point(137, 62);
            this.ydem.Name = "ydem";
            this.ydem.Size = new System.Drawing.Size(100, 22);
            this.ydem.TabIndex = 1;
            // 
            // getArr
            // 
            this.getArr.Location = new System.Drawing.Point(84, 161);
            this.getArr.Name = "getArr";
            this.getArr.Size = new System.Drawing.Size(87, 42);
            this.getArr.TabIndex = 2;
            this.getArr.Text = "Get array";
            this.getArr.UseVisualStyleBackColor = true;
            this.getArr.Click += new System.EventHandler(this.getArr_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(220, 340);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(150, 44);
            this.info.TabIndex = 3;
            this.info.Text = "info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(160, 27);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(97, 43);
            this.op1.TabIndex = 4;
            this.op1.Text = "First operation";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.op1_Click);
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(160, 87);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(97, 44);
            this.op2.TabIndex = 5;
            this.op2.Text = "Second operation";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // op3
            // 
            this.op3.Location = new System.Drawing.Point(160, 141);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(97, 44);
            this.op3.TabIndex = 6;
            this.op3.Text = "Third operation";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // Cnum
            // 
            this.Cnum.Location = new System.Drawing.Point(22, 152);
            this.Cnum.Name = "Cnum";
            this.Cnum.Size = new System.Drawing.Size(97, 22);
            this.Cnum.TabIndex = 7;
            this.Cnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.getArr);
            this.groupBox1.Controls.Add(this.ydem);
            this.groupBox1.Controls.Add(this.xdem);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Array generation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Upper border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lower border";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y demension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "X demension";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cnum);
            this.groupBox2.Controls.Add(this.op3);
            this.groupBox2.Controls.Add(this.op2);
            this.groupBox2.Controls.Add(this.op1);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 206);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "C num";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Upload array";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.info);
            this.Name = "Form1";
            this.Text = "Программа для работы с двумеными массивами";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox xdem;
        private System.Windows.Forms.TextBox ydem;
        private System.Windows.Forms.Button getArr;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Button op2;
        private System.Windows.Forms.Button op3;
        private System.Windows.Forms.TextBox Cnum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

