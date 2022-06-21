using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Frequency_Counter_Capture
{
    class HP53132A : Counter
    {

        public HP53132A(int GPIB_Address_, string SICL_) : base(GPIB_Address_, SICL_)
        {
            string init_string = String.Concat(SICL_interface_id, Convert.ToString(GPIB_adr));
            InitIO(init_string);

        }


        public override void setUpCounter(frequency_counter_channel ch,frequency_counter_gate_time gate_t)
        {
            string str_channel = "";
            string str_gate = "";
            channel = ch;
            gate_time = gate_t;

            switch (channel)     
            {
                case frequency_counter_channel.CH1:
                    str_channel = ":FUNC 'FREQ 1'";
                    break;
                case frequency_counter_channel.CH2:
                    str_channel = ":FUNC 'FREQ 2'"; ;
                    break;
                case frequency_counter_channel.CH3:
                    str_channel = ":FUNC 'FREQ 3'"; ;
                    break;
                default: str_channel = ":FUNC 'FREQ 1'";
                    break;        
            }
            

            switch (gate_t)
            {
                case frequency_counter_gate_time._100ms:
                    str_gate = "FREQ:ARM:STOP:TIM 0.1";
                    break;
                case frequency_counter_gate_time._1000ms:
                    str_gate = "FREQ:ARM:STOP:TIM 1";
                    break;
                case frequency_counter_gate_time._10000ms:
                    str_gate = "FREQ:ARM:STOP:TIM 10";
                    break;
                default: str_gate = "FREQ:ARM:STOP:TIM 0.1";
                    break;  
            }

            
            sendcommand("*RST\r\n");
            sendcommand("*CLS\r\n");
            sendcommand("*SRE 0\r\n");
            sendcommand("*ESE 0\r\n");
            sendcommand(":STAT:PRES\r\n");
            sendcommand(":FORMAT ASCII\r\n");
            sendcommand(str_channel+"\r\n");
            sendcommand(":EVENT1:LEVEL 0\r\n");
            sendcommand(":FREQ:ARM:STAR:SOUR IMM\r\n");
            sendcommand(str_gate+ "\r\n");
            sendcommand(":ROSC:SOUR INT\r\n");
            sendcommand(":DIAG:CAL:INT:AUTO OFF\r\n");
            sendcommand(":CALC:MATH:STATE OFF\r\n");
            sendcommand(":CALC2:LIM:STATE OFF\r\n");
            sendcommand(":CALC3:AVER:STATE OFF\r\n");
            sendcommand(":HCOPY:CONT OFF\r\n");
            sendcommand(":DISP:ENAB OFF\r\n");
            sendcommand("*DDT #15FETC?\r\n");
            sendcommand(":INIT:CONT ON\r\n");
        }

        public override void doCapture(ref string captured_data)
        {
            sendcommand("FETC?\r\n");
            ReadResponse(ref captured_data);
        }

        public void setCounterAddress(string address)
        {
            GPIB_adr = Convert.ToInt32(address);
        }

    }
}
