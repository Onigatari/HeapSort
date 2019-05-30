using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sort.UserPanel
{
    public partial class AnimePanel : UserControl
    {
        MoveButton point1, point2, point3, point4, point5, point6, point7;
        public AnimePanel()
        {
            InitializeComponent();
            point1 = new MoveButton(panel1.Location.X, panel1.Location.Y);
            point2 = new MoveButton(panel2.Location.X, panel2.Location.Y);
            point3 = new MoveButton(panel3.Location.X, panel3.Location.Y);
            point4 = new MoveButton(panel4.Location.X, panel4.Location.Y);
            point5 = new MoveButton(panel5.Location.X, panel5.Location.Y);
            point6 = new MoveButton(panel6.Location.X, panel6.Location.Y);
            point7 = new MoveButton(panel7.Location.X, panel7.Location.Y);

            point1.ForeColor = Color.White;
            point1.Font = new Font("Century Gothic", 18f);
            point2.ForeColor = Color.White;
            point2.Font = new Font("Century Gothic", 18f);
            point3.ForeColor = Color.White;
            point3.Font = new Font("Century Gothic", 18f);
            point4.ForeColor = Color.White;
            point4.Font = new Font("Century Gothic", 18f);
            point5.ForeColor = Color.White;
            point5.Font = new Font("Century Gothic", 18f);
            point6.ForeColor = Color.White;
            point6.Font = new Font("Century Gothic", 18f);
            point7.ForeColor = Color.White;
            point7.Font = new Font("Century Gothic", 18f);

            TopPanel.Controls.Add(point1);
            TopPanel.Controls.Add(point2);
            TopPanel.Controls.Add(point3);
            TopPanel.Controls.Add(point4);
            TopPanel.Controls.Add(point5);
            TopPanel.Controls.Add(point6);
            TopPanel.Controls.Add(point7);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            point1.Text = "7";
        }
    }
}
