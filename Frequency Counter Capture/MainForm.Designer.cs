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
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cancel_Measurement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonSendCmd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataFileWriter = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.HP53132_address_set = new System.Windows.Forms.Button();
            this.HP53132A_GB = new System.Windows.Forms.GroupBox();
            this.HP53132_address_label = new System.Windows.Forms.Label();
            this.HP53132_address_box = new System.Windows.Forms.TextBox();
            this.HP53132A_CH2 = new System.Windows.Forms.RadioButton();
            this.HP53132A_CH3 = new System.Windows.Forms.RadioButton();
            this.HP53132A_CH1 = new System.Windows.Forms.RadioButton();
            this.data_window = new System.Windows.Forms.RichTextBox();
            this.Frequency_Counter_GB = new System.Windows.Forms.GroupBox();
            this.Data_File_Writer = new System.Windows.Forms.SaveFileDialog();
            //this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.HP53132A_GB.SuspendLayout();
            this.Frequency_Counter_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxError
            // 
            this.textBoxError.Enabled = false;
            this.textBoxError.Location = new System.Drawing.Point(45, 12);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(459, 20);
            this.textBoxError.TabIndex = 0;
            this.textBoxError.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cancel_Measurement);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.buttonSendCmd);
            this.groupBox3.Location = new System.Drawing.Point(45, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 164);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number at 10s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number at 1s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number at 0.1s";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(105, 120);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(105, 77);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataFileWriter);
            this.groupBox4.Location = new System.Drawing.Point(45, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 50);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Captured data";
            // 
            // DataFileWriter
            // 
            this.DataFileWriter.AutoSize = true;
            this.DataFileWriter.Location = new System.Drawing.Point(19, 19);
            this.DataFileWriter.Name = "DataFileWriter";
            this.DataFileWriter.Size = new System.Drawing.Size(80, 17);
            this.DataFileWriter.TabIndex = 0;
            this.DataFileWriter.Text = "WriteToFile";
            this.DataFileWriter.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(48, 448);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // HP53132_address_set
            // 
            this.HP53132_address_set.Location = new System.Drawing.Point(17, 64);
            this.HP53132_address_set.Name = "HP53132_address_set";
            this.HP53132_address_set.Size = new System.Drawing.Size(47, 23);
            this.HP53132_address_set.TabIndex = 6;
            this.HP53132_address_set.Text = "Set";
            this.HP53132_address_set.UseVisualStyleBackColor = true;
            this.HP53132_address_set.Click += new System.EventHandler(this.HP53132_address_set_Click);
            // 
            // HP53132A_GB
            // 
            this.HP53132A_GB.Controls.Add(this.HP53132_address_label);
            this.HP53132A_GB.Controls.Add(this.HP53132_address_set);
            this.HP53132A_GB.Controls.Add(this.HP53132_address_box);
            this.HP53132A_GB.Controls.Add(this.HP53132A_CH2);
            this.HP53132A_GB.Controls.Add(this.HP53132A_CH3);
            this.HP53132A_GB.Controls.Add(this.HP53132A_CH1);
            this.HP53132A_GB.Location = new System.Drawing.Point(12, 19);
            this.HP53132A_GB.Name = "HP53132A_GB";
            this.HP53132A_GB.Size = new System.Drawing.Size(140, 116);
            this.HP53132A_GB.TabIndex = 11;
            this.HP53132A_GB.TabStop = false;
            this.HP53132A_GB.Text = "HP53132A";
            // 
            // HP53132_address_label
            // 
            this.HP53132_address_label.AutoSize = true;
            this.HP53132_address_label.Location = new System.Drawing.Point(76, 51);
            this.HP53132_address_label.Name = "HP53132_address_label";
            this.HP53132_address_label.Size = new System.Drawing.Size(45, 13);
            this.HP53132_address_label.TabIndex = 7;
            this.HP53132_address_label.Text = "Address";
            // 
            // HP53132_address_box
            // 
            this.HP53132_address_box.Location = new System.Drawing.Point(79, 67);
            this.HP53132_address_box.Name = "HP53132_address_box";
            this.HP53132_address_box.Size = new System.Drawing.Size(46, 20);
            this.HP53132_address_box.TabIndex = 5;
            this.HP53132_address_box.Text = "3";
            // 
            // HP53132A_CH2
            // 
            this.HP53132A_CH2.AutoSize = true;
            this.HP53132A_CH2.Location = new System.Drawing.Point(79, 19);
            this.HP53132A_CH2.Name = "HP53132A_CH2";
            this.HP53132A_CH2.Size = new System.Drawing.Size(46, 17);
            this.HP53132A_CH2.TabIndex = 2;
            this.HP53132A_CH2.Text = "CH2";
            this.HP53132A_CH2.UseVisualStyleBackColor = true;
            this.HP53132A_CH2.CheckedChanged += new System.EventHandler(this.HP53132A_CH2_CheckedChanged);
            // 
            // HP53132A_CH3
            // 
            this.HP53132A_CH3.AutoSize = true;
            this.HP53132A_CH3.Location = new System.Drawing.Point(17, 42);
            this.HP53132A_CH3.Name = "HP53132A_CH3";
            this.HP53132A_CH3.Size = new System.Drawing.Size(46, 17);
            this.HP53132A_CH3.TabIndex = 1;
            this.HP53132A_CH3.Text = "CH3";
            this.HP53132A_CH3.UseVisualStyleBackColor = true;
            this.HP53132A_CH3.CheckedChanged += new System.EventHandler(this.HP53132A_CH3_CheckedChanged);
            // 
            // HP53132A_CH1
            // 
            this.HP53132A_CH1.AutoSize = true;
            this.HP53132A_CH1.Checked = true;
            this.HP53132A_CH1.Location = new System.Drawing.Point(17, 19);
            this.HP53132A_CH1.Name = "HP53132A_CH1";
            this.HP53132A_CH1.Size = new System.Drawing.Size(46, 17);
            this.HP53132A_CH1.TabIndex = 0;
            this.HP53132A_CH1.TabStop = true;
            this.HP53132A_CH1.Text = "CH1";
            this.HP53132A_CH1.UseVisualStyleBackColor = true;
            this.HP53132A_CH1.CheckedChanged += new System.EventHandler(this.HP53132A_CH1_CheckedChanged);
            // 
            // data_window
            // 
            this.data_window.Location = new System.Drawing.Point(172, 370);
            this.data_window.Name = "data_window";
            this.data_window.Size = new System.Drawing.Size(332, 179);
            this.data_window.TabIndex = 13;
            this.data_window.Text = "Data Window";
            // 
            // Frequency_Counter_GB
            // 
            this.Frequency_Counter_GB.Controls.Add(this.HP53132A_GB);
            this.Frequency_Counter_GB.Location = new System.Drawing.Point(45, 39);
            this.Frequency_Counter_GB.Name = "Frequency_Counter_GB";
            this.Frequency_Counter_GB.Size = new System.Drawing.Size(169, 142);
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
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.Frequency_Counter_GB);
            this.Name = "MainForm";
            this.Text = "Frequency Counter Capture";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.HP53132A_GB.ResumeLayout(false);
            this.HP53132A_GB.PerformLayout();
            this.Frequency_Counter_GB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSendCmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox HP53132A_GB;
        private System.Windows.Forms.RadioButton HP53132A_CH1;
        private System.Windows.Forms.RadioButton HP53132A_CH2;
        private System.Windows.Forms.RadioButton HP53132A_CH3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Cancel_Measurement;
        private System.Windows.Forms.CheckBox DataFileWriter;
        private System.Windows.Forms.RichTextBox data_window;
        private System.Windows.Forms.TextBox HP53132_address_box;
        private System.Windows.Forms.Button HP53132_address_set;
        private System.Windows.Forms.GroupBox Frequency_Counter_GB;
        private System.Windows.Forms.Label HP53132_address_label;
        private System.Windows.Forms.SaveFileDialog Data_File_Writer;
    }
}

