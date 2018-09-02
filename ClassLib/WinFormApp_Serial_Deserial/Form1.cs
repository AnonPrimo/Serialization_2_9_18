using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_Serial_Deserial
{
    public partial class Form1 : Form
    {

        private int count_click;

        private string[] services;


        public Form1()
        {
            InitializeComponent();

            services = new string[4] { "Доставка", "Чистка", "Готовка", "Покраска" };

            count_click = 0;

            comboBox_Services.Items.AddRange(services);

            button_AddService.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_AddService_Click(object sender, EventArgs e)
        {
            count_click++;
            switch (count_click)
            {
                case 1:
                    {
                        groupBox.Location = new Point(groupBox.Location.X, comboBox_S1.Height + comboBox_S1.Location.Y);
                        comboBox_S1.Items.AddRange(services);
                        button_AddService.Enabled = false;

                    }
                    break;
                case 2:
                    {
                        groupBox.Location = new Point(groupBox.Location.X, comboBox_S2.Height + comboBox_S2.Location.Y);
                        comboBox_S2.Items.AddRange(services);
                        button_AddService.Enabled = false;

                    }
                    break;
                case 3:
                    { 
                    groupBox.Location = new Point(groupBox.Location.X, comboBox_S3.Height + comboBox_S3.Location.Y);
                        comboBox_S3.Items.AddRange(services);
                        button_AddService.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void button_CreateOrder_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (count_click)
            {
                case 0:
                    {
                        if (comboBox_Services.SelectedItem != null)
                        {
                            button_AddService.Enabled = true;
                            //foreach (var s in services)
                            //{
                            //    if (comboBox_Services.SelectedItem == s)
                            //        s.Remove(s.Length);
                            //}
                        }
                    }
                    break;
                case 1:
                    if (comboBox_S1.SelectedItem != null)
                        button_AddService.Enabled = true;
                    break;
                case 2:
                    if (comboBox_S2.SelectedItem != null)
                        button_AddService.Enabled = true;
                    break;
                default:
                    break;
            }
            
            
        }
    }
}
