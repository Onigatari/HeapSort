namespace Sort.UserPanel
{
    partial class AnimePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LowPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.LowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartButton.Location = new System.Drawing.Point(840, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(187, 51);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.Controls.Add(this.panel4);
            this.TopPanel.Controls.Add(this.panel5);
            this.TopPanel.Controls.Add(this.panel6);
            this.TopPanel.Controls.Add(this.panel7);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1030, 540);
            this.TopPanel.TabIndex = 13;
            // 
            // LowPanel
            // 
            this.LowPanel.Controls.Add(this.StartButton);
            this.LowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowPanel.Location = new System.Drawing.Point(0, 540);
            this.LowPanel.Name = "LowPanel";
            this.LowPanel.Size = new System.Drawing.Size(1030, 60);
            this.LowPanel.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(380, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 62);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(580, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 62);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(280, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 62);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(380, 370);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 62);
            this.panel5.TabIndex = 4;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(580, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 62);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(680, 370);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 62);
            this.panel7.TabIndex = 4;
            this.panel7.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(480, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // AnimePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LowPanel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.Name = "AnimePanel";
            this.Size = new System.Drawing.Size(1030, 600);
            this.TopPanel.ResumeLayout(false);
            this.LowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LowPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
