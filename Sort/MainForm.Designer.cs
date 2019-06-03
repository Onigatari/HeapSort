namespace Sort
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BeginButton = new System.Windows.Forms.Button();
            this.AlgoButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.AniButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.NameApp = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.beginPanel1 = new Sort.UserPanel.BeginPanel();
            this.webPanel1 = new Sort.UserPanel.WebPanel();
            this.filePanel1 = new Sort.UserPanel.FilePanel();
            this.animePanel2 = new Sort.UserPanel.AnimePanel();
            this.animePanel1 = new Sort.UserPanel.AnimePanel();
            this.information1 = new Sort.UserPanel.Information();
            this.LeftPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LeftPanel.Controls.Add(this.Info);
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Controls.Add(this.ExitButton);
            this.LeftPanel.Controls.Add(this.BeginButton);
            this.LeftPanel.Controls.Add(this.AlgoButton);
            this.LeftPanel.Controls.Add(this.FileButton);
            this.LeftPanel.Controls.Add(this.AniButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(250, 700);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 128);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 73);
            this.SidePanel.TabIndex = 15;
            this.SidePanel.UseWaitCursor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitButton.Location = new System.Drawing.Point(12, 492);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(233, 73);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BeginButton
            // 
            this.BeginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BeginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BeginButton.ForeColor = System.Drawing.Color.White;
            this.BeginButton.Image = ((System.Drawing.Image)(resources.GetObject("BeginButton.Image")));
            this.BeginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BeginButton.Location = new System.Drawing.Point(12, 128);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(233, 73);
            this.BeginButton.TabIndex = 10;
            this.BeginButton.Text = "Начать";
            this.BeginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BeginButton.UseVisualStyleBackColor = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // AlgoButton
            // 
            this.AlgoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AlgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AlgoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AlgoButton.Image = ((System.Drawing.Image)(resources.GetObject("AlgoButton.Image")));
            this.AlgoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlgoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AlgoButton.Location = new System.Drawing.Point(12, 401);
            this.AlgoButton.Name = "AlgoButton";
            this.AlgoButton.Size = new System.Drawing.Size(233, 73);
            this.AlgoButton.TabIndex = 13;
            this.AlgoButton.Text = "Алгоритм";
            this.AlgoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlgoButton.UseVisualStyleBackColor = false;
            this.AlgoButton.Click += new System.EventHandler(this.AlgoButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FileButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileButton.Location = new System.Drawing.Point(13, 219);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(233, 73);
            this.FileButton.TabIndex = 11;
            this.FileButton.Text = "Считывание с файла";
            this.FileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileButton.UseVisualStyleBackColor = false;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // AniButton
            // 
            this.AniButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AniButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AniButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AniButton.Image = ((System.Drawing.Image)(resources.GetObject("AniButton.Image")));
            this.AniButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AniButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AniButton.Location = new System.Drawing.Point(13, 310);
            this.AniButton.Name = "AniButton";
            this.AniButton.Size = new System.Drawing.Size(233, 73);
            this.AniButton.TabIndex = 12;
            this.AniButton.Text = "Анимированная схема";
            this.AniButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AniButton.UseVisualStyleBackColor = false;
            this.AniButton.Click += new System.EventHandler(this.AniButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(250, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1050, 40);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.beginPanel1);
            this.MainPanel.Controls.Add(this.webPanel1);
            this.MainPanel.Controls.Add(this.filePanel1);
            this.MainPanel.Controls.Add(this.animePanel2);
            this.MainPanel.Controls.Add(this.information1);
            this.MainPanel.Location = new System.Drawing.Point(258, 90);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1030, 600);
            this.MainPanel.TabIndex = 2;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LogoPanel.Controls.Add(this.TextLabel);
            this.LogoPanel.Controls.Add(this.NameApp);
            this.LogoPanel.Location = new System.Drawing.Point(306, 8);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(350, 76);
            this.LogoPanel.TabIndex = 4;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseMove);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.ForeColor = System.Drawing.Color.White;
            this.TextLabel.Location = new System.Drawing.Point(8, 56);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(342, 17);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Пирамидальная сортировка («Сортировка кучей»)";
            this.TextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextLabel_MouseDown);
            this.TextLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextLabel_MouseMove);
            // 
            // NameApp
            // 
            this.NameApp.AutoSize = true;
            this.NameApp.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameApp.ForeColor = System.Drawing.Color.White;
            this.NameApp.Location = new System.Drawing.Point(1, 0);
            this.NameApp.Name = "NameApp";
            this.NameApp.Size = new System.Drawing.Size(238, 58);
            this.NameApp.TabIndex = 0;
            this.NameApp.Text = "HeapSort";
            this.NameApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameApp_MouseDown);
            this.NameApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameApp_MouseMove);
            // 
            // Info
            // 
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.Location = new System.Drawing.Point(0, 660);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(40, 40);
            this.Info.TabIndex = 17;
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // beginPanel1
            // 
            this.beginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.beginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginPanel1.Location = new System.Drawing.Point(0, 0);
            this.beginPanel1.Name = "beginPanel1";
            this.beginPanel1.Size = new System.Drawing.Size(1030, 600);
            this.beginPanel1.TabIndex = 0;
            // 
            // webPanel1
            // 
            this.webPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel1.Location = new System.Drawing.Point(0, 0);
            this.webPanel1.Name = "webPanel1";
            this.webPanel1.Size = new System.Drawing.Size(1030, 600);
            this.webPanel1.TabIndex = 2;
            // 
            // filePanel1
            // 
            this.filePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.filePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePanel1.Location = new System.Drawing.Point(0, 0);
            this.filePanel1.Name = "filePanel1";
            this.filePanel1.Size = new System.Drawing.Size(1030, 600);
            this.filePanel1.TabIndex = 4;
            // 
            // animePanel2
            // 
            this.animePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animePanel2.Location = new System.Drawing.Point(0, 0);
            this.animePanel2.Name = "animePanel2";
            this.animePanel2.Size = new System.Drawing.Size(1030, 600);
            this.animePanel2.TabIndex = 5;
            // 
            // animePanel1
            // 
            this.animePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animePanel1.Location = new System.Drawing.Point(0, 0);
            this.animePanel1.Name = "animePanel1";
            this.animePanel1.Size = new System.Drawing.Size(1030, 600);
            this.animePanel1.TabIndex = 3;
            // 
            // information1
            // 
            this.information1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.information1.Location = new System.Drawing.Point(0, 0);
            this.information1.Name = "information1";
            this.information1.Size = new System.Drawing.Size(1030, 600);
            this.information1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HeapSort";
            this.LeftPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label NameApp;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Button AlgoButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button AniButton;
        private System.Windows.Forms.Panel SidePanel;
        private UserPanel.BeginPanel beginPanel1;
        private UserPanel.WebPanel webPanel1;
        private UserPanel.AnimePanel animePanel1;
        private UserPanel.FilePanel filePanel1;
        private UserPanel.AnimePanel animePanel2;
        private System.Windows.Forms.Button Info;
        private UserPanel.Information information1;
    }
}

