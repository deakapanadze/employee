
namespace test_2
{
    partial class UpdateButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.upd_Date = new System.Windows.Forms.DateTimePicker();
            this.upd_LastName = new System.Windows.Forms.TextBox();
            this.upd_Name = new System.Windows.Forms.TextBox();
            this.upd_Telephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Save.Location = new System.Drawing.Point(313, 185);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 29);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "შენახვა";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // upd_Date
            // 
            this.upd_Date.Location = new System.Drawing.Point(151, 72);
            this.upd_Date.Name = "upd_Date";
            this.upd_Date.Size = new System.Drawing.Size(293, 23);
            this.upd_Date.TabIndex = 16;
            // 
            // upd_LastName
            // 
            this.upd_LastName.Location = new System.Drawing.Point(151, 144);
            this.upd_LastName.Name = "upd_LastName";
            this.upd_LastName.Size = new System.Drawing.Size(293, 23);
            this.upd_LastName.TabIndex = 15;
            // 
            // upd_Name
            // 
            this.upd_Name.Location = new System.Drawing.Point(151, 111);
            this.upd_Name.Name = "upd_Name";
            this.upd_Name.Size = new System.Drawing.Size(293, 23);
            this.upd_Name.TabIndex = 14;
            // 
            // upd_Telephone
            // 
            this.upd_Telephone.Location = new System.Drawing.Point(151, 32);
            this.upd_Telephone.Name = "upd_Telephone";
            this.upd_Telephone.Size = new System.Drawing.Size(293, 23);
            this.upd_Telephone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "გვარი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "სახელი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "თარიღი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ტელეფონის ნომერი";
            // 
            // UpdateButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 230);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.upd_Date);
            this.Controls.Add(this.upd_LastName);
            this.Controls.Add(this.upd_Name);
            this.Controls.Add(this.upd_Telephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateButton";
            this.Text = "UpdateButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker upd_Date;
        private System.Windows.Forms.TextBox upd_LastName;
        private System.Windows.Forms.TextBox upd_Name;
        private System.Windows.Forms.TextBox upd_Telephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}