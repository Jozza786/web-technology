using System;
using System.Windows.Forms;

namespace ActivitiesApp
{
    public class Task1 : Form
    {
        ListBox listBox1;
        TextBox txtActivity;

        public Task1()
        {
            this.Text = "Task 1 - Student Club Management";
            this.Width = 700;
            this.Height = 500;

            // Input
            Label lbl = new Label() { Text = "Enter Activity:", Top = 30, Left = 30 };
            txtActivity = new TextBox() { Top = 60, Left = 30, Width = 300 };

            // Buttons
            Button btnAdd = new Button() { Text = "Add Activity", Top = 100, Left = 30, Width = 130 };
            btnAdd.Click += BtnAdd_Click;

            Button btnClear = new Button() { Text = "Clear", Top = 100, Left = 180, Width = 100 };
            btnClear.Click += (s, e) => listBox1.Items.Clear();

            Button btnExit = new Button() { Text = "Exit", Top = 100, Left = 300, Width = 100 };
            btnExit.Click += (s, e) => Application.Exit();

            // ListBox
            listBox1 = new ListBox() { Top = 160, Left = 30, Width = 620, Height = 280 };

            this.Controls.Add(lbl);
            this.Controls.Add(txtActivity);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnExit);
            this.Controls.Add(listBox1);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtActivity.Text))
            {
                listBox1.Items.Add(txtActivity.Text);
                txtActivity.Clear();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Task1());
        }
    }
}