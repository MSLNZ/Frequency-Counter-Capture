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
        //public ICSconstants ICSconts;
        private PrintFrequencies data;
        public HP53132A hp53132a;
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
        public Measurement(ref HP53132A frequency_counter, ref PrintFrequencies print_)
        {
            data = print_;
            hp53132a = frequency_counter;
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
        public void capture(ref string cap_dat)
        {
            hp53132a.doCapture(ref cap_dat);

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

            string[] captured_data = null;
            string captured_data_ = "";
            


            

            lock (lockthis)
            {
                if (hp53132a != null)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        if (hp53132a.Channel == frequency_counter_channel.CH1)
                        {
                            hp53132a.setUpCounter(frequency_counter_channel.CH1, (frequency_counter_gate_time)i);
                        }
                        else if (hp53132a.Channel == frequency_counter_channel.CH2)
                        {
                            hp53132a.setUpCounter(frequency_counter_channel.CH2, (frequency_counter_gate_time)i);
                        }
                        else if (hp53132a.Channel == frequency_counter_channel.CH3)
                        {
                            hp53132a.setUpCounter(frequency_counter_channel.CH3, (frequency_counter_gate_time)i);
                        }
                        switch (i)
                        {

                            case (int)frequency_counter_gate_time._100ms:

                                captured_data = new string[num_100ms];
                                data("\n0.1s\n");
                                writer.WriteLine("\n0.1s\n");
                                start_time = Environment.TickCount;
                                tick_count = 0;

                                for (int k = 0; k < num_100ms; k++)
                                {
                                    capture(ref captured_data_);
                                    data(captured_data_);
                                    writer.Write(captured_data_);
                                }

                                tick_count = Environment.TickCount;
                                data("Ellapsed time: " + ((double)(tick_count - start_time) / 1000).ToString() + " s\n");
                                break;
                                
                            case (int)frequency_counter_gate_time._1000ms:

                                data("\n1s\n");
                                writer.WriteLine("\n1s\n");
                                captured_data = new string[num_1000ms];

                                start_time = Environment.TickCount;
                                tick_count = 0;

                                for (int k = 0; k < num_1000ms; k++)
                                {
                                    capture(ref captured_data_);
                                    data(captured_data_);
                                    writer.Write(captured_data_);
                                }

                                tick_count = Environment.TickCount;
                                data("Ellapsed time: " + ((double)(tick_count - start_time) / 1000).ToString() + " s\n");

                                break;
                            case (int)frequency_counter_gate_time._10000ms:

                                data("\n10s\n");
                                writer.WriteLine("\n10s\n");
                                captured_data = new string[num_10000ms];

                                start_time = Environment.TickCount;
                                tick_count = 0;
                                for (int k = 0; k < num_10000ms; k++)
                                {
                                    capture(ref captured_data_);
                                    data(captured_data_);
                                    writer.Write(captured_data_);
                                }
                                
                                tick_count = Environment.TickCount;
                                data("Ellapsed time: " + ((double)(tick_count - start_time) / 1000).ToString() + " s\n");
                                break;
                        }
                    }
                }
            }
            data("END");
            writer.WriteLine("END");
            writer.Close();
            writer.Dispose();
        }
    }
}
