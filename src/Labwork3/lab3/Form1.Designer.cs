namespace lab3
{
    partial class ArrayProcessingForm
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
            this.components = new System.ComponentModel.Container();
            this.numOfElemsBox = new System.Windows.Forms.TextBox();
            this.numOfElemsLabel = new System.Windows.Forms.Label();
            this.lowerBoundLabel = new System.Windows.Forms.Label();
            this.lowerBoundBox = new System.Windows.Forms.TextBox();
            this.upperBoundLabel = new System.Windows.Forms.Label();
            this.upperBoundBox = new System.Windows.Forms.TextBox();
            this.arrayDataBox = new System.Windows.Forms.TextBox();
            this.generateArray = new System.Windows.Forms.Button();
            this.cValueLabel = new System.Windows.Forms.Label();
            this.cValueBox = new System.Windows.Forms.TextBox();
            this.func1 = new System.Windows.Forms.Button();
            this.func2 = new System.Windows.Forms.Button();
            this.func3 = new System.Windows.Forms.Button();
            this.func4 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.arraySettingsBox = new System.Windows.Forms.GroupBox();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.operationsBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileDialogsBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.arraySettingsBox.SuspendLayout();
            this.dataBox.SuspendLayout();
            this.operationsBox.SuspendLayout();
            this.fileDialogsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOfElemsBox
            // 
            this.numOfElemsBox.Location = new System.Drawing.Point(228, 34);
            this.numOfElemsBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numOfElemsBox.Name = "numOfElemsBox";
            this.numOfElemsBox.ShortcutsEnabled = false;
            this.numOfElemsBox.Size = new System.Drawing.Size(203, 31);
            this.numOfElemsBox.TabIndex = 0;
            this.numOfElemsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numOfElemsBoxKeyPress);
            // 
            // numOfElemsLabel
            // 
            this.numOfElemsLabel.AutoSize = true;
            this.numOfElemsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numOfElemsLabel.Location = new System.Drawing.Point(17, 37);
            this.numOfElemsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numOfElemsLabel.Name = "numOfElemsLabel";
            this.numOfElemsLabel.Size = new System.Drawing.Size(199, 22);
            this.numOfElemsLabel.TabIndex = 1;
            this.numOfElemsLabel.Text = "Number of elements:";
            // 
            // lowerBoundLabel
            // 
            this.lowerBoundLabel.AutoSize = true;
            this.lowerBoundLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lowerBoundLabel.Location = new System.Drawing.Point(17, 82);
            this.lowerBoundLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lowerBoundLabel.Name = "lowerBoundLabel";
            this.lowerBoundLabel.Size = new System.Drawing.Size(137, 22);
            this.lowerBoundLabel.TabIndex = 3;
            this.lowerBoundLabel.Text = "Lower bound:";
            // 
            // lowerBoundBox
            // 
            this.lowerBoundBox.Location = new System.Drawing.Point(228, 79);
            this.lowerBoundBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lowerBoundBox.Name = "lowerBoundBox";
            this.lowerBoundBox.ShortcutsEnabled = false;
            this.lowerBoundBox.Size = new System.Drawing.Size(203, 31);
            this.lowerBoundBox.TabIndex = 2;
            this.lowerBoundBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowerBoundBoxKeyPress);
            // 
            // upperBoundLabel
            // 
            this.upperBoundLabel.AutoSize = true;
            this.upperBoundLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upperBoundLabel.Location = new System.Drawing.Point(17, 126);
            this.upperBoundLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.upperBoundLabel.Name = "upperBoundLabel";
            this.upperBoundLabel.Size = new System.Drawing.Size(138, 22);
            this.upperBoundLabel.TabIndex = 5;
            this.upperBoundLabel.Text = "Upper bound:";
            // 
            // upperBoundBox
            // 
            this.upperBoundBox.Location = new System.Drawing.Point(228, 123);
            this.upperBoundBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.upperBoundBox.Name = "upperBoundBox";
            this.upperBoundBox.ShortcutsEnabled = false;
            this.upperBoundBox.Size = new System.Drawing.Size(203, 31);
            this.upperBoundBox.TabIndex = 4;
            this.upperBoundBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upperBoundBoxKeyPress);
            // 
            // arrayDataBox
            // 
            this.arrayDataBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.arrayDataBox.Location = new System.Drawing.Point(21, 35);
            this.arrayDataBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.arrayDataBox.Name = "arrayDataBox";
            this.arrayDataBox.ReadOnly = true;
            this.arrayDataBox.ShortcutsEnabled = false;
            this.arrayDataBox.Size = new System.Drawing.Size(410, 31);
            this.arrayDataBox.TabIndex = 6;
            // 
            // generateArray
            // 
            this.generateArray.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generateArray.ForeColor = System.Drawing.SystemColors.ControlText;
            this.generateArray.Location = new System.Drawing.Point(21, 91);
            this.generateArray.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.generateArray.Name = "generateArray";
            this.generateArray.Size = new System.Drawing.Size(141, 34);
            this.generateArray.TabIndex = 7;
            this.generateArray.Text = "Generate";
            this.generateArray.UseVisualStyleBackColor = false;
            this.generateArray.Click += new System.EventHandler(this.generateArrayClick);
            // 
            // cValueLabel
            // 
            this.cValueLabel.AutoSize = true;
            this.cValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cValueLabel.Location = new System.Drawing.Point(16, 37);
            this.cValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cValueLabel.Name = "cValueLabel";
            this.cValueLabel.Size = new System.Drawing.Size(88, 22);
            this.cValueLabel.TabIndex = 9;
            this.cValueLabel.Text = "C value:";
            // 
            // cValueBox
            // 
            this.cValueBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cValueBox.Location = new System.Drawing.Point(116, 34);
            this.cValueBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cValueBox.Name = "cValueBox";
            this.cValueBox.ShortcutsEnabled = false;
            this.cValueBox.Size = new System.Drawing.Size(209, 31);
            this.cValueBox.TabIndex = 8;
            this.cValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cValueBoxKeyPress);
            // 
            // func1
            // 
            this.func1.BackColor = System.Drawing.Color.Snow;
            this.func1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.func1.Location = new System.Drawing.Point(20, 79);
            this.func1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.func1.Name = "func1";
            this.func1.Size = new System.Drawing.Size(141, 34);
            this.func1.TabIndex = 10;
            this.func1.Text = "Function 1";
            this.toolTip1.SetToolTip(this.func1, "Count min, max and median elements of an array");
            this.func1.UseVisualStyleBackColor = false;
            this.func1.Click += new System.EventHandler(this.func1Click);
            // 
            // func2
            // 
            this.func2.BackColor = System.Drawing.Color.Snow;
            this.func2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.func2.Location = new System.Drawing.Point(184, 79);
            this.func2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.func2.Name = "func2";
            this.func2.Size = new System.Drawing.Size(141, 34);
            this.func2.TabIndex = 11;
            this.func2.Text = "Function 2";
            this.toolTip1.SetToolTip(this.func2, "Sort array in descending order.");
            this.func2.UseVisualStyleBackColor = false;
            this.func2.Click += new System.EventHandler(this.func2Click);
            // 
            // func3
            // 
            this.func3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.func3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.func3.Location = new System.Drawing.Point(20, 123);
            this.func3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.func3.Name = "func3";
            this.func3.Size = new System.Drawing.Size(141, 34);
            this.func3.TabIndex = 12;
            this.func3.Text = "Function 3";
            this.toolTip1.SetToolTip(this.func3, "Count sum and number of elements that are bigger than C and have odd numeration.");
            this.func3.UseVisualStyleBackColor = false;
            this.func3.Click += new System.EventHandler(this.func3Click);
            // 
            // func4
            // 
            this.func4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.func4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.func4.Location = new System.Drawing.Point(184, 123);
            this.func4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.func4.Name = "func4";
            this.func4.Size = new System.Drawing.Size(141, 34);
            this.func4.TabIndex = 13;
            this.func4.Text = "Function 4";
            this.toolTip1.SetToolTip(this.func4, "Count sum and number of array elements ai that have an even number composed from " +
        "ai element first two numbers.");
            this.func4.UseVisualStyleBackColor = false;
            this.func4.Click += new System.EventHandler(this.func4Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openButton.Location = new System.Drawing.Point(20, 35);
            this.openButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(141, 34);
            this.openButton.TabIndex = 14;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(184, 35);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(141, 34);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.element});
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(191, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 254);
            this.dataGridView1.TabIndex = 16;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // element
            // 
            this.element.HeaderText = "element";
            this.element.Name = "element";
            this.element.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // arraySettingsBox
            // 
            this.arraySettingsBox.BackColor = System.Drawing.Color.Transparent;
            this.arraySettingsBox.Controls.Add(this.upperBoundLabel);
            this.arraySettingsBox.Controls.Add(this.upperBoundBox);
            this.arraySettingsBox.Controls.Add(this.lowerBoundLabel);
            this.arraySettingsBox.Controls.Add(this.lowerBoundBox);
            this.arraySettingsBox.Controls.Add(this.numOfElemsLabel);
            this.arraySettingsBox.Controls.Add(this.numOfElemsBox);
            this.arraySettingsBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.arraySettingsBox.Location = new System.Drawing.Point(19, 12);
            this.arraySettingsBox.Name = "arraySettingsBox";
            this.arraySettingsBox.Size = new System.Drawing.Size(454, 173);
            this.arraySettingsBox.TabIndex = 17;
            this.arraySettingsBox.TabStop = false;
            this.arraySettingsBox.Text = "Array Settings";
            // 
            // dataBox
            // 
            this.dataBox.BackColor = System.Drawing.Color.Transparent;
            this.dataBox.Controls.Add(this.dataGridView1);
            this.dataBox.Controls.Add(this.generateArray);
            this.dataBox.Controls.Add(this.arrayDataBox);
            this.dataBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dataBox.Location = new System.Drawing.Point(19, 191);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(454, 353);
            this.dataBox.TabIndex = 18;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Data";
            // 
            // operationsBox
            // 
            this.operationsBox.BackColor = System.Drawing.Color.Transparent;
            this.operationsBox.Controls.Add(this.func4);
            this.operationsBox.Controls.Add(this.func3);
            this.operationsBox.Controls.Add(this.func2);
            this.operationsBox.Controls.Add(this.func1);
            this.operationsBox.Controls.Add(this.cValueLabel);
            this.operationsBox.Controls.Add(this.cValueBox);
            this.operationsBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.operationsBox.Location = new System.Drawing.Point(493, 13);
            this.operationsBox.Name = "operationsBox";
            this.operationsBox.Size = new System.Drawing.Size(348, 172);
            this.operationsBox.TabIndex = 19;
            this.operationsBox.TabStop = false;
            this.operationsBox.Text = "Operations";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            // 
            // fileDialogsBox
            // 
            this.fileDialogsBox.BackColor = System.Drawing.Color.Transparent;
            this.fileDialogsBox.Controls.Add(this.saveButton);
            this.fileDialogsBox.Controls.Add(this.openButton);
            this.fileDialogsBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fileDialogsBox.Location = new System.Drawing.Point(493, 192);
            this.fileDialogsBox.Name = "fileDialogsBox";
            this.fileDialogsBox.Size = new System.Drawing.Size(347, 94);
            this.fileDialogsBox.TabIndex = 20;
            this.fileDialogsBox.TabStop = false;
            this.fileDialogsBox.Text = "File Dialogs";
            // 
            // ArrayProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::lab3.Properties.Resources.daniel_roe;
            this.ClientSize = new System.Drawing.Size(857, 547);
            this.Controls.Add(this.fileDialogsBox);
            this.Controls.Add(this.operationsBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.arraySettingsBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ArrayProcessingForm";
            this.Text = "Array processing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.arraySettingsBox.ResumeLayout(false);
            this.arraySettingsBox.PerformLayout();
            this.dataBox.ResumeLayout(false);
            this.dataBox.PerformLayout();
            this.operationsBox.ResumeLayout(false);
            this.operationsBox.PerformLayout();
            this.fileDialogsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox numOfElemsBox;
        private System.Windows.Forms.Label numOfElemsLabel;
        private System.Windows.Forms.Label lowerBoundLabel;
        private System.Windows.Forms.TextBox lowerBoundBox;
        private System.Windows.Forms.Label upperBoundLabel;
        private System.Windows.Forms.TextBox upperBoundBox;
        private System.Windows.Forms.TextBox arrayDataBox;
        private System.Windows.Forms.Button generateArray;
        private System.Windows.Forms.Label cValueLabel;
        private System.Windows.Forms.TextBox cValueBox;
        private System.Windows.Forms.Button func1;
        private System.Windows.Forms.Button func2;
        private System.Windows.Forms.Button func3;
        private System.Windows.Forms.Button func4;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn element;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox arraySettingsBox;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.GroupBox operationsBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox fileDialogsBox;
    }
}

