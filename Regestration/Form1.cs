using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regestration
{
    public partial class Form1 : Form
    {

        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string birthDate;
        private string type;
        private string country;
        private DataTable dt;

        private string ln;
        public Form1()
        {
            this.firstName = "Your Name";
            this.email = "example@gmail.com";
            this.password = "*********";
            this.birthDate = "YYYY-MM-DD";
            this.type = "UnKnown";
            this.country = "Your country";

            ln = "\n";

            InitializeComponent();
            InitializeDataTable();
            guna2DataGridView1.Resize += (s, e) => ResizeFont();
            print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           
        }

        private void SumbitBtn_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void Guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleBtn.Checked)
            {
                this.type = femaleBtn.Text;
            }
        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.firstName = firstNameTxt.Text;
        }

        private void LastNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.lastName = lastNameTxt.Text;
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            this.email = emailTxt.Text;

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            this.password = passwordTxt.Text;
        }

        private void MaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maleBtn.Checked)
            {
                this.type = maleBtn.Text;
            }
        }

        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.country = countryBox.Text;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showInfo()
        {
            DataGridView dgv = new DataGridView();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dgv.BackgroundColor = Color.Transparent;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;


            dgv.Columns.Add("col1", "FirstName");
            dgv.Columns.Add("col1", "LastName");
            dgv.Columns.Add("col3", "Email");
            dgv.Columns.Add("col4", "Password");
            dgv.Columns.Add("col5", "Gender");
            dgv.Columns.Add("col6", "BirthDate");

            dgv.Rows.Add("Mohannad",this.lastName,this.email,this.password,this.type,this.birthDate);
            infoPanel.Controls.Add(dgv);

            

        }

        private void clear()
        {
           this.firstNameTxt.Text = null;
            this.lastNameTxt.Text = null;
            this.emailTxt.Text = null;
            this.passwordTxt.Text = null;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            showInfo();
            MessageBox.Show("Hi");
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            this.display();
            //this.showInfo();
            this.clear();

           
        }

        private void Guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Age");
            dt.Columns.Add("ap");

        }

        private void display()
        {
            //showInfoLabel.Text = "Name : " + ln + this.firstName + " " + this.lastName + ln + "Email:" + ln + this.email +ln+"Password"+this.password+ln+"Gender:"+this.type+ln+"BirthDate:"+ln+this.birthDate;


        }

        private void HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Password");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Birth Date");

            // ربط DataGridView بالجدول
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.DefaultCellStyle.Font = new Font("Arial", 5, FontStyle.Bold);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14, FontStyle.Bold);
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.LightYellow;  
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black; 
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy; 
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; 

            guna2DataGridView1.EnableHeadersVisualStyles = false; 
            guna2DataGridView1.GridColor = Color.Gray; 
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; 


            guna2DataGridView1.RowTemplate.Height = 30;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            guna2DataGridView1.ColumnHeadersHeight = 40; 

            dt.Rows.Add(firstName,lastName,email,password,type,birthDate);


        }

        private void ResizeFont()
        {

            float fontSize = Math.Max(guna2DataGridView1.Width / 50, 10); 
            guna2DataGridView1.DefaultCellStyle.Font = new Font("Arial", fontSize, FontStyle.Bold);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", fontSize + 2, FontStyle.Bold);
        }


    }
}
