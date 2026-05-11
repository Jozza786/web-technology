using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivitiesApp
{
    public class Task3 : Form
    {
        ListBox listBox1;

        public Task3()
        {
            this.Text = "Task 3 - Library Activities System";
            this.Width = 750;
            this.Height = 520;
            this.BackColor = Color.LightCyan;        // Form Background Color

            // Buttons with Colors
            AddLibraryButton("Books", 50, 40, Color.LightGreen, 
                new string[] { "Rich Dad Poor Dad", "Atomic Habits", "The Alchemist" });

            AddLibraryButton("Magazines", 50, 220, Color.LightPink, 
                new string[] { "Time", "National Geographic", "Forbes" });

            AddLibraryButton("Newspapers", 120, 40, Color.LightBlue, 
                new string[] { "Dawn", "The News", "Daily Times" });

            AddLibraryButton("Story Books", 120, 220, Color.LightYellow, 
                new string[] { "Harry Potter", "Cinderella", "The Little Prince" });

            // Clear Button
            Button btnClear = new Button() 
            { 
                Text = "Clear", 
                Top = 380, 
                Left = 50, 
                Width = 160,
                BackColor = Color.LightGray,
                Height = 40
            };
            btnClear.Click += (s, e) => listBox1.Items.Clear();
            this.Controls.Add(btnClear);

            // Exit Button
            Button btnExit = new Button() 
            { 
                Text = "Exit", 
                Top = 430, 
                Left = 50, 
                Width = 160,
                BackColor = Color.LightCoral,
                Height = 40
            };
            btnExit.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnExit);

            // ListBox
            listBox1 = new ListBox() 
            { 
                Top = 50, 
                Left = 420, 
                Width = 300, 
                Height = 380,
                BackColor = Color.WhiteSmoke
            };
            this.Controls.Add(listBox1);
        }

        private void AddLibraryButton(string text, int top, int left, Color color, string[] items)
        {
            Button btn = new Button() 
            { 
                Text = text, 
                Top = top, 
                Left = left, 
                Width = 160, 
                Height = 50,
                BackColor = color,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btn.Click += (s, e) =>
            {
                listBox1.Items.Clear();
                foreach (string item in items)
                    listBox1.Items.Add(item);
            };
            this.Controls.Add(btn);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Task3());
        }
    }
}