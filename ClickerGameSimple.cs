using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGameSimple
{
    public partial class ClickerGameSimple : Form
    {
        public ClickerGameSimple()
        {
            InitializeComponent();
        }
        //Declare Variables
        int  Amount , Amount2 , Amount3 , Amount4 , Amount5 , Amount6;

        private void ClickerGameSimple_Load(object sender, EventArgs e)
        {
            TimeARGB.Start();
            TimeARGB.Enabled = true;       

            
        }
        private void btnBarrelClick_Click(object sender, EventArgs e)
        {
            LblMoney.Visible = true;
            Amount = Amount + 1;
            LblMoney.Text = "Money : " + Amount.ToString("c");
        }
        private void BtnDoubleBarrel_Click(object sender, EventArgs e)
        {
            LblMoney2.Visible = true;
            Amount2 = Amount2 + 2;
            LblMoney2.Text = "Money : " + Amount2.ToString("c");
        }
        private void LblClicker_Click(object sender, EventArgs e)
        {
        }
        private void TimeARGB_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int A = random.Next(0, 255);
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            LblClicker.ForeColor = Color.FromArgb(A, R, G, B);

            LblMoney.ForeColor = Color.FromArgb(A,R,G,B);
            LblMoney2.ForeColor = Color.FromArgb(A, R, G, B);
            LblMoney3.ForeColor = Color.FromArgb(A, R, G, B);
            LblClickThis.ForeColor = Color.FromArgb(A, R, G, B);

            LblMoney4.ForeColor = Color.FromArgb(A, R, G, B);
            LblMoney5.ForeColor = Color.FromArgb(A, R, G, B);
            LblMoney6.ForeColor = Color.FromArgb(A, R, G, B);
        }
        private void BtnBoosts_Click(object sender, EventArgs e)
        {
            Boosts BB = new Boosts();
            BB.Show();
        }
        private void LblClickThis_Click(object sender, EventArgs e)
        {
            UltraPanel.Visible = true;
            UltraPanel.Show();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnTripleBarrels_Click(object sender, EventArgs e)
        {
            LblMoney3.Visible = true;
            Amount3 = Amount3 + 3;
            LblMoney3.Text = "Money : " + Amount3.ToString("c");
        }
        private void BtnMetalBarrel_Click(object sender, EventArgs e)
        {
            LblMoney4.Visible = true;
            Amount4 = Amount4 + 10;
            LblMoney4.Text = "Money : " + Amount4.ToString("c");
        }
        private void BtnDoubleMetal_Click(object sender, EventArgs e)
        {
            LblMoney5.Visible = true;
            Amount5 = Amount5 + 12;
            LblMoney5.Text = "Money : " + Amount5.ToString("c");
        }
        private void BtnUltraBarrel_Click(object sender, EventArgs e)
        { 
            LblMoney6.Visible = true;
            Amount6 = Amount6 + 20;
            LblMoney6.Text = "Money : " + Amount6.ToString("c");
        }
        private void LblMoney_Click(object sender, EventArgs e)
        {
            //Nothing given right now
        }
    }
}
