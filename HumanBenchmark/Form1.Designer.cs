namespace HumanBenchmark
{
    partial class Form1
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
            this.btn_reactionGame = new System.Windows.Forms.Button();
            this.btn_targetBot = new System.Windows.Forms.Button();
            this.reactionBotTimer = new System.Windows.Forms.Timer(this.components);
            this.targetBotTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_type = new System.Windows.Forms.Button();
            this.updateMouseLabel = new System.Windows.Forms.Timer(this.components);
            this.lbl_mousePos = new System.Windows.Forms.Label();
            this.txt_read = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_visualMemory = new System.Windows.Forms.Button();
            this.visualMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.safetyTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_verbalMemory = new System.Windows.Forms.Button();
            this.verbalMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_numberMemory = new System.Windows.Forms.Button();
            this.numberMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_reactionGame
            // 
            this.btn_reactionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_reactionGame.Location = new System.Drawing.Point(13, 4);
            this.btn_reactionGame.Name = "btn_reactionGame";
            this.btn_reactionGame.Size = new System.Drawing.Size(185, 121);
            this.btn_reactionGame.TabIndex = 0;
            this.btn_reactionGame.Text = "Start reaction bot";
            this.btn_reactionGame.UseVisualStyleBackColor = true;
            this.btn_reactionGame.Click += new System.EventHandler(this.btn_reactionGame_Click);
            // 
            // btn_targetBot
            // 
            this.btn_targetBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_targetBot.Location = new System.Drawing.Point(204, 4);
            this.btn_targetBot.Name = "btn_targetBot";
            this.btn_targetBot.Size = new System.Drawing.Size(185, 121);
            this.btn_targetBot.TabIndex = 1;
            this.btn_targetBot.Text = "Start target bot";
            this.btn_targetBot.UseVisualStyleBackColor = true;
            this.btn_targetBot.Click += new System.EventHandler(this.btn_targetBot_Click);
            // 
            // reactionBotTimer
            // 
            this.reactionBotTimer.Interval = 1;
            this.reactionBotTimer.Tick += new System.EventHandler(this.reactionBotTimer_Tick);
            // 
            // targetBotTimer
            // 
            this.targetBotTimer.Interval = 5;
            this.targetBotTimer.Tick += new System.EventHandler(this.targetBotTimer_Tick);
            // 
            // btn_type
            // 
            this.btn_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_type.Location = new System.Drawing.Point(395, 4);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(185, 121);
            this.btn_type.TabIndex = 3;
            this.btn_type.Text = "Start typing";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Click += new System.EventHandler(this.btn_chimp_Click);
            // 
            // updateMouseLabel
            // 
            this.updateMouseLabel.Enabled = true;
            this.updateMouseLabel.Tick += new System.EventHandler(this.updateMouseLabel_Tick);
            // 
            // lbl_mousePos
            // 
            this.lbl_mousePos.AutoSize = true;
            this.lbl_mousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_mousePos.Location = new System.Drawing.Point(12, 393);
            this.lbl_mousePos.Name = "lbl_mousePos";
            this.lbl_mousePos.Size = new System.Drawing.Size(70, 26);
            this.lbl_mousePos.TabIndex = 4;
            this.lbl_mousePos.Text = "label1";
            // 
            // txt_read
            // 
            this.txt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txt_read.Location = new System.Drawing.Point(13, 132);
            this.txt_read.Name = "txt_read";
            this.txt_read.Size = new System.Drawing.Size(567, 248);
            this.txt_read.TabIndex = 5;
            this.txt_read.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_read.Location = new System.Drawing.Point(395, 301);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(185, 79);
            this.btn_read.TabIndex = 6;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_readChimp_Click);
            // 
            // btn_visualMemory
            // 
            this.btn_visualMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_visualMemory.Location = new System.Drawing.Point(586, 4);
            this.btn_visualMemory.Name = "btn_visualMemory";
            this.btn_visualMemory.Size = new System.Drawing.Size(185, 121);
            this.btn_visualMemory.TabIndex = 7;
            this.btn_visualMemory.Text = "Start visual memory";
            this.btn_visualMemory.UseVisualStyleBackColor = true;
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
            this.safetyTimer.Interval = 1000;
            this.safetyTimer.Tick += new System.EventHandler(this.safetyTimer_Tick);
            // 
            // btn_verbalMemory
            // 
            this.btn_verbalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_verbalMemory.Location = new System.Drawing.Point(586, 132);
            this.btn_verbalMemory.Name = "btn_verbalMemory";
            this.btn_verbalMemory.Size = new System.Drawing.Size(185, 121);
            this.btn_verbalMemory.TabIndex = 8;
            this.btn_verbalMemory.Text = "Start verbal memory";
            this.btn_verbalMemory.UseVisualStyleBackColor = true;
            this.btn_verbalMemory.Click += new System.EventHandler(this.btn_verbalMemory_Click);
            // 
            // verbalMemoryTimer
            // 
            this.verbalMemoryTimer.Interval = 400;
            this.verbalMemoryTimer.Tick += new System.EventHandler(this.verbalMemoryTimer_Tick);
            // 
            // btn_numberMemory
            // 
            this.btn_numberMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_numberMemory.Location = new System.Drawing.Point(586, 259);
            this.btn_numberMemory.Name = "btn_numberMemory";
            this.btn_numberMemory.Size = new System.Drawing.Size(185, 121);
            this.btn_numberMemory.TabIndex = 9;
            this.btn_numberMemory.Text = "Start number memory";
            this.btn_numberMemory.UseVisualStyleBackColor = true;
            this.btn_numberMemory.Click += new System.EventHandler(this.btn_numberMemory_Click);
            // 
            // numberMemoryTimer
            // 
            this.numberMemoryTimer.Interval = 50;
            this.numberMemoryTimer.Tick += new System.EventHandler(this.numberMemoryTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 424);
            this.Controls.Add(this.btn_numberMemory);
            this.Controls.Add(this.btn_verbalMemory);
            this.Controls.Add(this.btn_visualMemory);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_read);
            this.Controls.Add(this.lbl_mousePos);
            this.Controls.Add(this.btn_type);
            this.Controls.Add(this.btn_targetBot);
            this.Controls.Add(this.btn_reactionGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reactionGame;
        private System.Windows.Forms.Button btn_targetBot;
        private System.Windows.Forms.Timer reactionBotTimer;
        private System.Windows.Forms.Timer targetBotTimer;
        private System.Windows.Forms.Button btn_type;
        private System.Windows.Forms.Timer updateMouseLabel;
        private System.Windows.Forms.Label lbl_mousePos;
        private System.Windows.Forms.RichTextBox txt_read;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_visualMemory;
        private System.Windows.Forms.Timer visualMemoryTimer;
        private System.Windows.Forms.Timer safetyTimer;
        private System.Windows.Forms.Button btn_verbalMemory;
        private System.Windows.Forms.Timer verbalMemoryTimer;
        private System.Windows.Forms.Button btn_numberMemory;
        private System.Windows.Forms.Timer numberMemoryTimer;
    }
}

