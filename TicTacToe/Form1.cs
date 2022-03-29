using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int ctr1 = 0;
        int ctr2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void tbxClick(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;

            if (btnX.Enabled == true)
            {
                tbx.Text = "X";
                tbx.Enabled = false;
                btnX.Enabled = false;
                ctr1 += 1;
                btnO.Enabled = true;
                btnO.BackColor = Color.Red;
                btnX.BackColor = Color.White;
            }

            else if (btnO.Enabled == true)
            {
                tbx.Text = "O";
                tbx.Enabled = false;
                btnO.Enabled = false;
                ctr2 += 1;
                btnX.Enabled = true;
                btnX.BackColor = Color.Red;
                btnO.BackColor = Color.White;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            btnX.Enabled = true;
            btnX.BackColor = Color.Red;
            btnO.BackColor = Color.White;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            btnO.Enabled = true;
            btnO.BackColor = Color.Red;
            btnX.BackColor = Color.White;
        }

        private void tmrControll_Tick(object sender, EventArgs e)
        {
            HControll();
            VControll();
            CControll();
            DControll();
        }

        private void DControll()
        {
            if (ctr1 == 5 || ctr2 == 5)
            {
                tmrControll.Stop();
                MessageBox.Show("Draw");
                Application.Restart();
            }
        }

        private void HControll()
        {
            string[] xo = { "X", "O" };
            string[] tbxd = {
            tbx1.Text, tbx2.Text,tbx3.Text,
            tbx4.Text,tbx5.Text,tbx6.Text,
            tbx7.Text,tbx8.Text,tbx9.Text };

            for (int i = 0; i < 9; i += 3)
            {
                if ((tbxd[i] == xo[0]) && (tbxd[i + 1] == xo[0]) && (tbxd[i + 2] == xo[0]))
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner X");
                    Application.Restart();
                }

                else if ((tbxd[i] == xo[1]) && (tbxd[i + 1] == xo[1]) && (tbxd[i + 2] == xo[1]))
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner O");
                    Application.Restart();
                }
            }
        }

        private void VControll()
        {
            string[] xo = { "X", "O" };
            string[] tbxd = {
            tbx1.Text, tbx2.Text,tbx3.Text,
            tbx4.Text,tbx5.Text,tbx6.Text,
            tbx7.Text,tbx8.Text,tbx9.Text };

            for (int i = 0; i < 3; i++)
            {
                if ((tbxd[i] == xo[0]) && (tbxd[i + 3] == xo[0]) && (tbxd[i + 6] == xo[0]))
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner X");
                    Application.Restart();
                }

                else if ((tbxd[i] == xo[1]) && (tbxd[i + 3] == xo[1]) && (tbxd[i + 6] == xo[1]))
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner O");
                    Application.Restart();
                }
            }
        }


        private void CControll()
        {
            string[] xo = { "X", "O" };
            string[] tbxd = {
            tbx1.Text, tbx2.Text,tbx3.Text,
            tbx4.Text,tbx5.Text,tbx6.Text,
            tbx7.Text,tbx8.Text,tbx9.Text };

            for (int i = 0; i < 1; i++)
            {
                if (((tbxd[i] == xo[0]) && (tbxd[i + 4] == xo[0]) && (tbxd[i + 8] == xo[0]))
                    || ((tbxd[i + 2] == xo[0]) && (tbxd[i + 4] == xo[0] && (tbxd[i + 6] == xo[0])))
                    )
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner X");
                    Application.Restart();
                }

                else if (((tbxd[i] == xo[1]) && (tbxd[i + 4] == xo[1]) && (tbxd[i + 8] == xo[1]))
                    || ((tbxd[i + 2] == xo[1]) && (tbxd[i + 4] == xo[1] && (tbxd[i + 6] == xo[1])))
                    )
                {
                    tmrControll.Stop();
                    MessageBox.Show("Winner O");
                    Application.Restart();
                }
            }
        }

        private void ptbRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
