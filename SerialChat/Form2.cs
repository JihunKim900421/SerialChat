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

    public partial class Form2 : Form
    {
                
        private IMyInterface frm = null;
        public Form2(IMyInterface frm)
        {
            InitializeComponent();
            cbSbit.DataSource = Enum.GetValues(typeof(StopBits));
            cbSbit.SelectedIndex = 1;
            cbP.DataSource = Enum.GetValues(typeof(Parity));
            cbP.SelectedIndex = 0;
            cbBaud.SelectedIndex = 3;
            this.frm = frm;
            cbPort.DataSource = SerialPort.GetPortNames();
        }

        private void btCl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            int i = SerialPort.GetPortNames().Length;
            if(i != 0)
            {
                string str = cbPort.Text + "/" + cbBaud.Text +
            "/" + tbDbit.Text + "/" + cbSbit.Text + "/" + cbP.Text;
                frm.SetData(str);
                this.Close();
            }
            else          
            {
                MessageBox.Show("Plz Check the serial connection.");
            }
        }
    }
}
