namespace Sort.UserPanel
{
    partial class FilePanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainMasTextBox = new System.Windows.Forms.RichTextBox();
            this.NewMasTextBox = new System.Windows.Forms.RichTextBox();
            this.TimerSec = new System.Windows.Forms.RichTextBox();
            this.FuncAlgo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RandomButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.AddBottun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FuncAlgo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMasTextBox
            // 
            this.MainMasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainMasTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMasTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MainMasTextBox.Location = new System.Drawing.Point(3, 3);
            this.MainMasTextBox.Name = "MainMasTextBox";
            this.MainMasTextBox.Size = new System.Drawing.Size(1024, 195);
            this.MainMasTextBox.TabIndex = 1;
            this.MainMasTextBox.Text = "";
            // 
            // NewMasTextBox
            // 
            this.NewMasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewMasTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMasTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.NewMasTextBox.Location = new System.Drawing.Point(3, 250);
            this.NewMasTextBox.Name = "NewMasTextBox";
            this.NewMasTextBox.Size = new System.Drawing.Size(480, 280);
            this.NewMasTextBox.TabIndex = 2;
            this.NewMasTextBox.Text = "";
            // 
            // TimerSec
            // 
            this.TimerSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TimerSec.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerSec.ForeColor = System.Drawing.SystemColors.Window;
            this.TimerSec.Location = new System.Drawing.Point(0, 204);
            this.TimerSec.Name = "TimerSec";
            this.TimerSec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TimerSec.Size = new System.Drawing.Size(1024, 40);
            this.TimerSec.TabIndex = 3;
            this.TimerSec.Text = "";
            // 
            // FuncAlgo
            // 
            this.FuncAlgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 8F);
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisX2.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisX2.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Century Gothic", 8F);
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 8F);
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisY2.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.AxisY2.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Century Gothic", 8F);
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            chartArea2.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.FuncAlgo.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.FuncAlgo.Legends.Add(legend2);
            this.FuncAlgo.Location = new System.Drawing.Point(497, 247);
            this.FuncAlgo.Name = "FuncAlgo";
            this.FuncAlgo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.EmptyPointStyle.BorderWidth = 4;
            series3.Legend = "Legend1";
            series3.Name = "Асимптотика n log(n)";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Кол-во операций";
            this.FuncAlgo.Series.Add(series3);
            this.FuncAlgo.Series.Add(series4);
            this.FuncAlgo.Size = new System.Drawing.Size(530, 280);
            this.FuncAlgo.TabIndex = 4;
            this.FuncAlgo.Text = "chart1";
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RandomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RandomButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RandomButton.Location = new System.Drawing.Point(339, 541);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(186, 54);
            this.RandomButton.TabIndex = 24;
            this.RandomButton.Text = "Случайная последовательность";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clear.Location = new System.Drawing.Point(699, 540);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(160, 55);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save.Location = new System.Drawing.Point(3, 540);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(162, 55);
            this.Save.TabIndex = 22;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Open.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Open.Location = new System.Drawing.Point(171, 540);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(162, 55);
            this.Open.TabIndex = 21;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Sort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sort.Location = new System.Drawing.Point(865, 540);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(160, 55);
            this.Sort.TabIndex = 20;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = false;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // AddBottun
            // 
            this.AddBottun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.AddBottun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBottun.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AddBottun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBottun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBottun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddBottun.Location = new System.Drawing.Point(531, 540);
            this.AddBottun.Name = "AddBottun";
            this.AddBottun.Size = new System.Drawing.Size(162, 55);
            this.AddBottun.TabIndex = 25;
            this.AddBottun.Text = "Добавить";
            this.AddBottun.UseVisualStyleBackColor = false;
            this.AddBottun.Click += new System.EventHandler(this.AddBottun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(842, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Кол-во элементов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ticks";
            // 
            // FilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBottun);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.FuncAlgo);
            this.Controls.Add(this.TimerSec);
            this.Controls.Add(this.NewMasTextBox);
            this.Controls.Add(this.MainMasTextBox);
            this.Name = "FilePanel";
            this.Size = new System.Drawing.Size(1030, 600);
            ((System.ComponentModel.ISupportInitialize)(this.FuncAlgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainMasTextBox;
        private System.Windows.Forms.RichTextBox NewMasTextBox;
        private System.Windows.Forms.RichTextBox TimerSec;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Sort;
        public System.Windows.Forms.DataVisualization.Charting.Chart FuncAlgo;
        private System.Windows.Forms.Button AddBottun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
