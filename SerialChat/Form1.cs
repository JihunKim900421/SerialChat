using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SeirialChat
{
    public interface IMyInterface
    {
        void SetData(string Data);
    }

    public partial class Form1 : Form, IMyInterface
    {
        private string SetConf = null;
        public void SetData(string Data)
        {
            // Data format = Port/Baud rate/Data bits/Stop bit/Parity
            SetConf = Data;
            string[] result = Data.Split('/');
            
            // Set Serial Parmameters
            serialPort1.PortName = result[0];
            serialPort1.BaudRate = int.Parse(result[1]);
            serialPort1.DataBits = int.Parse(result[2]);
            switch (result[3])
            {
                case "One":
                    serialPort1.StopBits = StopBits.One;
                    break;
                case "None":
                    serialPort1.StopBits = StopBits.None;
                    break;
                case "Two":
                    serialPort1.StopBits = StopBits.Two;
                    break;
                case "OnePointFive":
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                default:
                    serialPort1.StopBits = StopBits.One;
                    break;
            }
            switch (result[4])
            {
                case "None":
                    serialPort1.Parity = Parity.None;
                    break;
                case "Odd":
                    serialPort1.Parity = Parity.Odd;
                    break;
                case "Even":
                    serialPort1.Parity = Parity.Even;
                    break;
                case "Mask":
                    serialPort1.Parity = Parity.Mark;
                    break;
                case "Space":
                    serialPort1.Parity = Parity.Space;
                    break;
                default:
                    serialPort1.Parity = Parity.None;
                    break;
            }
        }
        private void ReceiveSerial(object s, EventArgs e)
        {
            // int ReceiveData = serialPort1.ReadByte();
            string ReceiveddData = Environment.NewLine + "Received : " + serialPort1.ReadExisting();
            tb2.AppendText(ReceiveddData);
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            string SendData = Environment.NewLine + "Send : " + tb1.Text;
            try
            {
                serialPort1.Write(SendData);
                tb2.AppendText(SendData);
                tb1.Clear();
            }
            catch
            {
                tb2.Text = "Error : Can't open the Serial port. Check the connection.";
            }
        }


        private void serialPort1_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ReceiveSerial));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btConnect_Click(object sender, EventArgs e)
        {   
            if (!serialPort1.IsOpen)  
            {
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                try
                {
                    serialPort1.Open();
                    string str = serialPort1.PortName + " Port is open. " + "Buffersize : " + serialPort1.ReadBufferSize;
                    tb2.Text = str;
                }
                catch
                {
                    tb2.Text = "Error : Can't open the Serial port. Check the connection.";
                }
            }
            else
            {
                tb2.Text = "Port open failed";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }
        private void btConfig_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this as IMyInterface);
            frm.ShowDialog();
        }
    }
}
