using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            listport.Items.AddRange(ports); 
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = listport.SelectedItem.ToString();
            serialPort1.Open(); 
        }

        private void btnsend_Click(object sender, EventArgs e)
        {

            serialPort1.WriteLine(txtMSG.Text);
            MessageBox.Show(serialPort1.ReadLine());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
