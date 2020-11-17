namespace StresserClient
{
    partial class StresserClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StresserClient));
            this.Attack = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.ThreadCount = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(195, 344);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(131, 44);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Start Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(185, 176);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(150, 20);
            this.Port.TabIndex = 3;
            this.Port.Text = "Target Port";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(185, 100);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(150, 20);
            this.IP.TabIndex = 4;
            this.IP.Text = "Target IP";
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            // 
            // ThreadCount
            // 
            this.ThreadCount.Location = new System.Drawing.Point(185, 257);
            this.ThreadCount.Name = "ThreadCount";
            this.ThreadCount.Size = new System.Drawing.Size(150, 20);
            this.ThreadCount.TabIndex = 5;
            this.ThreadCount.Text = "Thread Count";
            this.ThreadCount.TextChanged += new System.EventHandler(this.ThreadCount_TextChanged);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(209, 394);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(102, 37);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop Attack";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(222, 44);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(74, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Stresser Client";
            // 
            // StresserClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 535);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.ThreadCount);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Attack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StresserClient";
            this.Text = "StresserClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox ThreadCount;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label TitleLabel;
    }
}

