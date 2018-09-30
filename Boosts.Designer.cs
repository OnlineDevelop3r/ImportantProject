namespace ClickerGameSimple
{
    partial class Boosts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boosts));
            this.BtnMoneyTree = new System.Windows.Forms.Button();
            this.BtnCoinStack = new System.Windows.Forms.Button();
            this.BtnMoneyStack = new System.Windows.Forms.Button();
            this.BtnMoneyPack = new System.Windows.Forms.Button();
            this.MoneyCount = new System.Windows.Forms.Timer(this.components);
            this.LblCoinStack = new System.Windows.Forms.Label();
            this.LblStackMoney = new System.Windows.Forms.Label();
            this.LblStashMoney = new System.Windows.Forms.Label();
            this.LblMoneyTree = new System.Windows.Forms.Label();
            this.ColourChanger = new System.Windows.Forms.Timer(this.components);
            this.Coins = new System.Windows.Forms.Label();
            this.Stack = new System.Windows.Forms.Label();
            this.Stash = new System.Windows.Forms.Label();
            this.MoneyTree = new System.Windows.Forms.Label();
            this.BtnCollectCoins = new System.Windows.Forms.Button();
            this.BtnCollectStack = new System.Windows.Forms.Button();
            this.BtnCollectStash = new System.Windows.Forms.Button();
            this.BtnCollectMoneyTree = new System.Windows.Forms.Button();
            this.LblFormClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMoneyTree
            // 
            this.BtnMoneyTree.BackColor = System.Drawing.Color.Transparent;
            this.BtnMoneyTree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMoneyTree.BackgroundImage")));
            this.BtnMoneyTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoneyTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMoneyTree.Location = new System.Drawing.Point(10, 349);
            this.BtnMoneyTree.Name = "BtnMoneyTree";
            this.BtnMoneyTree.Size = new System.Drawing.Size(101, 91);
            this.BtnMoneyTree.TabIndex = 1;
            this.BtnMoneyTree.UseVisualStyleBackColor = false;
            this.BtnMoneyTree.Click += new System.EventHandler(this.BtnMoneyTree_Click);
            // 
            // BtnCoinStack
            // 
            this.BtnCoinStack.BackColor = System.Drawing.Color.Transparent;
            this.BtnCoinStack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCoinStack.BackgroundImage")));
            this.BtnCoinStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCoinStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCoinStack.Location = new System.Drawing.Point(10, 14);
            this.BtnCoinStack.Name = "BtnCoinStack";
            this.BtnCoinStack.Size = new System.Drawing.Size(101, 85);
            this.BtnCoinStack.TabIndex = 2;
            this.BtnCoinStack.UseVisualStyleBackColor = false;
            this.BtnCoinStack.Click += new System.EventHandler(this.BtnCoinStack_Click);
            // 
            // BtnMoneyStack
            // 
            this.BtnMoneyStack.BackColor = System.Drawing.Color.Transparent;
            this.BtnMoneyStack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMoneyStack.BackgroundImage")));
            this.BtnMoneyStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoneyStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMoneyStack.Location = new System.Drawing.Point(10, 231);
            this.BtnMoneyStack.Name = "BtnMoneyStack";
            this.BtnMoneyStack.Size = new System.Drawing.Size(101, 92);
            this.BtnMoneyStack.TabIndex = 3;
            this.BtnMoneyStack.UseVisualStyleBackColor = false;
            this.BtnMoneyStack.Click += new System.EventHandler(this.BtnMoneyStack_Click);
            // 
            // BtnMoneyPack
            // 
            this.BtnMoneyPack.BackColor = System.Drawing.Color.Transparent;
            this.BtnMoneyPack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMoneyPack.BackgroundImage")));
            this.BtnMoneyPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMoneyPack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMoneyPack.Location = new System.Drawing.Point(10, 125);
            this.BtnMoneyPack.Name = "BtnMoneyPack";
            this.BtnMoneyPack.Size = new System.Drawing.Size(101, 85);
            this.BtnMoneyPack.TabIndex = 4;
            this.BtnMoneyPack.UseVisualStyleBackColor = false;
            this.BtnMoneyPack.Click += new System.EventHandler(this.BtnMoneyPack_Click);
            // 
            // MoneyCount
            // 
            this.MoneyCount.Tick += new System.EventHandler(this.MoneyCount_Tick);
            // 
            // LblCoinStack
            // 
            this.LblCoinStack.AutoSize = true;
            this.LblCoinStack.BackColor = System.Drawing.Color.Transparent;
            this.LblCoinStack.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoinStack.Location = new System.Drawing.Point(117, 14);
            this.LblCoinStack.Name = "LblCoinStack";
            this.LblCoinStack.Size = new System.Drawing.Size(351, 18);
            this.LblCoinStack.TabIndex = 5;
            this.LblCoinStack.Text = "Buy this to get your Money to increase by $10/per second";
            // 
            // LblStackMoney
            // 
            this.LblStackMoney.AutoSize = true;
            this.LblStackMoney.BackColor = System.Drawing.Color.Transparent;
            this.LblStackMoney.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStackMoney.Location = new System.Drawing.Point(117, 125);
            this.LblStackMoney.Name = "LblStackMoney";
            this.LblStackMoney.Size = new System.Drawing.Size(358, 18);
            this.LblStackMoney.TabIndex = 6;
            this.LblStackMoney.Text = "Buy this to get your Money to increase by $100/per second";
            // 
            // LblStashMoney
            // 
            this.LblStashMoney.AutoSize = true;
            this.LblStashMoney.BackColor = System.Drawing.Color.Transparent;
            this.LblStashMoney.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStashMoney.Location = new System.Drawing.Point(117, 231);
            this.LblStashMoney.Name = "LblStashMoney";
            this.LblStashMoney.Size = new System.Drawing.Size(365, 18);
            this.LblStashMoney.TabIndex = 7;
            this.LblStashMoney.Text = "Buy this to get your Money to increase by $1000/per second";
            // 
            // LblMoneyTree
            // 
            this.LblMoneyTree.AutoSize = true;
            this.LblMoneyTree.BackColor = System.Drawing.Color.Transparent;
            this.LblMoneyTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMoneyTree.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneyTree.Location = new System.Drawing.Point(117, 349);
            this.LblMoneyTree.Name = "LblMoneyTree";
            this.LblMoneyTree.Size = new System.Drawing.Size(372, 18);
            this.LblMoneyTree.TabIndex = 8;
            this.LblMoneyTree.Text = "Buy this to get your Money to increase by $10000/per second\r\n";
            // 
            // ColourChanger
            // 
            this.ColourChanger.Tick += new System.EventHandler(this.ColourChanger_Tick);
            // 
            // Coins
            // 
            this.Coins.AutoSize = true;
            this.Coins.BackColor = System.Drawing.Color.Transparent;
            this.Coins.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coins.Location = new System.Drawing.Point(117, 55);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(103, 28);
            this.Coins.TabIndex = 9;
            this.Coins.Text = "Money = ";
            // 
            // Stack
            // 
            this.Stack.AutoSize = true;
            this.Stack.BackColor = System.Drawing.Color.Transparent;
            this.Stack.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stack.Location = new System.Drawing.Point(117, 182);
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(103, 28);
            this.Stack.TabIndex = 10;
            this.Stack.Text = "Money = ";
            // 
            // Stash
            // 
            this.Stash.AutoSize = true;
            this.Stash.BackColor = System.Drawing.Color.Transparent;
            this.Stash.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stash.Location = new System.Drawing.Point(117, 295);
            this.Stash.Name = "Stash";
            this.Stash.Size = new System.Drawing.Size(103, 28);
            this.Stash.TabIndex = 11;
            this.Stash.Text = "Money = ";
            // 
            // MoneyTree
            // 
            this.MoneyTree.AutoSize = true;
            this.MoneyTree.BackColor = System.Drawing.Color.Transparent;
            this.MoneyTree.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTree.Location = new System.Drawing.Point(117, 406);
            this.MoneyTree.Name = "MoneyTree";
            this.MoneyTree.Size = new System.Drawing.Size(103, 28);
            this.MoneyTree.TabIndex = 12;
            this.MoneyTree.Text = "Money = ";
            // 
            // BtnCollectCoins
            // 
            this.BtnCollectCoins.BackColor = System.Drawing.Color.Transparent;
            this.BtnCollectCoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCollectCoins.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCollectCoins.Location = new System.Drawing.Point(491, 43);
            this.BtnCollectCoins.Name = "BtnCollectCoins";
            this.BtnCollectCoins.Size = new System.Drawing.Size(89, 40);
            this.BtnCollectCoins.TabIndex = 14;
            this.BtnCollectCoins.Text = "Collect";
            this.BtnCollectCoins.UseVisualStyleBackColor = false;
            this.BtnCollectCoins.Click += new System.EventHandler(this.BtnCollectCoins_Click);
            // 
            // BtnCollectStack
            // 
            this.BtnCollectStack.BackColor = System.Drawing.Color.Transparent;
            this.BtnCollectStack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCollectStack.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnCollectStack.Location = new System.Drawing.Point(491, 170);
            this.BtnCollectStack.Name = "BtnCollectStack";
            this.BtnCollectStack.Size = new System.Drawing.Size(89, 40);
            this.BtnCollectStack.TabIndex = 15;
            this.BtnCollectStack.Text = "Collect";
            this.BtnCollectStack.UseVisualStyleBackColor = false;
            this.BtnCollectStack.Click += new System.EventHandler(this.BtnCollectStack_Click);
            // 
            // BtnCollectStash
            // 
            this.BtnCollectStash.BackColor = System.Drawing.Color.Transparent;
            this.BtnCollectStash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCollectStash.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnCollectStash.Location = new System.Drawing.Point(491, 283);
            this.BtnCollectStash.Name = "BtnCollectStash";
            this.BtnCollectStash.Size = new System.Drawing.Size(89, 40);
            this.BtnCollectStash.TabIndex = 16;
            this.BtnCollectStash.Text = "Collect";
            this.BtnCollectStash.UseVisualStyleBackColor = false;
            this.BtnCollectStash.Click += new System.EventHandler(this.BtnCollectStash_Click);
            // 
            // BtnCollectMoneyTree
            // 
            this.BtnCollectMoneyTree.BackColor = System.Drawing.Color.Transparent;
            this.BtnCollectMoneyTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCollectMoneyTree.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnCollectMoneyTree.Location = new System.Drawing.Point(491, 394);
            this.BtnCollectMoneyTree.Name = "BtnCollectMoneyTree";
            this.BtnCollectMoneyTree.Size = new System.Drawing.Size(89, 40);
            this.BtnCollectMoneyTree.TabIndex = 17;
            this.BtnCollectMoneyTree.Text = "Collect";
            this.BtnCollectMoneyTree.UseVisualStyleBackColor = false;
            this.BtnCollectMoneyTree.Click += new System.EventHandler(this.BtnCollectMoneyTree_Click);
            // 
            // LblFormClose
            // 
            this.LblFormClose.AutoSize = true;
            this.LblFormClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFormClose.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFormClose.Location = new System.Drawing.Point(595, -2);
            this.LblFormClose.Name = "LblFormClose";
            this.LblFormClose.Size = new System.Drawing.Size(31, 32);
            this.LblFormClose.TabIndex = 18;
            this.LblFormClose.Text = "X";
            this.LblFormClose.Click += new System.EventHandler(this.LblFormClose_Click);
            // 
            // grandientPanel_1
            // 
            Controls.Add(this.BtnMoneyTree);
            Controls.Add(this.BtnCollectStash);
            Controls.Add(this.BtnCollectMoneyTree);
            Controls.Add(this.BtnMoneyStack);
            Controls.Add(this.BtnMoneyPack);
            Controls.Add(this.BtnCollectStack);
            Controls.Add(this.BtnCoinStack);
            Controls.Add(this.BtnCollectCoins);
            Controls.Add(this.Coins);
            Controls.Add(this.LblCoinStack);
            Controls.Add(this.LblStackMoney);
            Controls.Add(this.LblStashMoney);
            Controls.Add(this.LblMoneyTree);
            Controls.Add(this.MoneyTree);
            Controls.Add(this.Stack);
            Controls.Add(this.Stash);
            Location = new System.Drawing.Point(2, -2);
            // 
            // Boosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.LblFormClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boosts";
            this.Load += new System.EventHandler(this.Boosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMoneyTree;
        private System.Windows.Forms.Button BtnCoinStack;
        private System.Windows.Forms.Button BtnMoneyStack;
        private System.Windows.Forms.Button BtnMoneyPack;
        private System.Windows.Forms.Timer MoneyCount;
        private System.Windows.Forms.Label LblCoinStack;
        private System.Windows.Forms.Label LblStackMoney;
        private System.Windows.Forms.Label LblStashMoney;
        private System.Windows.Forms.Label LblMoneyTree;
        private System.Windows.Forms.Timer ColourChanger;
        private System.Windows.Forms.Label Coins;
        private System.Windows.Forms.Label Stack;
        private System.Windows.Forms.Label Stash;
        private System.Windows.Forms.Label MoneyTree;
        private System.Windows.Forms.Button BtnCollectCoins;
        private System.Windows.Forms.Button BtnCollectStack;
        private System.Windows.Forms.Button BtnCollectStash;
        private System.Windows.Forms.Button BtnCollectMoneyTree;
        private System.Windows.Forms.Label LblFormClose;
    }
}