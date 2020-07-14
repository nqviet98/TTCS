using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDoMin
{
    public partial class Form1 : Form
    {
        Button[,] btnmin = new Button[10,10];
        int[,] b = new int[10, 10];
        int[,] a = new int[10, 10];
        int somin = 20;
        int so_o_mo = 0;
        int control = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            lbsomin.Text = somin.ToString();
            int i = 0, j = 0;
            int width = 30;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    
                    btnmin[i, j] = new Button();
                    btnmin[i, j].Width = width;
                    btnmin[i, j].Height = width;
                    btnmin[i, j].Location = new Point(i * width, j * width);
                    btnmin[i, j].Text = "";
                    btnmin[i, j].Click += new EventHandler(bammin);
                    paldomin.Controls.Add(btnmin[i, j]);
                    a[i, j] = 0;
                }
            }
            int dem = 0;
            while (dem < somin)
            {
                Random rnd = new Random();
                i = rnd.Next(10);
                j = rnd.Next(10);
                if (a[i, j] == 0)
                {
                    a[i, j] = 1;
                    dem++;
                }
            }
        }

        private void bammin(object sender, EventArgs e)
        {
            if (control == 0)
            {
                int width = 30;
                int x = 0, y = 0;
                x = ((Button)sender).Location.X;
                y = ((Button)sender).Location.Y;
                int i = 0, j = 0;
                i = x / width;
                j = y / width;
                mo_o(i, j); 
            }
            if(control == 1)
            {
                for(int i = 0; i < 10; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        if(a[i, j] == 1)
                        {
                            btnmin[i, j].Image = Image.FromFile("./Image/ mine2.ico");
                        }
                    }
                }
                MessageBox.Show("You Win", "", MessageBoxButtons.OK);
            }
            else
                if(control == -1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            mo_o(i, j);
                        }
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (a[i, j] == 1)
                        {
                            btnmin[i, j].Image = Image.FromFile("./Image/mine2.ico");
                        }
                    }
                }
                MessageBox.Show("You Lose", "", MessageBoxButtons.OK);
            }
        }
        private void mo_o(int i, int j)
        {
            if (a[i, j] == 0)
            {
                if (btnmin[i,j].Text == "")
                {
                    so_o_mo++;
                    if (sominxungquanh(i, j) == 0)
                    {
                        btnmin[i, j].Text = " ";
                        btnmin[i, j].BackColor = Color.LightGreen;
                        mo_o_lan_can(i, j);
                    }
                    else
                    {
                        btnmin[i, j].Text = " ";
                        switch (sominxungquanh(i,j))
                        {
                            case 1:
                                btnmin[i, j].ForeColor = Color.Blue;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 2:
                                btnmin[i, j].ForeColor = Color.Green;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 3:
                                btnmin[i, j].ForeColor = Color.Red;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 4:
                                btnmin[i, j].ForeColor = Color.Navy;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 5:
                                btnmin[i, j].ForeColor = Color.Maroon;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 6:
                                btnmin[i, j].ForeColor = Color.Teal;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 7:
                                btnmin[i, j].ForeColor = Color.Black;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;
                            case 8:
                                btnmin[i, j].ForeColor = Color.Gray;
                                btnmin[i, j].Text = sominxungquanh(i, j).ToString();
                                break;

                        }
                        
                    }
                        
                    lbsoo.Text = so_o_mo.ToString();
                }
                if (so_o_mo == 80)
                    control = 1;
            }
            else
            {
                btnmin[i, j].Image = Image.FromFile("./Image/mine.ico");
                btnplay.Image = Image.FromFile("./Image/smiley3.ico");
                btnmin[i, j].BackColor = Color.Red;
                control = -1;
            }
        }
        private void mo_o_lan_can(int i, int j)
        {
            for (int u = i - 1; u <= i + 1; u++)
            {
                for (int v = j - 1; v <= j + 1; v++)
                {
                    if (u < 0 || u >= 10 || v < 0 || v >= 10)
                    {
                        continue;
                    }
                    if (u == i && v == j)
                    {
                        continue;
                    }
                    if (btnmin[u,v].Text == "" && a[u,v] == 0)
                    {
                        mo_o(u, v);
                    }
                }
            }
        }
        private void danhdau(object sender, MouseEventArgs e, int i, int j)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(b[i, j] >= 0 && b[i, j] <2)
                {
                    b[i, j]++;
                }
                else
                    if(b[i, j] == 2)
                {
                    b[i, j] = 0;
                }
                switch(b[i, j])
                {
                    case 1:
                        btnmin[i, j].Image = Image.FromFile("./Image/flag.ico");
                        break;
                    case 2:
                        btnmin[i, j].Image = Image.FromFile("./Image/tile2.ico");
                        break;
                }
            }    
        }
        private int sominxungquanh(int i, int j)
        {
            int minxungquanh = 0;
            for (int u = i - 1; u <= i + 1; u++)
            {
                for (int v = j - 1; v <= j + 1; v++)
                {
                    if (u < 0 || u >= 10 || v < 0 || v >= 10)
                    {
                        continue;
                    }
                    if (u == i && v == j)
                    {
                        continue;
                    }
                    minxungquanh += a[u, v];
                }
            }
            return minxungquanh;
        }

        private void btnplay_MouseClick(object sender, MouseEventArgs e)
        {
            paldomin.Controls.Clear();
            
            LoadData();
            control = 0;
            so_o_mo = 0;
            somin = 20;
            lbsoo.Text = "00";
            lbsomin.Text = somin.ToString();
            btnplay.Image = Image.FromFile("./Image/smiley1.ico");
        }
    }
}
