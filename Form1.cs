using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Профессионалы_X
{
    public partial class Form1 : Form
    {
        private int PerehodCount = 6;
        private int SvetoforCount = 41;
        private PictureBox ClickedSvetofor;
        private PictureBox ClickedPerehod;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 250;
            timer2.Interval = 200;
        }
        private void ResCars()
        {
            RedCar.Visible = false;
            RedCar.Location = new Point(381, 23);

            RedCar1.Visible = false;
            RedCar1.Location = new Point(380, 56);

            RedCar2.Visible = false;
            RedCar2.Location = new Point(51, 56);

            RedCar3.Visible = false;
            RedCar3.Location = new Point(51, 320);

            RedCar4.Visible = false;
            RedCar4.Location = new Point(150, 320);

            RedCar5.Visible = false;
            RedCar5.Location = new Point(149, 452);

            BlueCar.Visible = false;
            BlueCar.Location = new Point(51, 23);

            BlueCar1.Visible = false;
            BlueCar1.Location = new Point(51, 89);

            BlueCar2.Visible = false;
            BlueCar2.Location = new Point(380, 89);

            BlueCar3.Visible = false;
            BlueCar3.Location = new Point(380, 320);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RedCar.Visible == true)
            {
                RedCar.Top += 33;
            }
            if(RedCar.Top > 56)
            {
                RedCar.Visible = false;
                RedCar1.Visible = true;
                RedCar1.Left -= 33;
            }
            if(RedCar1.Left < 50)
            {
                RedCar1.Visible=false;
                RedCar2.Visible = true;
                RedCar2.Top += 33;
            }
            if(RedCar2.Top > 320)
            {
                RedCar2.Visible = false;
                RedCar3.Visible = true;
                RedCar3.Left += 33;
            }
            if(RedCar3.Left > 150)
            {
                RedCar3.Visible=false;
                RedCar4.Visible = true;
                RedCar4.Top += 33;
            }
            if(RedCar4.Top > 452)
            {
                RedCar4.Visible=false;
                RedCar5.Visible = true;
                RedCar5.Left -= 33;
            }
            if(RedCar5.Left < 17)
            {
                RedCar5.Visible=false;
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            timer1.Start();
            RedCar.Visible = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ResCars();

            timer1.Start();
            RedCar.Visible = true;

            timer2.Start();
            BlueCar.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(BlueCar.Visible == true)
            {
                BlueCar.Top += 33;
            }
            if(BlueCar.Top > 89)
            {
                BlueCar.Visible=false;
                BlueCar1.Visible = true;
                BlueCar1.Left += 33;
            }
            if (BlueCar1.Left > 381)
            {
                BlueCar1.Visible=false;
                BlueCar2.Visible = true;
                BlueCar2.Top += 33;
            }
            if(BlueCar2.Top > 321)
            {
                BlueCar2.Visible=false;
                BlueCar3.Visible = true;
                BlueCar3.Left += 33;
            }
            if(BlueCar3.Left > 645)
            {
                BlueCar3.Visible=false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            ResCars();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void Perehod1_Click(object sender, EventArgs e)
        {
            ClickedPerehod = (PictureBox)sender;
        }

        private void Perehod_Click(object sender, EventArgs e)
        {
            if(PerehodCount < 6)
            {
                if(ClickedPerehod != null)
                {
                    if (ClickedPerehod.Width > 33)
                    {
                        PerehodCount++;
                        LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                        ClickedPerehod.BackgroundImage = Properties.Resources.perehod_h;
                    }
                    else
                    {
                        PerehodCount++;
                        LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                        ClickedPerehod.BackgroundImage = Properties.Resources.perehod_v;
                    }
                }
            }
            else if (PerehodCount == 6)
            {
                MessageBox.Show("На дороге достигнуто максимальное кол-во переходов");
            }
            else
            {
                MessageBox.Show("Сначала выберите ячейку");
            }
        }

        private void Svetofor1_Click(object sender, EventArgs e)
        {
            ClickedSvetofor = (PictureBox)sender;
        }

        private void Svetofor_Click(object sender, EventArgs e)
        {
            if(SvetoforCount < 41)
            {
                if(ClickedSvetofor != null)
                {
                    SvetoforCount++;
                    LabelSvetofor.Text = "Светофоры: " + SvetoforCount.ToString();
                    ClickedSvetofor.BackgroundImage = Properties.Resources.svetofor;
                }
            }
            else if(SvetoforCount == 41)
            {
                MessageBox.Show("На дороге достигнут максимум в кол-ве светофоров");
            }
            else
            {
                MessageBox.Show("Сначала выберите ячейку");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(ClickedPerehod != null)
            {
                PerehodCount--;
                LabelPerehod.Text = "Переходы: " + PerehodCount.ToString();
                ClickedPerehod.BackgroundImage = null;
            }
            if(ClickedSvetofor != null)
            {
                SvetoforCount--;
                LabelSvetofor.Text = "Светофоры: " + SvetoforCount.ToString();
                ClickedSvetofor.BackgroundImage = null;
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            
        }
    }
}
