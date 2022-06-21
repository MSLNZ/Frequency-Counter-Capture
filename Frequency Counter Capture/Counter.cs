using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frequency_Counter_Capture
{
    abstract class Counter : GPIBOverLANCommands
    {
      
        protected frequency_counter_gate_time gate_time = frequency_counter_gate_time._100ms; 
        protected double latest_count=0.0;
        protected frequency_counter_channel channel = frequency_counter_channel.CH1;
        protected frequency_counter_type counter_type = frequency_counter_type.HP_53132A;
        protected short Bd;            //GPIB controller ID
        protected short Device;        //Device ID
        private System.Text.ASCIIEncoding encoding = new ASCIIEncoding();
        private byte[] byteArray;

        public Counter(int GPIB_Address_, string SICL_)
        {
            GPIB_adr = GPIB_Address_;
            SICL_interface_id = SICL_;
            
        }

        public frequency_counter_channel Channel
        {
            set { channel = value;}
            get { return channel;}
        }


        public abstract void setUpCounter(frequency_counter_channel ch, frequency_counter_gate_time t);       
       
        public abstract void doCapture(ref string captured_data);

    }
}
