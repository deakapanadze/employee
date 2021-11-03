using test_2;
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
    public partial class AddButton : Form
    {
        dbmanager db = new dbmanager();

        public AddButton()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class2 = new Class1();
            class2.Telephone = txt_Telephone.Text;
            class2.Name = txt_Name.Text;
            class2.Lastname = txt_LastName.Text;
            class2.Date = Convert.ToDateTime(dt_Date.Text);
            db.insertEmp_sp(class2);
            this.Close();
        }
    }
}
