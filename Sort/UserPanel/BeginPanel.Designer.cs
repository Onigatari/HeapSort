namespace Sort.UserPanel
{
    partial class BeginPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SortButton = new System.Windows.Forms.Button();
            this.MasReadTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.MasWriteTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerSec = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountArray = new System.Windows.Forms.RichTextBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 97);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 503);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(930, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 423);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SortButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(100, 520);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 80);
            this.panel4.TabIndex = 3;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.SortButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SortButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SortButton.Location = new System.Drawing.Point(627, 6);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(300, 67);
            this.SortButton.TabIndex = 9;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MasReadTextBox
            // 
            this.MasReadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MasReadTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasReadTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MasReadTextBox.Location = new System.Drawing.Point(106, 97);
            this.MasReadTextBox.Name = "MasReadTextBox";
            this.MasReadTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MasReadTextBox.Size = new System.Drawing.Size(818, 100);
            this.MasReadTextBox.TabIndex = 4;
            this.MasReadTextBox.Text = "Введите изначальную последовательность...";
            this.MasReadTextBox.WordWrap = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClearButton.Location = new System.Drawing.Point(594, 203);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(330, 61);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RandomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RandomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RandomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RandomButton.Location = new System.Drawing.Point(106, 203);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(482, 61);
            this.RandomButton.TabIndex = 10;
            this.RandomButton.Text = "Случайная последовательность";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // MasWriteTextBox
            // 
            this.MasWriteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MasWriteTextBox.EnableAutoDragDrop = true;
            this.MasWriteTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasWriteTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.MasWriteTextBox.Location = new System.Drawing.Point(106, 355);
            this.MasWriteTextBox.Name = "MasWriteTextBox";
            this.MasWriteTextBox.ReadOnly = true;
            this.MasWriteTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MasWriteTextBox.Size = new System.Drawing.Size(818, 100);
            this.MasWriteTextBox.TabIndex = 11;
            this.MasWriteTextBox.Text = "";
            this.MasWriteTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(106, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время работы алгоритма:";
            // 
            // TimerSec
            // 
            this.TimerSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimerSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TimerSec.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.TimerSec.ForeColor = System.Drawing.SystemColors.Control;
            this.TimerSec.Location = new System.Drawing.Point(594, 269);
            this.TimerSec.Name = "TimerSec";
            this.TimerSec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TimerSec.Size = new System.Drawing.Size(330, 38);
            this.TimerSec.TabIndex = 13;
            this.TimerSec.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(106, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество элементов массиве:";
            // 
            // CountArray
            // 
            this.CountArray.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CountArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CountArray.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.CountArray.ForeColor = System.Drawing.SystemColors.Control;
            this.CountArray.Location = new System.Drawing.Point(594, 313);
            this.CountArray.Name = "CountArray";
            this.CountArray.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CountArray.Size = new System.Drawing.Size(330, 38);
            this.CountArray.TabIndex = 14;
            this.CountArray.Text = "";
            // 
            // BeginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountArray);
            this.Controls.Add(this.MasWriteTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.MasReadTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BeginPanel";
            this.Size = new System.Drawing.Size(1030, 600);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.RichTextBox MasReadTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.RichTextBox MasWriteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TimerSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CountArray;
    }
}
