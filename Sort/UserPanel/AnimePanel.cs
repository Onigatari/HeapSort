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
        public Point[] array = new Point[7];
        public int n;
        int step = 0;

        public struct Point
        {
            public int n;
            public MoveButton cord;

            void Add(int a, MoveButton b)
            {
                n = a;
                cord = b;
            }
        }

        private void StartXY()
        {
            point1.Left = TextPanel1.Location.X;
            point1.Top = TextPanel1.Location.Y;
            point2.Left = TextPanel2.Location.X;
            point2.Top = TextPanel2.Location.Y;
            point3.Left = TextPanel3.Location.X;
            point3.Top = TextPanel3.Location.Y;
            point4.Left = TextPanel4.Location.X;
            point4.Top = TextPanel4.Location.Y;
            point5.Left = TextPanel5.Location.X;
            point5.Top = TextPanel5.Location.Y;
            point6.Left = TextPanel6.Location.X;
            point6.Top = TextPanel6.Location.Y;
            point7.Left = TextPanel7.Location.X;
            point7.Top = TextPanel7.Location.Y;
        }

        private void ClearAllText()
        {
            StartButton.Text = "Старт";
            point1.Text = null;
            point2.Text = null;
            point3.Text = null;
            point4.Text = null;
            point5.Text = null;
            point6.Text = null;
            point7.Text = null;
            TextBox.Text = null;
            OutputTextBox.Text = null;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            step = 0;
            StartXY();
            ClearAllText();
            ClearButtonColor();

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
                TextBox.Text += rnd.Next(0, 9) + " ";
            TextBox.Text += rnd.Next(0, 9);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            step = 0;
            StartXY();
            ClearAllText();
            ClearButtonColor();
        }

        private void ClearButtonColor()
        {
            point1.ForeColor = Color.White;
            point1.BackColor = Color.FromArgb(160, 34, 34);
            point1.Font = new Font("Century Gothic", 18f);
            point2.ForeColor = Color.White;
            point2.BackColor = Color.FromArgb(160, 34, 34); ;
            point2.Font = new Font("Century Gothic", 18f);
            point3.ForeColor = Color.White;
            point3.BackColor = Color.FromArgb(160, 34, 34); ;
            point3.Font = new Font("Century Gothic", 18f);
            point4.ForeColor = Color.White;
            point4.BackColor = Color.FromArgb(160, 34, 34); ;
            point4.Font = new Font("Century Gothic", 18f);
            point5.ForeColor = Color.White;
            point5.BackColor = Color.FromArgb(160, 34, 34); ;
            point5.Font = new Font("Century Gothic", 18f);
            point6.ForeColor = Color.White;
            point6.BackColor = Color.FromArgb(160, 34, 34); ;
            point6.Font = new Font("Century Gothic", 18f);
            point7.ForeColor = Color.White;
            point7.BackColor = Color.FromArgb(160, 34, 34); ;
            point7.Font = new Font("Century Gothic", 18f);
        }

        private void RefPanel()
        {
            point1 = new MoveButton(TextPanel1.Location.X, TextPanel1.Location.Y);
            point2 = new MoveButton(TextPanel2.Location.X, TextPanel2.Location.Y);
            point3 = new MoveButton(TextPanel3.Location.X, TextPanel3.Location.Y);
            point4 = new MoveButton(TextPanel4.Location.X, TextPanel4.Location.Y);
            point5 = new MoveButton(TextPanel5.Location.X, TextPanel5.Location.Y);
            point6 = new MoveButton(TextPanel6.Location.X, TextPanel6.Location.Y);
            point7 = new MoveButton(TextPanel7.Location.X, TextPanel7.Location.Y);

            ref MoveButton refPoint1 = ref point1;
            ref MoveButton refPoint2 = ref point2;
            ref MoveButton refPoint3 = ref point3;
            ref MoveButton refPoint4 = ref point4;
            ref MoveButton refPoint5 = ref point5;
            ref MoveButton refPoint6 = ref point6;
            ref MoveButton refPoint7 = ref point7;
        }

        private void TextButton()
        {
            TopPanel.Controls.Add(point1);
            TopPanel.Controls.Add(point2);
            TopPanel.Controls.Add(point3);
            TopPanel.Controls.Add(point4);
            TopPanel.Controls.Add(point5);
            TopPanel.Controls.Add(point6);
            TopPanel.Controls.Add(point7);
        }

        private void InpitAnimePanel()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                    array[i].cord.swapMoveUP(TextPanel1.Location.X, TextPanel1.Location.Y);
                if (i == 1)
                    array[i].cord.swapMoveUP(TextPanel2.Location.X, TextPanel2.Location.Y);
                if (i == 2)
                    array[i].cord.swapMoveUP(TextPanel3.Location.X, TextPanel3.Location.Y);
                if (i == 3)
                    array[i].cord.swapMoveUP(TextPanel4.Location.X, TextPanel4.Location.Y);
                if (i == 4)
                    array[i].cord.swapMoveUP(TextPanel5.Location.X, TextPanel5.Location.Y);
                if (i == 5)
                    array[i].cord.swapMoveUP(TextPanel6.Location.X, TextPanel6.Location.Y);
                if (i == 6)
                    array[i].cord.swapMoveUP(TextPanel7.Location.X, TextPanel7.Location.Y);
            }
        }

        public AnimePanel()
        {
            InitializeComponent();
            TextBox.SelectionAlignment = HorizontalAlignment.Center;
            OutputTextBox.SelectionAlignment = HorizontalAlignment.Center;
            RefPanel();
            ClearButtonColor();
            TextButton();
        }

        private void Case0(string[] temp)
        {
            point1.Text = temp[0];
            point2.Text = temp[1];
            point3.Text = temp[2];
            point4.Text = temp[3];
            point5.Text = temp[4];
            point6.Text = temp[5];
            point7.Text = temp[6];
            for (int i = 0; i < temp.Length; i++)
            {
                array[i].n = int.Parse(temp[i]);
                if (i == 0)
                    array[i].cord = point1;
                if (i == 1)
                    array[i].cord = point2;
                if (i == 2)
                    array[i].cord = point3;
                if (i == 3)
                    array[i].cord = point4;
                if (i == 4)
                    array[i].cord = point5;
                if (i == 5)
                    array[i].cord = point6;
                if (i == 6)
                    array[i].cord = point7;
            }
        }
        private void Case1()
        {
            array[6].cord.swapMove(panel7.Location.X, panel7.Location.Y);
            array[5].cord.swapMove(panel6.Location.X, panel6.Location.Y);
            array[4].cord.swapMove(panel5.Location.X, panel5.Location.Y);
            array[3].cord.swapMove(panel4.Location.X, panel4.Location.Y);
            array[2].cord.swapMove(panel3.Location.X, panel3.Location.Y);
            array[1].cord.swapMove(panel2.Location.X, panel2.Location.Y);
            array[0].cord.swapMove(panel1.Location.X, panel1.Location.Y);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Text = "Шаг";
            string[] temp = TextBox.Text.Split();
            switch (step)
            {
                case 0:
                    Case0(temp);
                    step++;
                    break;
                case 1:
                    Case1();
                    step++;
                    break;
                case 2:
                    n = array.Length;
                    move_bildHeap();
                    step++;
                    break;
                case 3:
                    move_heapSort();
                    break;
                case 4:
                    move_heapSort();
                    break;
                case 5:
                    move_heapSort();
                    break;
                case 6:
                    move_heapSort();
                    break;
                case 7:
                    move_heapSort();
                    break;
                case 8:
                    move_heapSort();
                    break;
                case 9:
                    move_heapSort();
                    break;
                case 10:
                    InpitAnimePanel();
                    for (int i = 0; i < array.Length; i++)
                        OutputTextBox.Text += array[i].n + " ";
                    break;
            }
        }

        public void move_swap(int i, int j)
        {
            int temp1X = array[i].cord.Location.X;
            int temp1Y = array[i].cord.Location.Y;
            int temp2X = array[j].cord.Location.X;
            int temp2Y = array[j].cord.Location.Y;
            array[i].cord.swapMoveUP(PanelA.Location.X, PanelA.Location.Y);
            array[j].cord.swapMoveUP(PanelB.Location.X, PanelB.Location.Y);
            array[i].cord.swapMove(temp2X, temp2Y);
            array[j].cord.swapMove(temp1X, temp1Y);
            Point temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void move_bildHeap()
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                move_siftDown(n, i);
        }

        public void move_siftDown(int n, int i)
        {
            int size = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left].n > array[size].n)
                size = left;
            if (right < n && array[right].n > array[size].n)
                size = right;

            if (size != i)
            {
                move_swap(i, size);
                move_siftDown(n, size);
            }
        }

        public void move_heapSort()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                move_swap(0, i);
                step++;
                move_siftDown(i, 0);
                array[i].cord.BackColor = Color.Green;
                n--;
                return;
            }
        }
    }
}
