
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
            this.button1 = new System.Windows.Forms.Button();
            this.upd__Date = new System.Windows.Forms.DateTimePicker();
            this.upd__LastName = new System.Windows.Forms.TextBox();
            this.upd__Name = new System.Windows.Forms.TextBox();
            this.upd_Telephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(313, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "დამატება";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upd__Date
            // 
            this.upd__Date.Location = new System.Drawing.Point(151, 72);
            this.upd__Date.Name = "upd__Date";
            this.upd__Date.Size = new System.Drawing.Size(293, 23);
            this.upd__Date.TabIndex = 16;
            // 
            // upd__LastName
            // 
            this.upd__LastName.Location = new System.Drawing.Point(151, 144);
            this.upd__LastName.Name = "upd__LastName";
            this.upd__LastName.Size = new System.Drawing.Size(293, 23);
            this.upd__LastName.TabIndex = 15;
            // 
            // upd__Name
            // 
            this.upd__Name.Location = new System.Drawing.Point(151, 111);
            this.upd__Name.Name = "upd__Name";
            this.upd__Name.Size = new System.Drawing.Size(293, 23);
            this.upd__Name.TabIndex = 14;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.upd__Date);
            this.Controls.Add(this.upd__LastName);
            this.Controls.Add(this.upd__Name);
            this.Controls.Add(this.upd_Telephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateButton";
            this.Text = "UpdateButton";
            this.Load += new System.EventHandler(this.UpdateButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker upd__Date;
        private System.Windows.Forms.TextBox upd__LastName;
        private System.Windows.Forms.TextBox upd__Name;
        private System.Windows.Forms.TextBox upd_Telephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}