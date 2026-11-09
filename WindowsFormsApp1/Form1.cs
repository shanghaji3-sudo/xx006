using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NModbus;
using NModbus.Serial;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private IModbusMaster master;
        private Timer timer;
        private bool isconnect = false;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            btnTDisConnect.Enabled = false;


            string[] port = SerialPort.GetPortNames();
            cmbPort.Items.Clear();
            cmbPort.Items.AddRange(port);
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
            cmbBaudrate.Items.AddRange(new object[]
            {
                "9600", "19200", "38400", "57600", "115200"
            });
            cmbBaudrate.SelectedIndex = 0;
            cmbDatabits.Items.AddRange(new object[]
            {
                "7", "8"
            });
            cmbDatabits.SelectedIndex = 1;
            cmbParity.Items.AddRange(new object[]
            {
                 "None", "Odd", "Even"
            });
            cmbParity.SelectedIndex = 0;
            cmbStopbits.Items.AddRange(new object[]
            {
                  "One", "Two"
            });
            cmbStopbits.SelectedIndex = 0;

            btnRConnnect.Enabled = true;
            btnRDisconnect.Enabled = false;
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (isconnect == false)
            {
                return;
            }
            try
            {
                ushort[] registers;
                registers = await Task.Run(() =>
                {
                    return master.ReadHoldingRegisters(1, 0, 8);
                });

                lbt1.Text = (registers[0] / 10.0).ToString("0.0");
                lbt2.Text = (registers[1] / 10.0).ToString("0.0");
                lbt3.Text = (registers[2] / 10.0).ToString("0.0");
                lbt4.Text = (registers[3] / 10.0).ToString("0.0");
                lbt5.Text = (registers[4] / 10.0).ToString("0.0");
                lbt6.Text = (registers[5] / 10.0).ToString("0.0");
                lbt7.Text = (registers[6] / 10.0).ToString("0.0");
                lbt8.Text = (registers[7] / 10.0).ToString("0.0");
            }
            catch (Exception ex)
            {
                timer.Stop();
                isconnect = false;
                txtlog.AppendText("对方已断开连接" + ex.Message + "\r\n");

                btnTConnect.Enabled = true;
                btnTDisConnect.Enabled = false;
            }
        }

        private async void BtnTConnnetc_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIp.Text;
                int port = int.Parse(txtPort.Text);

                tcpClient = new TcpClient();
                tcpClient.Connect(ip, port);

                ModbusFactory modbusFactory = new ModbusFactory();
                master = modbusFactory.CreateMaster(tcpClient);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;

                ushort[] registers = await Task.Run(() =>
                {
                    return master.ReadHoldingRegisters(1, 0, 8);
                });

                lbt1.Text = (registers[0] / 10.0).ToString("0.0");
                lbt2.Text = (registers[1] / 10.0).ToString("0.0");
                lbt3.Text = (registers[2] / 10.0).ToString("0.0");
                lbt4.Text = (registers[3] / 10.0).ToString("0.0");
                lbt5.Text = (registers[4] / 10.0).ToString("0.0");
                lbt6.Text = (registers[5] / 10.0).ToString("0.0");
                lbt7.Text = (registers[6] / 10.0).ToString("0.0");
                lbt8.Text = (registers[7] / 10.0).ToString("0.0");

                timer.Start();
                txtlog.AppendText("连接成功" + "\r\n");

                isconnect = true;
                btnTConnect.Enabled = false;
                btnTDisConnect.Enabled = true;
            }
            catch (Exception ex)
            {

                timer.Stop();
                txtlog.AppendText(ex.Message + "\r\n");
                if (master!=null)
                {
                    master.Dispose();
                }
                if (tcpClient != null)
                { 
                   tcpClient.Close();
                }
                isconnect = false;
                btnTConnect.Enabled = true;
               
            }

        }

        private void BtnTDisConnnect_Click(object sender, EventArgs e)
        {
            if (isconnect == false)
            {
                return;
            }
            txtlog.AppendText("正在断开连接..." + "\r\n");
            try
            {
                timer.Stop();
                if (master != null)
                {
                    master.Dispose();
                }
                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
                isconnect= false;
                btnTConnect.Enabled = true;
                btnTDisConnect.Enabled = false;
                txtlog.AppendText("已断开连接" + "\r\n");
            }
            catch (Exception ex)
            {
                txtlog.AppendText(ex.Message);
            }
        }


        SerialPort serial;
        private IModbusMaster master1;
        Timer timer1;
        bool isconnect1 = false;

        private async void btnRConnnect_Click(object sender, EventArgs e)
        {
            try
            {
                serial = new SerialPort();
                serial.PortName = cmbPort.Text;
                serial.BaudRate = int.Parse(cmbBaudrate.Text);
                serial.DataBits = int.Parse(cmbDatabits.Text);
                serial.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                serial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopbits.Text);
                btnRConnnect.Enabled = false;

                serial.Open();

                var factory = new ModbusFactory();
                master1 = factory.CreateRtuMaster(serial);
                master1.Transport.ReadTimeout = 1000;
                master1.Transport.WriteTimeout = 1000;

                ushort[] registers = await Task.Run(() =>
                {
                    return master1.ReadHoldingRegisters(1, 0, 8);
                });

                lbr1.Text = (registers[0] / 10.0).ToString("0.0");
                lbr2.Text = (registers[1] / 10.0).ToString("0.0");
                lbr3.Text = (registers[2] / 10.0).ToString("0.0");
                lbr4.Text = (registers[3] / 10.0).ToString("0.0");
                lbr5.Text = (registers[4] / 10.0).ToString("0.0");
                lbr6.Text = (registers[5] / 10.0).ToString("0.0");
                lbr7.Text = (registers[6] / 10.0).ToString("0.0");
                lbr8.Text = (registers[7] / 10.0).ToString("0.0");

                isconnect1 = true;

                btnRDisconnect.Enabled = true;

                timer1.Start();

                txtlog.AppendText("连接成功" + "\r\n");
            }
            catch (Exception ex)
            {
                isconnect1 = false;
                if (master1 != null)
                { 
                   master1.Dispose();
                }
                if (serial != null && serial.IsOpen)
                {
                    serial.Close();
                }
                timer1.Stop();
                txtlog.AppendText("连接失败" + ex.Message + "\r\n");
                btnRConnnect.Enabled = true;
                btnRDisconnect.Enabled = false;
            }

        }

        private void btnRDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                isconnect1 = false;
                if (serial != null && serial.IsOpen)
                {
                    serial.Close();
                }
                if (master1 != null)
                {
                    master1.Dispose();
                }
                txtlog.AppendText("已断开连接" + "\r\n");

                btnRConnnect.Enabled = true;
                btnRDisconnect.Enabled = false;

            }
            catch (Exception ex)
            {
                txtlog.AppendText("断开异常" + ex.Message + "\r\n");
            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if (isconnect1 == false)
            {
                return;
            }
            try
            {
                ushort[] registers;
                registers = await Task.Run(() =>
                {
                    return master1.ReadHoldingRegisters(1, 0, 8);
                });

                lbr1.Text = (registers[0] / 10.0).ToString("0.0");
                lbr2.Text = (registers[1] / 10.0).ToString("0.0");
                lbr3.Text = (registers[2] / 10.0).ToString("0.0");
                lbr4.Text = (registers[3] / 10.0).ToString("0.0");
                lbr5.Text = (registers[4] / 10.0).ToString("0.0");
                lbr6.Text = (registers[5] / 10.0).ToString("0.0");
                lbr7.Text = (registers[6] / 10.0).ToString("0.0");
                lbr8.Text = (registers[7] / 10.0).ToString("0.0");
            }
            catch (Exception ex)
            {
                timer1.Stop();
                if (master1 != null)
                {
                    master1.Dispose();
                }
                if (serial != null && serial.IsOpen)
                { 
                    serial.Close();
                }
                txtlog.AppendText("对方已断开连接" + ex.Message + "\r\n");

                btnRConnnect.Enabled = true;
                btnRDisconnect.Enabled = false;

                isconnect1 = false;
            }
        }
    }
}
