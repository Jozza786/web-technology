using System;
using System.Windows.Forms;

namespace ActivitiesApp
{
    public class Task2 : Form
    {
        ListBox listBox1;
        TextBox txtSubject, txtTeacher, txtRoom;

        public Task2()
        {
            this.Text = "Task 2 - School Subject Management";
            this.Width = 750;
            this.Height = 550;

            this.Controls.Add(new Label() { Text = "Subject Name:", Top = 30, Left = 30 });
            this.Controls.Add(new Label() { Text = "Teacher Name:", Top = 70, Left = 30 });
            this.Controls.Add(new Label() { Text = "Room Number:", Top = 110, Left = 30 });

            txtSubject = new TextBox() { Top = 30, Left = 170, Width = 250 };
            txtTeacher = new TextBox() { Top = 70, Left = 170, Width = 250 };
            txtRoom = new TextBox() { Top = 110, Left = 170, Width = 250 };

            Button btnAdd = new Button() { Text = "Add Subject", Top = 160, Left = 30, Width = 140 };
            btnAdd.Click += BtnAdd_Click;

            Button btnClear = new Button() { Text = "Clear", Top = 160, Left = 190, Width = 100 };
            btnClear.Click += (s, e) => listBox1.Items.Clear();

            Button btnExit = new Button() { Text = "Exit", Top = 160, Left = 310, Width = 100 };
            btnExit.Click += (s, e) => Application.Exit();

            listBox1 = new ListBox() { Top = 210, Left = 30, Width = 680, Height = 280 };

            this.Controls.Add(txtSubject);
            this.Controls.Add(txtTeacher);
            this.Controls.Add(txtRoom);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnExit);
            this.Controls.Add(listBox1);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject.Text))
            {
                string info = "Subject: " + txtSubject.Text + " | Teacher: " + txtTeacher.Text + " | Room: " + txtRoom.Text;
                listBox1.Items.Add(info);
                
                txtSubject.Clear();
                txtTeacher.Clear();
                txtRoom.Clear();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Task2());
        }
    }
}