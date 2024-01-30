namespace Frequency_Counter_Capture
{
    partial class MainForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cancel_Measurement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonSendCmd = new System.Windows.Forms.Button();
            this.Keysight53210A_GB = new System.Windows.Forms.GroupBox();
            this.Keysight53210A_CH2 = new System.Windows.Forms.RadioButton();
            this.Keysight53210A_CH3 = new System.Windows.Forms.RadioButton();
            this.Keysight53210A_CH1 = new System.Windows.Forms.RadioButton();
            this.data_window = new System.Windows.Forms.RichTextBox();
            this.Frequency_Counter_GB = new System.Windows.Forms.GroupBox();
            this.Data_File_Writer = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Keysight53210A_GB.SuspendLayout();
            this.Frequency_Counter_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cancel_Measurement);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.buttonSendCmd);
            this.groupBox3.Location = new System.Drawing.Point(45, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurements to take:";
            // 
            // Cancel_Measurement
            // 
            this.Cancel_Measurement.Location = new System.Drawing.Point(344, 107);
            this.Cancel_Measurement.Name = "Cancel_Measurement";
            this.Cancel_Measurement.Size = new System.Drawing.Size(62, 38);
            this.Cancel_Measurement.TabIndex = 9;
            this.Cancel_Measurement.Text = "Cancel";
            this.Cancel_Measurement.UseVisualStyleBackColor = true;
            this.Cancel_Measurement.Click += new System.EventHandler(this.Cancel_Measurement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num Samples @ 0.1 s Gate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonSendCmd
            // 
            this.buttonSendCmd.Location = new System.Drawing.Point(344, 29);
            this.buttonSendCmd.Name = "buttonSendCmd";
            this.buttonSendCmd.Size = new System.Drawing.Size(62, 38);
            this.buttonSendCmd.TabIndex = 2;
            this.buttonSendCmd.Text = "Measure";
            this.buttonSendCmd.UseVisualStyleBackColor = true;
            this.buttonSendCmd.Click += new System.EventHandler(this.buttonSendCmd_Click);
            // 
            // Keysight53210A_GB
            // 
            this.Keysight53210A_GB.Controls.Add(this.Keysight53210A_CH2);
            this.Keysight53210A_GB.Controls.Add(this.Keysight53210A_CH3);
            this.Keysight53210A_GB.Controls.Add(this.Keysight53210A_CH1);
            this.Keysight53210A_GB.Location = new System.Drawing.Point(12, 19);
            this.Keysight53210A_GB.Name = "Keysight53210A_GB";
            this.Keysight53210A_GB.Size = new System.Drawing.Size(394, 47);
            this.Keysight53210A_GB.TabIndex = 11;
            this.Keysight53210A_GB.TabStop = false;
            this.Keysight53210A_GB.Text = "Keysight53210A";
            // 
            // Keysight53210A_CH2
            // 
            this.Keysight53210A_CH2.AutoSize = true;
            this.Keysight53210A_CH2.Location = new System.Drawing.Point(79, 19);
            this.Keysight53210A_CH2.Name = "Keysight53210A_CH2";
            this.Keysight53210A_CH2.Size = new System.Drawing.Size(46, 17);
            this.Keysight53210A_CH2.TabIndex = 2;
            this.Keysight53210A_CH2.Text = "CH2";
            this.Keysight53210A_CH2.UseVisualStyleBackColor = true;
            this.Keysight53210A_CH2.CheckedChanged += new System.EventHandler(this.Keysight53210A_CH2_CheckedChanged);
            // 
            // Keysight53210A_CH3
            // 
            this.Keysight53210A_CH3.AutoSize = true;
            this.Keysight53210A_CH3.Location = new System.Drawing.Point(140, 19);
            this.Keysight53210A_CH3.Name = "Keysight53210A_CH3";
            this.Keysight53210A_CH3.Size = new System.Drawing.Size(46, 17);
            this.Keysight53210A_CH3.TabIndex = 1;
            this.Keysight53210A_CH3.Text = "CH3";
            this.Keysight53210A_CH3.UseVisualStyleBackColor = true;
            this.Keysight53210A_CH3.CheckedChanged += new System.EventHandler(this.Keysight53210A_CH3_CheckedChanged);
            // 
            // Keysight53210A_CH1
            // 
            this.Keysight53210A_CH1.AutoSize = true;
            this.Keysight53210A_CH1.Checked = true;
            this.Keysight53210A_CH1.Location = new System.Drawing.Point(17, 19);
            this.Keysight53210A_CH1.Name = "Keysight53210A_CH1";
            this.Keysight53210A_CH1.Size = new System.Drawing.Size(46, 17);
            this.Keysight53210A_CH1.TabIndex = 0;
            this.Keysight53210A_CH1.TabStop = true;
            this.Keysight53210A_CH1.Text = "CH1";
            this.Keysight53210A_CH1.UseVisualStyleBackColor = true;
            this.Keysight53210A_CH1.CheckedChanged += new System.EventHandler(this.Keysight53210A_CH1_CheckedChanged);
            // 
            // data_window
            // 
            this.data_window.Location = new System.Drawing.Point(45, 264);
            this.data_window.Name = "data_window";
            this.data_window.Size = new System.Drawing.Size(459, 285);
            this.data_window.TabIndex = 13;
            this.data_window.Text = "Data Window";
            // 
            // Frequency_Counter_GB
            // 
            this.Frequency_Counter_GB.Controls.Add(this.Keysight53210A_GB);
            this.Frequency_Counter_GB.Location = new System.Drawing.Point(45, 12);
            this.Frequency_Counter_GB.Name = "Frequency_Counter_GB";
            this.Frequency_Counter_GB.Size = new System.Drawing.Size(435, 81);
            this.Frequency_Counter_GB.TabIndex = 14;
            this.Frequency_Counter_GB.TabStop = false;
            this.Frequency_Counter_GB.Text = "Frequency Counter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 576);
            this.Controls.Add(this.data_window);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Frequency_Counter_GB);
            this.Name = "MainForm";
            this.Text = "Frequency Counter Capture";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Keysight53210A_GB.ResumeLayout(false);
            this.Keysight53210A_GB.PerformLayout();
            this.Frequency_Counter_GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSendCmd;
        private System.Windows.Forms.GroupBox Keysight53210A_GB;
        private System.Windows.Forms.RadioButton Keysight53210A_CH1;
        private System.Windows.Forms.RadioButton Keysight53210A_CH2;
        private System.Windows.Forms.RadioButton Keysight53210A_CH3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Cancel_Measurement;
        private System.Windows.Forms.RichTextBox data_window;
        private System.Windows.Forms.GroupBox Frequency_Counter_GB;
        private System.Windows.Forms.SaveFileDialog Data_File_Writer;
    }
}

