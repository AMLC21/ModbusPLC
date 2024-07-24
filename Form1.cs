/*****************************************************************
* PROGRAMA DE PRUEBA PARA CONEXION A PLC POR MODBUS TCP          *
* REALIZADO POR: MARISOL LOZANO C.                               *
* Para que sea funcional, se debe configurar primero el          *
* dispositivo PLC en Modbus Maping para definir las direcciones  *
* que se van a utilizar (Direcciones de entradas y salidas)      *
******************************************************************/

//Notas: Aunque el Addres en el PLC comience como 000001, se debe tratar en C# como posicion 0, el 000002 como posicion 1, etc.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus; //Descargar del NuGet pack EasyModbusTCP

//Entradas y salidas del PLC
//I/O --ADDRS PLC--ADDRS C#
//DI0 -- 000001 ----- 0
//DI1 -- 000002 ----- 1
//DI2 -- 000003 ----- 2
//DI3 -- 000004 ----- 3
//DI4 -- 000005 ----- 4
//DI5 -- 000006 ----- 5
//DI6 -- 000007 ----- 6
//DI7 -- 000008 ----- 7
//DO0 -- 000009 ----- 8
//DO1 -- 000010 ----- 9
//DO2 -- 000011 ----- 10
//DO3 -- 000012 ----- 11
//DO4 -- 000013 ----- 12
//DO5 -- 000014 ----- 13
//DO6 -- 000015 ----- 14

namespace ModbusCommunication
{
    public partial class ModbusConn : Form
    {
        ModbusClient Micro20 = new ModbusClient(); //Creacion del cliente modbus (PLC)
        public ModbusConn()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Micro20.IPAddress = Convert.ToString(tbIp.Text);   //Para conectar al plc por medio de su IP         

            try
            {
                Micro20.Connect(); //Trata de conectar al PLC (despues de haber guardado el IP)
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            if(Micro20.Connected == true)
            {
                lblStatus.Text = "Conectado";
                lblStatus.ForeColor = Color.LightGreen;
            }
        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            Micro20.Disconnect();//Funcion para desconectar PLC
            lblStatus.Text = "Desconectado";
            lblStatus.ForeColor = Color.Red;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] resultado;
                resultado = Micro20.ReadCoils(0, 8); //Funcion para leer los boleanos de las direcciones del PLC (Posicion de la primera direccion y cantidad de elementos a leer)
                tbDI0.Text = resultado[0].ToString();
                tbDI1.Text = resultado[1].ToString();
                tbDI2.Text = resultado[2].ToString();
                tbDI3.Text = resultado[3].ToString();
                tbDI4.Text = resultado[4].ToString();
                tbDI5.Text = resultado[5].ToString();
                tbDI6.Text = resultado[6].ToString();
                tbDI7.Text = resultado[7].ToString();
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }           

        }

        private void ModbusConn_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e) //DO0
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res0 = Micro20.ReadCoils(8, 1); //Lee una posición exacta de una direccion (detecta si la salida 0 con direccion 8 esta encendida)
                if (!res0[0])
                {
                    Micro20.WriteSingleCoil(8, true);
                    btnWrite.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(8, false);
                    btnWrite.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite2_Click(object sender, EventArgs e) //DO1
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(9, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(9, true);
                    btnWrite2.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(9, false);
                    btnWrite2.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite3_Click(object sender, EventArgs e) //DO2
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(10, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(10, true);
                    btnWrite3.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(10, false);
                    btnWrite3.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite4_Click(object sender, EventArgs e) //DO3
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(11, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(11, true);
                    btnWrite4.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(11, false);
                    btnWrite4.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite5_Click(object sender, EventArgs e) //DO4
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(12, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(12, true);
                    btnWrite5.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(12, false);
                    btnWrite5.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite6_Click(object sender, EventArgs e) //DO5
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(13, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(13, true);
                    btnWrite6.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(13, false);
                    btnWrite6.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }

        private void btnWrite7_Click(object sender, EventArgs e) //DO6
        {
            if (lblStatus.Text == "Conectado")
            {
                bool[] res1 = Micro20.ReadCoils(14, 1);
                if (!res1[0])
                {
                    Micro20.WriteSingleCoil(14, true);
                    btnWrite7.BackColor = Color.Green;
                }
                else
                {
                    Micro20.WriteSingleCoil(14, false);
                    btnWrite7.BackColor = Color.Indigo;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Conecte primero al PLC");
            }
        }
    }
}
