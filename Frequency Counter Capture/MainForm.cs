using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Ivi.Visa.Interop;
//*****************************************************************************
// Written By: Chris Young 21 June 2022
// Counter software to aquire data from HP frequency counters 53132A
// To add another counter extend the counter base class and implement the abstract methods
// 
// Revision 1: HP53132A.
//*****************************************************************************

namespace Frequency_Counter_Capture
{
    public enum frequency_counter_type { HP_53132A };
    public enum frequency_counter_channel { CH1, CH2, CH3 };
    public enum frequency_counter_gate_time { _100ms, _1000ms, _10000ms };
    public delegate void PrintFrequencies(string str);


    public partial class MainForm : Form
    {
        private long num_100ms;
        private long num_1000ms;
        private long num_10000ms;
        PrintFrequencies printer;

        public short Bd;            //GPIB controller ID
        public short bddev;
        public short CtlAddress;    //GPIB Controller Address
        public short Device;        //Device ID
        public short ErrorCount;    //Error counter
        public short vtmo;          //Current Timeout Setting
        public short FoundDevice;   //Address of the First Found Device
        public short FoundFlag;     //flat indicates a device was found
        public int FoundNum;        //number of devices found
        public byte[] byteArray;
        public short[] DevliceList;  //List of found devices passed to All SerialPoll
        public string SPACE80S;
        public string NL;           //CR LF string
        public string result;
        const int winPictureBox = 2016002;
        const int winCommandButton = 2007557;
 

        private HP53132A hp53132a;

        Measurement go_go;

        //The measurement thread
        Thread measurement_thread;


        public MainForm()
        {
            InitializeComponent();
            InitializeSettings();

            //set up raw counter objects
            hp53132a = new HP53132A(12, "GPIB4");

            //give the counter some defaults
            hp53132a.setUpCounter(frequency_counter_channel.CH1, frequency_counter_gate_time._100ms);
        }
        /// <summary>
        /// Initializes settings upon startup
        /// </summary>
        private void InitializeSettings()
        {
            short v;
            string Rev;
            Rev = "\n\nRevised 21-06-2022\n";
            data_window.AppendText(Rev);

            textBoxError.Text = "";
            buttonSendCmd.Enabled = false;
            HP53132A_GB.Enabled = true;
            Cancel_Measurement.Enabled = false;
            Frequency_Counter_GB.Enabled = true;
            textBoxError.Visible = true;
           
            printer = new PrintFrequencies(showFrequencies);  //invokes the gui to print data to the rich text box
        }

        /// <summary>
        /// Starts the measurement loop running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendCmd_Click(object sender, EventArgs e)
        {

            num_100ms = (long)numericUpDown1.Value;
            num_1000ms = (long)numericUpDown2.Value;
            num_10000ms = (long)numericUpDown3.Value;

            StreamWriter writer = null;
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "DefaultOutputName.txt";
            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK) writer = new StreamWriter(save.OpenFile());

            go_go.FileHandle(ref writer);

            //clear the data window. 
            data_window.Clear();
            measurement_thread = new Thread(new ThreadStart(go_go.runMeasurement));
            measurement_thread.Start();
            buttonSendCmd.Enabled = false;
        }

        private void HP53132_address_set_Click(object sender, EventArgs e)
        {

            hp53132a.setCounterAddress(HP53132_address_box.Text);

            //create a measurement and its measurement thread
            go_go = new Measurement(ref hp53132a, ref printer);

            //give the current values back to the measurement.
            go_go.num100 = (long)numericUpDown1.Value;
            go_go.num1000 = (long)numericUpDown2.Value;
            go_go.num10000 = (long)numericUpDown3.Value;

            buttonSendCmd.Enabled = true;
            Cancel_Measurement.Enabled = true;


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (go_go != null)
            {
                go_go.num100 = ((long)numericUpDown1.Value);
            }


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (go_go != null)
            {
                go_go.num1000 = ((long)numericUpDown2.Value);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (go_go != null)
            {
                go_go.num10000 = ((long)numericUpDown3.Value);
            }
        }

        private void showFrequencies(string frequency)
        {
            if (this.InvokeRequired == false)
            { 
                if (frequency.Equals("END"))
                {
                    //the thread has finished its execution terminate it and save what we have
                    //abort the thread that was used to run the measurent
                    measurement_thread.Abort();
                    buttonSendCmd.Enabled = true;
                   
                   
                }
                else
                {
                    data_window.AppendText(frequency);
                    data_window.ScrollToCaret();
                }
            }
            else
            {
                object[] textobj = { frequency };
                this.BeginInvoke(new PrintFrequencies(showFrequencies), textobj);
            }
        }

        private void HP53132A_CH1_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void HP53132A_CH3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void HP53132A_CH2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Measurement_Click(object sender, EventArgs e)
        {
            //set the number of sample to zero for all measurement.  This will force the measurement loop to an end
            go_go.num100 = 0;
            go_go.num1000 = 0;
            go_go.num10000 = 0;

            //Wait here until the measurement thread finishes nicely, should be a few ms so won't clog the gui
            while (measurement_thread.ThreadState == ThreadState.Running) ;

            //Terminate the measurement thread.
            measurement_thread.Abort();

            //give the current values back to the measurement.
            go_go.num100 = (long)numericUpDown1.Value;
            go_go.num1000 = (long)numericUpDown2.Value;
            go_go.num10000 = (long)numericUpDown3.Value;
            buttonSendCmd.Enabled = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //need proper shutdown (this is not right)
            System.Environment.Exit(1);
        }

        private void expectedFrequency_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}