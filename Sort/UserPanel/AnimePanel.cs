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
            point1 = new MoveButton(TextPanel1.Location.X, TextPanel1.Location.Y);
            point2 = new MoveButton(TextPanel2.Location.X, TextPanel2.Location.Y);
            point3 = new MoveButton(TextPanel3.Location.X, TextPanel3.Location.Y);
            point4 = new MoveButton(TextPanel4.Location.X, TextPanel4.Location.Y);
            point5 = new MoveButton(TextPanel5.Location.X, TextPanel5.Location.Y);
            point6 = new MoveButton(TextPanel6.Location.X, TextPanel6.Location.Y);
            point7 = new MoveButton(TextPanel7.Location.X, TextPanel7.Location.Y);

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
            string[] temp = TextBox.Text.Split();
            point1.Text = temp[0];
            point2.Text = temp[1];
            point3.Text = temp[2];
            point4.Text = temp[3];
            point5.Text = temp[4];
            point6.Text = temp[5];
            point7.Text = temp[6];

            int[] array = new int[7];
            for (int i = 0; i < temp.Length; i++)
                array[i] = int.Parse(temp[i]);

            heapSort(ref array);
            point1.start(panel1.Location.X - TextPanel1.Location.X, panel1.Location.Y - TextPanel1.Location.Y);
            point2.start(panel2.Location.X - TextPanel2.Location.X, panel2.Location.Y - TextPanel2.Location.Y);
            point3.start(panel3.Location.X - TextPanel3.Location.X, panel3.Location.Y - TextPanel3.Location.Y);
            point4.start(panel4.Location.X - TextPanel4.Location.X, panel4.Location.Y - TextPanel4.Location.Y);
            point5.start(panel5.Location.X - TextPanel5.Location.X, panel5.Location.Y - TextPanel5.Location.Y);
            point6.start(panel6.Location.X - TextPanel6.Location.X, panel6.Location.Y - TextPanel6.Location.Y);
            point7.start(panel7.Location.X - TextPanel7.Location.X, panel7.Location.Y - TextPanel7.Location.Y);
        }

        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void bildHeap(ref int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                siftDown(arr, n, i);
        }

        public static void siftDown(int[] arr, int n, int i)
        {
            int size = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[size])
                size = left;
            if (right < n && arr[right] > arr[size])
                size = right;

            if (size != i)
            {
                swap(ref arr[i], ref arr[size]);
                siftDown(arr, n, size);
            }
        }

        public static void heapSort(ref int[] arr)
        {
            int n = arr.Length;
            bildHeap(ref arr, n);

            for (int i = n - 1; i >= 0; i--)
            {
                swap(ref arr[0], ref arr[i]);
                siftDown(arr, i, 0);
            }
        }
    }
}
