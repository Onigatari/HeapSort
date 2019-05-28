using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class MainForm : Form
    {
        private int x;
        private int y;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            beginPanel1.BringToFront();
            SidePanel.Height = BeginButton.Height;
            SidePanel.Top = BeginButton.Top;
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            filePanel2.BringToFront();
            SidePanel.Height = FileButton.Height;
            SidePanel.Top = FileButton.Top;
        }

        private void AniButton_Click(object sender, EventArgs e)
        {
            animePanel1.BringToFront();
            SidePanel.Height = AniButton.Height;
            SidePanel.Top = AniButton.Top;
        }

        private void AlgoButton_Click(object sender, EventArgs e)
        {
            webPanel1.BringToFront();
            SidePanel.Height = AlgoButton.Height;
            SidePanel.Top = AlgoButton.Top;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ExitButton.Height;
            SidePanel.Top = ExitButton.Top;
            Application.Exit();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }

        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void LogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }

        private void NameApp_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void NameApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }

        private void TextLabel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void TextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }

        private void TopPanel_DoubleClick(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
                base.WindowState = FormWindowState.Minimized;
        }
    }
}
