namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.method3Button = new System.Windows.Forms.RadioButton();
            this.method2Button = new System.Windows.Forms.RadioButton();
            this.method1Button = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelA.Location = new System.Drawing.Point(23, 58);
            this.labelA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(40, 22);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a =";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(75, 53);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ShortcutsEnabled = false;
            this.textBoxA.Size = new System.Drawing.Size(264, 31);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAKeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(75, 102);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ShortcutsEnabled = false;
            this.textBoxB.Size = new System.Drawing.Size(264, 31);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBKeyPress);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelB.Location = new System.Drawing.Point(23, 105);
            this.labelB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(40, 22);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b =";
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(75, 152);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ShortcutsEnabled = false;
            this.textBoxC.Size = new System.Drawing.Size(264, 31);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCKeyPress);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelC.Location = new System.Drawing.Point(23, 155);
            this.labelC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(39, 22);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "c =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.labelC);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.labelB);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.labelA);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(378, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coefficients";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxX2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(417, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(378, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solution";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxX2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.Location = new System.Drawing.Point(75, 102);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.ShortcutsEnabled = false;
            this.textBoxX2.Size = new System.Drawing.Size(264, 31);
            this.textBoxX2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "x2 =";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxX1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(75, 53);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.ShortcutsEnabled = false;
            this.textBoxX1.Size = new System.Drawing.Size(264, 31);
            this.textBoxX1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "x1 =";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.method3Button);
            this.groupBox3.Controls.Add(this.method2Button);
            this.groupBox3.Controls.Add(this.method1Button);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(17, 234);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(378, 208);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // method3Button
            // 
            this.method3Button.AutoSize = true;
            this.method3Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method3Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.method3Button.Location = new System.Drawing.Point(27, 153);
            this.method3Button.Name = "method3Button";
            this.method3Button.Size = new System.Drawing.Size(117, 26);
            this.method3Button.TabIndex = 9;
            this.method3Button.TabStop = true;
            this.method3Button.Text = "method 3";
            this.method3Button.UseVisualStyleBackColor = true;
            this.method3Button.CheckedChanged += new System.EventHandler(this.method3ButtonCheckedChanged);
            // 
            // method2Button
            // 
            this.method2Button.AutoSize = true;
            this.method2Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method2Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.method2Button.Location = new System.Drawing.Point(27, 103);
            this.method2Button.Name = "method2Button";
            this.method2Button.Size = new System.Drawing.Size(117, 26);
            this.method2Button.TabIndex = 1;
            this.method2Button.TabStop = true;
            this.method2Button.Text = "method 2";
            this.method2Button.UseVisualStyleBackColor = true;
            this.method2Button.CheckedChanged += new System.EventHandler(this.method2ButtonCheckedChanged);
            // 
            // method1Button
            // 
            this.method1Button.AutoSize = true;
            this.method1Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method1Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.method1Button.Location = new System.Drawing.Point(27, 54);
            this.method1Button.Name = "method1Button";
            this.method1Button.Size = new System.Drawing.Size(117, 26);
            this.method1Button.TabIndex = 0;
            this.method1Button.TabStop = true;
            this.method1Button.Text = "method 1";
            this.method1Button.UseVisualStyleBackColor = true;
            this.method1Button.CheckedChanged += new System.EventHandler(this.method1ButtonCheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.clearButton);
            this.groupBox4.Controls.Add(this.closeButton);
            this.groupBox4.Controls.Add(this.countButton);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(417, 234);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox4.Size = new System.Drawing.Size(378, 208);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(27, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(148, 47);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(191, 114);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(148, 47);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countButton.Location = new System.Drawing.Point(27, 44);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(148, 47);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "count";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Qudratic Equation Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton method3Button;
        private System.Windows.Forms.RadioButton method2Button;
        private System.Windows.Forms.RadioButton method1Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

