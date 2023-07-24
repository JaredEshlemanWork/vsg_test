
namespace vsg_test
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
            this.BeginButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SubmitTimeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.browsePythonButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timeDisplayNumberBox = new System.Windows.Forms.NumericUpDown();
            this.SaveConfigurationButton = new System.Windows.Forms.Button();
            this.LoadConfigurationButton = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplayNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(203, 345);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(140, 93);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "Begin";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(203, 18);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(140, 53);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Add File";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SubmitTimeButton
            // 
            this.SubmitTimeButton.Location = new System.Drawing.Point(80, 234);
            this.SubmitTimeButton.Name = "SubmitTimeButton";
            this.SubmitTimeButton.Size = new System.Drawing.Size(117, 65);
            this.SubmitTimeButton.TabIndex = 7;
            this.SubmitTimeButton.Text = "Submit File -->";
            this.SubmitTimeButton.UseVisualStyleBackColor = true;
            this.SubmitTimeButton.Click += new System.EventHandler(this.SubmitTimeButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(203, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 116);
            this.listBox1.TabIndex = 8;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // browsePythonButton
            // 
            this.browsePythonButton.Location = new System.Drawing.Point(349, 400);
            this.browsePythonButton.Name = "browsePythonButton";
            this.browsePythonButton.Size = new System.Drawing.Size(140, 38);
            this.browsePythonButton.TabIndex = 10;
            this.browsePythonButton.Text = "Browse Python";
            this.browsePythonButton.UseVisualStyleBackColor = true;
            this.browsePythonButton.Click += new System.EventHandler(this.browsePythonButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(349, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 116);
            this.listBox2.TabIndex = 11;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox2_DragOver);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeDisplayNumberBox
            // 
            this.timeDisplayNumberBox.Location = new System.Drawing.Point(495, 77);
            this.timeDisplayNumberBox.Name = "timeDisplayNumberBox";
            this.timeDisplayNumberBox.Size = new System.Drawing.Size(120, 22);
            this.timeDisplayNumberBox.TabIndex = 14;
            // 
            // SaveConfigurationButton
            // 
            this.SaveConfigurationButton.Location = new System.Drawing.Point(12, 376);
            this.SaveConfigurationButton.Name = "SaveConfigurationButton";
            this.SaveConfigurationButton.Size = new System.Drawing.Size(10, 28);
            this.SaveConfigurationButton.TabIndex = 17;
            this.SaveConfigurationButton.Text = "Save Configuration";
            this.SaveConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // LoadConfigurationButton
            // 
            this.LoadConfigurationButton.Location = new System.Drawing.Point(12, 410);
            this.LoadConfigurationButton.Name = "LoadConfigurationButton";
            this.LoadConfigurationButton.Size = new System.Drawing.Size(10, 28);
            this.LoadConfigurationButton.TabIndex = 18;
            this.LoadConfigurationButton.Text = "Load Configuration";
            this.LoadConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(203, 198);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(286, 132);
            this.listBox3.TabIndex = 19;
            this.listBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox3_DragDrop);
            this.listBox3.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox3_DragOver);
            this.listBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add Delay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(498, 308);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 22);
            this.numericUpDown1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "<-- Remove Selected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 45);
            this.button4.TabIndex = 23;
            this.button4.Text = "<-- Remove Selected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(77, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 64);
            this.button5.TabIndex = 24;
            this.button5.Text = "Remove Selected -->";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.LoadConfigurationButton);
            this.Controls.Add(this.SaveConfigurationButton);
            this.Controls.Add(this.timeDisplayNumberBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.browsePythonButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SubmitTimeButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.BeginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplayNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SubmitTimeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button browsePythonButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown timeDisplayNumberBox;
        private System.Windows.Forms.Button SaveConfigurationButton;
        private System.Windows.Forms.Button LoadConfigurationButton;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

