using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Frequency_Counter_Capture
{
    class Measurement
    {
       
        private PrintFrequencies data;
        public Keysight53210A keysight_53210a;
        private long num_100ms = 10000;
        private long num_1000ms = 1000;
        private long num_10000ms = 100;
        private int exp_freq = 30;
        private StreamWriter writer = null;
        private static Object lockthis = new Object();
        private bool running_state = false;
        bool skip = false;

        System.Text.ASCIIEncoding encoding;

        /// <summary>
        /// Create a new measurement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public Measurement(ref Keysight53210A frequency_counter, ref PrintFrequencies print_)
        {
            data = print_;
            keysight_53210a = frequency_counter;
            encoding = new ASCIIEncoding();

        }


        //Measurements have a frequency counter type

        //Measurements have a channel type 1,2 or 3

        //Measurements have a gate time.
        public long num100
        {
            get
            {
                return num_100ms;
            }
            set
            {
                num_100ms = value;
            }

        }

        public long num1000
        {
            get
            {
                return num_1000ms;
            }
            set
            {
                num_1000ms = value;
            }

        }

        public long num10000
        {
            get
            {
                return num_10000ms;
            }
            set
            {
                num_10000ms = value;
            }

        }

        public int ExpectedFrequency
        {
            get { return exp_freq; }
            set { exp_freq = value; }
        }

        public bool isrunning
        {
            get
            {
                return running_state;
            }
            set
            {
                running_state = value;
            }
                
        }
        public void capture(ref double[] cap_dat,long sample_count, ref long start_t, ref long end_t)
        {
            keysight_53210a.doCapture(ref cap_dat, sample_count, ref start_t, ref end_t);

        }
        public void FileHandle(ref StreamWriter w)
        {
            writer = w;
        }

        //This is the main measurement loop
        public void runMeasurement()
        {
            long tick_count = 0;
            long start_time = 0;

            //string[] captured_data = null;
            double[] captured_data_ = null;
            StringBuilder printstring = new StringBuilder();
            string sendstr = "";





            lock (lockthis)
            {
                if (keysight_53210a != null)
                {

                    
                        if (keysight_53210a.Channel == frequency_counter_channel.CH1)
                        {
                            keysight_53210a.setUpCounter(frequency_counter_channel.CH1, (frequency_counter_gate_time)0);
                        }
                        else if (keysight_53210a.Channel == frequency_counter_channel.CH2)
                        {
                            keysight_53210a.setUpCounter(frequency_counter_channel.CH2, (frequency_counter_gate_time)1);
                        }
                        else if (keysight_53210a.Channel == frequency_counter_channel.CH3)
                        {
                            keysight_53210a.setUpCounter(frequency_counter_channel.CH3, (frequency_counter_gate_time)2);
                        }
                    writer.WriteLine("\n0.1s gate\n");
                    string writestring = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    writer.WriteLine(writestring);
                    capture(ref captured_data_, num_100ms, ref start_time, ref tick_count);
                    writestring = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    writer.WriteLine(writestring);

                    double ell_t = (double)(tick_count - start_time);
                    
                    data("\n0.1s\n");
                    

                    foreach(double s in captured_data_)
                    {
                        writer.WriteLine(s.ToString());
                    }
    
                    foreach (double s in captured_data_)
                    {
                        printstring.AppendLine(s.ToString());
                    }
                    sendstr = printstring.ToString();
                    printstring = null;
                        

                    data(sendstr);       
                    data("Ellapsed time: " + (ell_t / 1000).ToString() + " s\n");
                    writer.WriteLine("Ellapsed time: " + (ell_t / 1000).ToString() + " s\n");            

                }
            }
            data("END");
            writer.WriteLine("END");
            writer.Close();
            writer.Dispose();
        }
    }
}
