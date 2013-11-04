using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DatabaseStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employmentDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter1.Fill(this.employmentDataSet.Person);
            // TODO: This line of code loads data into the 'jobDataSet.Employment' table. You can move, or remove it, as needed.
            this.employmentTableAdapter.Fill(this.jobDataSet.Employment);
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobDataSet js = new JobDataSet();
            
            personDataGridView.AutoGenerateColumns = true;
            personDataGridView.DataSource = js.Tables[0];
            //personDataGridView.DataMember = "Employment";
            
            //personDataGridView.DataSource = js.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter("Employment",conn);
            {

                JobDataSet js = new JobDataSet();
                da.Fill(js);
                DataTable dt = js.Tables[0];

                listBox2.DisplayMember = dt.Columns[0].ColumnName;
                listBox2.ValueMember = dt.Columns[1].ColumnName;

                listBox2.DataSource = dt;
            }
            */
            
            //listBox1.DisplayMember = "Phone";
            
            JobDataSet.EmploymentDataTable js = new JobDataSet.EmploymentDataTable();
            this.personBindingSource2.DataSource = js;
            //this.personBindingSource2.DataMember = "Employment";

            this.listBox2.DataSource = this.jobDataSet.Employment;
            listBox2.ValueMember = "PersonID";
            listBox2.DisplayMember = "PersonJob";
            
            /*
            JobDataSet js = new JobDataSet();

            personBindingSource2.DataSource = js;
            personBindingSource2.DataMember = "Employment";
            listBox2.DataSource = personBindingSource2;
            listBox2.ValueMember = "PersonID";
            listBox2.DisplayMember = "PersonJob";
             */
            /*
            JobDataSet js = new JobDataSet();
            personDataGridView.AutoGenerateColumns = true;
            personBindingSource.DataSource = js;
            
            personDataGridView.DataSource = personBindingSource;
             */

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox2.DataSource = this.personDataSet.Person;
            listBox2.DisplayMember = "Name";
        }
    }
}
