using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using lab_1.Models;

namespace lab_1
{
    public partial class Form1 : MaterialForm
    {
        public int CountOfStudents = 0;
        public List<StudentVm> Students = new List<StudentVm>();
        public FileManager FileManager = new FileManager("INFO.txt");
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            Color Dark = Color.FromArgb(33, 33, 33);
            Color LessDark = Color.FromArgb(42, 42, 42);
            Color MoreDark = Color.FromArgb(5, 5, 5);
            Color Orange = Color.Orange;
            Color White = Color.White;

            int a1 = 16;
            int a2 = a1;

            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey500, Accent.Orange100, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(LessDark, Dark, MoreDark, Orange, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void Button_SaveStudents_Click(object sender, EventArgs e)
        {
            if (MultiLineTextBox_Students.Text == "")
            {
                MessageBox.Show("Не було введенно даних ні одного студента", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            FileManager.Save(Students);

            Students.Clear();
            MultiLineTextBox_Students.Text = "";
            Label_StudentsCounter.Text = ((CountOfStudents = 0)).ToString();
        }
        private void Button_LoadStudents_Click(object sender, EventArgs e)
        {
            Students.Clear();

            Students = FileManager.Load();

            var temp = (from p in Students orderby p.Phonenumber select p);
            Students = temp.ToList();

            for (int i = 0; i < Students.Count; i++)
            {
                MultiLineTextBox_Students.Text += Students[i].Phonenumber + ", " + Students[i].Surname + ";\n";
                CountOfStudents++;
            }
            Label_StudentsCounter.Text = (CountOfStudents).ToString();
        }
        private void Button_AddToList_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Surname.Text == "" || TextBox_Address.Text == "" || TextBox_PhoneNumber.Text == "")
            {
                MessageBox.Show("Заповніть усі поля даних", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            StudentVm student = new StudentVm(TextBox_Name.Text, TextBox_Surname.Text, TextBox_Address.Text, TextBox_PhoneNumber.Text);
            MultiLineTextBox_Students.Text += student.Name + ", " + student.Surname + ", " + student.Adress + ", " + student.Phonenumber + ";\n";
            Students.Add(student);
            Label_StudentsCounter.Text = (++CountOfStudents).ToString();
        }
        private void Button_ClearStudents_Click(object sender, EventArgs e)
        {
            Students.Clear();
            MultiLineTextBox_Students.Text = "";
            Label_StudentsCounter.Text = ((CountOfStudents = 0)).ToString();
        }
    }
}
