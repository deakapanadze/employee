﻿using test_2;
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
    public partial class Form1 : Form
    {
        
        dbmanager db = new dbmanager();
        public Form1()
        {

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetTable1();
        }

        // ახხალი ფორმის გახსნა
        private void button3_Click(object sender, EventArgs e)
        {
            AddButton Add_Button = new AddButton();
            Add_Button.ShowDialog();

        }
        // textBox ის გასუფთავება 
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
        }


        private void GetTable1()
        {
            dataGridView1.DataSource = db.GetTable1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTable1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetTable1();
        }

        private void წაშლაToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogresult = MessageBox.Show("ნამდვილად გსურთ წაშლა ?", "", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                var selectedItem = (Class1)dataGridView1.SelectedRows[0].DataBoundItem;
                int ID = selectedItem.Id;
                //Cartridge.DeleteCartridges(ID);
                //GetInvoice();
            }
        }
    }
}