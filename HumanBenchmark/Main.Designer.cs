namespace HumanBenchmark
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_reactionGame = new System.Windows.Forms.Button();
            this.btn_targetBot = new System.Windows.Forms.Button();
            this.reactionBotTimer = new System.Windows.Forms.Timer(this.components);
            this.targetBotTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_type = new System.Windows.Forms.Button();
            this.btn_visualMemory = new System.Windows.Forms.Button();
            this.visualMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.safetyTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_verbalMemory = new System.Windows.Forms.Button();
            this.verbalMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_numberMemory = new System.Windows.Forms.Button();
            this.numberMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reactionGame
            // 
            this.btn_reactionGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_reactionGame.BackgroundImage = global::HumanBenchmark.Properties.Resources.thunder;
            this.btn_reactionGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reactionGame.FlatAppearance.BorderSize = 0;
            this.btn_reactionGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reactionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_reactionGame.Location = new System.Drawing.Point(0, 0);
            this.btn_reactionGame.Name = "btn_reactionGame";
            this.btn_reactionGame.Size = new System.Drawing.Size(100, 100);
            this.btn_reactionGame.TabIndex = 0;
            this.btn_reactionGame.UseVisualStyleBackColor = false;
            this.btn_reactionGame.Click += new System.EventHandler(this.btn_reactionGame_Click);
            // 
            // btn_targetBot
            // 
            this.btn_targetBot.BackColor = System.Drawing.Color.Transparent;
            this.btn_targetBot.BackgroundImage = global::HumanBenchmark.Properties.Resources.target;
            this.btn_targetBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_targetBot.FlatAppearance.BorderSize = 0;
            this.btn_targetBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_targetBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_targetBot.Location = new System.Drawing.Point(0, 100);
            this.btn_targetBot.Name = "btn_targetBot";
            this.btn_targetBot.Size = new System.Drawing.Size(100, 100);
            this.btn_targetBot.TabIndex = 1;
            this.btn_targetBot.UseVisualStyleBackColor = false;
            this.btn_targetBot.Click += new System.EventHandler(this.btn_targetBot_Click);
            // 
            // reactionBotTimer
            // 
            this.reactionBotTimer.Interval = 1;
            this.reactionBotTimer.Tick += new System.EventHandler(this.reactionBotTimer_Tick);
            // 
            // targetBotTimer
            // 
            this.targetBotTimer.Interval = 1;
            this.targetBotTimer.Tick += new System.EventHandler(this.targetBotTimer_Tick);
            // 
            // btn_type
            // 
            this.btn_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_type.BackColor = System.Drawing.Color.Transparent;
            this.btn_type.BackgroundImage = global::HumanBenchmark.Properties.Resources.type;
            this.btn_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_type.FlatAppearance.BorderSize = 0;
            this.btn_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_type.Location = new System.Drawing.Point(0, 300);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(100, 100);
            this.btn_type.TabIndex = 3;
            this.btn_type.UseVisualStyleBackColor = false;
            this.btn_type.Click += new System.EventHandler(this.btn_chimp_Click);
            // 
            // btn_visualMemory
            // 
            this.btn_visualMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_visualMemory.BackColor = System.Drawing.Color.Transparent;
            this.btn_visualMemory.BackgroundImage = global::HumanBenchmark.Properties.Resources.menu_1_;
            this.btn_visualMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_visualMemory.Enabled = false;
            this.btn_visualMemory.FlatAppearance.BorderSize = 0;
            this.btn_visualMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_visualMemory.Location = new System.Drawing.Point(0, 500);
            this.btn_visualMemory.Name = "btn_visualMemory";
            this.btn_visualMemory.Size = new System.Drawing.Size(100, 100);
            this.btn_visualMemory.TabIndex = 7;
            this.btn_visualMemory.UseVisualStyleBackColor = false;
            this.btn_visualMemory.Click += new System.EventHandler(this.button1_Click);
            // 
            // visualMemoryTimer
            // 
            this.visualMemoryTimer.Interval = 20;
            this.visualMemoryTimer.Tick += new System.EventHandler(this.visualMemoryTimer_Tick);
            // 
            // safetyTimer
            // 
            this.safetyTimer.Enabled = true;
            this.safetyTimer.Interval = 250;
            this.safetyTimer.Tick += new System.EventHandler(this.safetyTimer_Tick);
            // 
            // btn_verbalMemory
            // 
            this.btn_verbalMemory.BackColor = System.Drawing.Color.Transparent;
            this.btn_verbalMemory.BackgroundImage = global::HumanBenchmark.Properties.Resources.vocabulary;
            this.btn_verbalMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verbalMemory.FlatAppearance.BorderSize = 0;
            this.btn_verbalMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verbalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_verbalMemory.Location = new System.Drawing.Point(0, 200);
            this.btn_verbalMemory.Name = "btn_verbalMemory";
            this.btn_verbalMemory.Size = new System.Drawing.Size(100, 100);
            this.btn_verbalMemory.TabIndex = 8;
            this.btn_verbalMemory.UseVisualStyleBackColor = false;
            this.btn_verbalMemory.Click += new System.EventHandler(this.btn_verbalMemory_Click);
            // 
            // verbalMemoryTimer
            // 
            this.verbalMemoryTimer.Interval = 70;
            this.verbalMemoryTimer.Tick += new System.EventHandler(this.verbalMemoryTimer_Tick);
            // 
            // btn_numberMemory
            // 
            this.btn_numberMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_numberMemory.BackColor = System.Drawing.Color.Transparent;
            this.btn_numberMemory.BackgroundImage = global::HumanBenchmark.Properties.Resources.five;
            this.btn_numberMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_numberMemory.FlatAppearance.BorderSize = 0;
            this.btn_numberMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_numberMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_numberMemory.Location = new System.Drawing.Point(0, 400);
            this.btn_numberMemory.Name = "btn_numberMemory";
            this.btn_numberMemory.Size = new System.Drawing.Size(100, 100);
            this.btn_numberMemory.TabIndex = 9;
            this.btn_numberMemory.UseVisualStyleBackColor = false;
            this.btn_numberMemory.Click += new System.EventHandler(this.btn_numberMemory_Click);
            // 
            // numberMemoryTimer
            // 
            this.numberMemoryTimer.Interval = 1000;
            this.numberMemoryTimer.Tick += new System.EventHandler(this.numberMemoryTimer_Tick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_verbalMemory);
            this.panel.Controls.Add(this.btn_visualMemory);
            this.panel.Controls.Add(this.btn_numberMemory);
            this.panel.Controls.Add(this.btn_type);
            this.panel.Controls.Add(this.btn_targetBot);
            this.panel.Controls.Add(this.btn_reactionGame);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(100, 604);
            this.panel.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 604);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(793, 643);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reactionGame;
        private System.Windows.Forms.Button btn_targetBot;
        private System.Windows.Forms.Timer reactionBotTimer;
        private System.Windows.Forms.Timer targetBotTimer;
        private System.Windows.Forms.Button btn_type;
        private System.Windows.Forms.Button btn_visualMemory;
        private System.Windows.Forms.Timer visualMemoryTimer;
        private System.Windows.Forms.Timer safetyTimer;
        private System.Windows.Forms.Button btn_verbalMemory;
        private System.Windows.Forms.Timer verbalMemoryTimer;
        private System.Windows.Forms.Button btn_numberMemory;
        private System.Windows.Forms.Timer numberMemoryTimer;
        private System.Windows.Forms.Panel panel;
    }
}

