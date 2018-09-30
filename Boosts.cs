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
    public partial class Boosts : Form
    {
        public Boosts()
        {
            InitializeComponent();
        }
        //Declare Variables
        int Money, Money1, Money2, Money3;
        private void ColourChanger_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int A = random.Next(0, 255);
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);

            LblCoinStack.ForeColor = Color.FromArgb(A, A, G, B);
            LblStackMoney.ForeColor = Color.FromArgb(A, R, G, G);
            LblStashMoney.ForeColor = Color.FromArgb(G, R, G, B);
            LblMoneyTree.ForeColor = Color.FromArgb(A, G, G, B);

            Stash.ForeColor = Color.FromArgb(A, G, G, B);
            Stack.ForeColor = Color.FromArgb(A, A, G, B);
            MoneyTree.ForeColor = Color.FromArgb(A, R, B, B);
            Coins.ForeColor = Color.FromArgb(A, R, R, B);

            BtnCollectCoins.ForeColor = Color.FromArgb(A, A, G, B);
            BtnCollectStack.ForeColor = Color.FromArgb(A, G, G, B);
            BtnCollectStash.ForeColor = Color.FromArgb(A, R, G, B);
            BtnCollectMoneyTree.ForeColor = Color.FromArgb(A, B, G, B);
        }

        private void Boosts_Load(object sender, EventArgs e)
        {
            ColourChanger.Enabled = true;
            ColourChanger.Start();

            MoneyCount.Enabled = true;
            MoneyCount.Start(); 
        }

        private void MoneyCount_Tick(object sender, EventArgs e)
        {
            Coins.Text = "Money = " + Money.ToString("c");
            Stack.Text = "Money = " + Money1.ToString("c");
            Stash.Text = "Money = " + Money2.ToString("c");
            MoneyTree.Text = "Money = " + Money3.ToString("c");
        }

        private void BtnCoinStack_Click(object sender, EventArgs e)
        {
            Money = Money + 10; 
        }

        private void BtnCollectCoins_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to collect the money?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(Result == DialogResult.Yes)
            {
                Coins.Text = "Money = ";
                Money = 0;
            }
        }

        private void BtnCollectStack_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to collect the money?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                Coins.Text = "Money = ";
                Money1 = 0;
            }
        }

        private void BtnCollectStash_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to collect the money?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                Coins.Text = "Money = ";
                Money2 = 0;
            }
        }

        private void BtnCollectMoneyTree_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to collect the money?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                Coins.Text = "Money = ";
                Money3 = 0;
            }
        }

        private void LblFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMoneyPack_Click(object sender, EventArgs e)
        {
            Money1 = Money1 + 100;
        }

        private void BtnMoneyStack_Click(object sender, EventArgs e)
        {
            Money2 = Money2 + 1000;
        }

        private void BtnMoneyTree_Click(object sender, EventArgs e)
        {
            Money3 = Money3 + 10000;
        }
    }
}
