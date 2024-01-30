using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frequency_Counter_Capture
{
    public abstract class Counter
    {
      
        protected frequency_counter_gate_time gate_time = frequency_counter_gate_time._100ms; 
        protected double latest_count=0.0;
        protected frequency_counter_channel channel = frequency_counter_channel.CH1;
        protected frequency_counter_type counter_type = frequency_counter_type.Keysight_53210A;
        protected short Bd;            //GPIB controller ID
        protected short Device;        //Device ID
        protected string channelasdigit = "1";
        protected string gatecommand = "";
        private System.Text.ASCIIEncoding encoding = new ASCIIEncoding();
        private byte[] byteArray;
        

        public Counter()
        {
            
        }

        public frequency_counter_channel Channel
        {
            set { channel = value;}
            get { return channel;}
        }
        public string CounterCH
        {
            set { channelasdigit = value;}
            get { return channelasdigit; }
        }
        public string GateCommand
        {
            set { gatecommand = value;}
            get { return gatecommand;}
        }


        public abstract void setUpCounter(frequency_counter_channel ch, frequency_counter_gate_time t);       
       
        public abstract void doCapture(ref double[] captured_data, long sample_count, ref long start_t, ref long end_t);

    }
}
