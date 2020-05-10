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
        Button[,] btmin = new Button[10,10];
        int control = 0;
        int[,] a = new int[10, 10];
        int somin = 20;
        int so_o_mo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            int width = 30;
            lbsomin.BorderStyle = BorderStyle.Fixed3D;
            for (i = 0; i < 10; i++)
            {
                for(j=0; j < 10; j++)
                {
                    btmin[i, j] = new Button();
                    btmin[i, j].Width = width;
                    btmin[i, j].Height = width;
                    btmin[i, j].Location = new Point(i * width, j * width);
                    btmin[i, j].Text = "";
                    btmin[i, j].Click += new EventHandler(bammin);
                    paldomin.Controls.Add(btmin[i, j]);
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
            if(control == 0)
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
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("ban thang, ban co muon choi lai khong:", "Thong bao");
            }
            else
                if(control == -1)
            {
               DialogResult dlr = MessageBox.Show("Ban thang, ban co muon choi lai khong?", "Thong bao", MessageBoxButtons.YesNo);
                if(dlr == DialogResult.Yes)
                {
                    this.Hide();
                    this.Close();
                    this.ShowDialog();
                }

            }
        }
        private void mo_o(int i, int j)
        {
            if (a[i, j] == 0)
            {
                if (btmin[i,j].Text == "")
                {
                    so_o_mo++;
                    if (sominxungquanh(i, j) == 0)
                    {
                        btmin[i, j].Text = " ";
                        btmin[i, j].BackColor = Color.Beige;
                        mo_o_lan_can(i, j);
                    }
                    else
                        btmin[i, j].Text = sominxungquanh(i, j).ToString();
                    lbsomin.Text = so_o_mo.ToString();
                }
            }
            else
            {
                btmin[i, j].Text = "b";
                btmin[i, j].BackColor = Color.Red;
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
                    if (btmin[u,v].Text == "" && a[u,v] == 0)
                    {
                        so_o_mo++;
                        mo_o(u, v);
                    }
                }
            }
        }
        private void danhdau(object sender, MouseEventArgs e)
        {

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

    }
}
