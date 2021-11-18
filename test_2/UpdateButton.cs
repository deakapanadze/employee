using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2.Model;

namespace test_2
{
    public partial class UpdateButton : Form
    {
        public int Id;
        Form1 forms = new Form1();
        Class1 update = new Class1();
        dbmanager db = new dbmanager();
        DataGridView dataGridView1 = new DataGridView();

        public UpdateButton(int id, Form1 form)
        {
            this.Id = id;
            this.forms = form;

            InitializeComponent();
            update = db.GetEmployeeById(Id);
            upd_Telephone.Text = update.Telephone;
            upd_Date.Value = Convert.ToDateTime(update.Date);
            upd_Name.Text = update.Name;
            upd_LastName.Text = update.Lastname;


        }



        private void GetTable1()
        {
            dataGridView1.DataSource = db.GetTable1();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(upd_Telephone.Text) || String.IsNullOrEmpty(upd_Name.Text) || String.IsNullOrEmpty(upd_LastName.Text))
            {

                MessageBox.Show("გთხოვთ შეავსოთ ყველა ველი");
                return;

            }
       

            update.Telephone = upd_Telephone.Text;
            update.Date = upd_Date.Value;
            update.Name = upd_Name.Text;
            update.Lastname = upd_LastName.Text;
            db.update_employee(update);
            this.Close();


        }

       
    }
}
