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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        string[] a;
    
        ModbusClient modbusClient;


        private void button_givedata_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();

            modbusClient = new ModbusClient("192.168.100.8", 502);    //Ip-Address and Port of Modbus-TCP-Server
            modbusClient.Connect();

            try
            {

                int Address = Convert.ToInt32(startingAddress.Text);
                int kolvo = Convert.ToInt32(quantity.Text);

                if (RadioHolding.Checked == true)
            {
                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters((Address - 40001), (kolvo - Address + 1));

                for (int i = 0; i < readHoldingRegisters.Length; i++)
                {
                    if (i < readHoldingRegisters.Length - 1) dataGridView1.Rows.Insert(i, 1);

                    dataGridView1.Rows[i].Cells[1].Value = readHoldingRegisters[i].ToString();
                    dataGridView1.Rows[i].Cells[0].Value = (Address + i);
                }
            }

            if (RadioInput.Checked == true)
            {
                int[] ReadInputRegisters = modbusClient.ReadInputRegisters((Address - 30001), (kolvo - Address + 1));

                for (int i = 0; i < ReadInputRegisters.Length; i++)
                {
                    if (i< ReadInputRegisters.Length-1) dataGridView1.Rows.Insert(i, 1);

                    dataGridView1.Rows[i].Cells[1].Value = ReadInputRegisters[i].ToString();
                    dataGridView1.Rows[i].Cells[0].Value = (Address + i);
                }
            }
            button_changedata.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n\nДиапазон адрессов:\n\nInputRegister - 30001\nHoldingRegisters - 40001");
            }
        }

        private void button_changedata_Click(object sender, EventArgs e)
        {
            int Address = Convert.ToInt32(startingAddress.Text);
            a = new string[dataGridView1.RowCount];

            if (RadioHolding.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    modbusClient.WriteSingleRegister((Address - 40001), Convert.ToInt32(dataGridView1[1, i].Value.ToString())); //holdeng
                    Address++;
                }
            }
            if (RadioInput.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
 
                    Address++;
                }
            }
        }
    }
}
