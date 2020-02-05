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
    public partial class Main_Page : Form
    {

        ModbusServer modbusServer;

        public Main_Page()
        {
            InitializeComponent();
        }

        void RadioCheck()
        {
            if (RadioServer.Checked == true)
            {
                buttonServer.Enabled = true;
                button_menu_conect.Enabled = false;
                button_give_data.Enabled = false;
            }
            if (RadioKlient.Checked == true)
            {
                buttonServer.Enabled = false;
                button_menu_conect.Enabled = true;
                button_give_data.Enabled = true;
            }
        }
 
        private void button_conect_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (statusServer.Text == "offline")
            {
                modbusServer = new EasyModbus.ModbusServer();
                modbusServer.holdingRegisters = new EasyModbus.ModbusServer.HoldingRegisters(modbusServer);
                modbusServer.holdingRegisters[5] = 99; //Для примера зададим одному из регистров конкретное значение

                statusServer.Text = "online";
                statusServer.ForeColor = Color.Green;


                modbusServer.Listen();
                Console.Read();
            }
            else
            {
                modbusServer.StopListening();

                statusServer.Text = "offline";
                statusServer.ForeColor = Color.Crimson;
            }


        }

        private void RadioServer_CheckedChanged(object sender, EventArgs e)
        {
            RadioCheck();
        }

        private void button_give(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
