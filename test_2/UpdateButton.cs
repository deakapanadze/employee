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
        public int id;
        dbmanager db = new dbmanager();



        public UpdateButton()
        {
            InitializeComponent();
           
        }




        private void UpdateButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }





        //private void upd_Telephone_TextChanged(object sender, EventArgs e)
        //{
        //    Class1 upd = new Class1();
        //    upd.Telephone = upd_Telephone.Text;
        //    db.update_employee(upd);
        //    db.GetTable1();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Class1 upd = new Class1();
        //    upd.Telephone = upd_Telephone.Text;
        //    db.update_employee(upd);
        //    this.Close();
        //}





    }
}
