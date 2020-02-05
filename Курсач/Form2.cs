using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
namespace Курсач
{

    public partial class Form2 : Form 
    {

        public Form2()
        {
            InitializeComponent();
        }


        ModbusClient modbusClient;
       
        private void button_conect_Click(object sender, EventArgs e)
        {
            if (status.Text == "offline")
            {
                try
                {
                    int port = Convert.ToInt32(portbox.Text);
                    modbusClient = new ModbusClient(ipbox.Text, port);    //Ip-Address and Port of Modbus-TCP-Server

                    modbusClient.Connect();

                    status.Text = "online";
                    status.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString() + "\n\nСтандартный адресс для подключения: 192.168.100.8\nСтандартный порт: 502");

                }
            }
            else MessageBox.Show("Подключение уже выполнено!");
        }


        private void button_disconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();

            status.Text = "offline";
            status.ForeColor = Color.Crimson;
        }
      
        private void ipbox_TextChanged(object sender, EventArgs e)
        {
            if(ipbox.Text=="Ваш ip") ipbox.Clear(); ;
        }

        private void portbox_TextChanged(object sender, EventArgs e)
        {
            if (portbox.Text == "Ваш порт") portbox.Clear();
        }
    }
}
