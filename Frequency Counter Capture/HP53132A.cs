using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Frequency_Counter_Capture
{
    
    class HP53132A : Counter
    {
        private bool frequency_set;

        public HP53132A(int GPIB_Address_, string SICL_) : base(GPIB_Address_, SICL_)
        {
            string init_string = String.Concat(SICL_interface_id,"::", Convert.ToString(GPIB_adr));
            InitIO(init_string);
            frequency_set = false;
            

        }


        public override void setUpCounter(frequency_counter_channel ch,frequency_counter_gate_time gate_t)
        {
            string str_channel = "";
            string str_gate = "";
            string exp_freq = "";
            channel = ch;
            string c = "";
            gate_time = gate_t;

            switch (channel)     
            {
                case frequency_counter_channel.CH1:
                    str_channel = ":FUNC 'FREQ 1'";
                    c = "1";
                    break;
                case frequency_counter_channel.CH2:
                    str_channel = ":FUNC 'FREQ 2'";
                    c = "2";
                    break;
                case frequency_counter_channel.CH3:
                    str_channel = ":FUNC 'FREQ 3'";
                    c = "3";
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

            if (!frequency_set)
            {
                sendcommand("*RST");
                sendcommand("*CLS");
                sendcommand("*SRE 0");
                sendcommand("*ESE 0");
                sendcommand(":STAT:PRES");
                sendcommand(":FORMAT ASCII");
            }
            sendcommand(str_channel);
            sendcommand(":EVENT1:LEVEL 0");
            sendcommand(":FREQ:ARM:STAR:SOUR IMM");
            sendcommand(str_gate);
            sendcommand(":ROSC:SOUR INT");
            sendcommand(":DIAG:CAL:INT:AUTO OFF");
            sendcommand(":CALC:MATH:STATE OFF");
            sendcommand(":CALC2:LIM:STATE OFF");
            sendcommand(":CALC3:AVER:STATE OFF");
            sendcommand(":HCOPY:CONT OFF");
            sendcommand(":DISP:ENAB OFF");
            sendcommand("*DDT #15FETC?");
            

            if (!frequency_set)
            {
                frequency_set = true;
                sendcommand("READ:FREQUENCY?");
                string data = "";
                ReadResponse(ref data);
                sendcommand(":FREQ:EXP" + "1 " + data);
            }
            sendcommand(":INIT:CONT ON");

        }

        public override void doCapture(ref string captured_data)
        {


            //sendcommand("FETC?");
            sendcommand("FETC?");
            ReadResponse(ref captured_data);
            //string num_command = ":CALC3:AVERAGE:COUNT " + num.ToString();
            //string data = "";
            //sendcommand("*SRE 0");
            //sendcommand("*CLS"); //clear the status byte register
            //sendcommand(":CALC3:AVERAGE ON");
            //sendcommand(num_command);
            //sendcommand(":TRIG:COUNT:AUTO ON");
            //sendcommand("*ESE 1"); //enable status register summary bit (ESB) to assert when the operation complete (OPC) bit in the standard event status register is asserted 
            //sendcommand("*SRE 32"); //assert SRQ GPIB interupt when summary bit (ESB) is asserted in the status byte register

            //sendcommand(":INIT;*OPC");
            //sendcommand("*ESR?");
            //ReadResponse(ref data);





        }

        public void setCounterAddress(string address)
        {
            GPIB_adr = Convert.ToInt32(address);
        }

    }
    
}
