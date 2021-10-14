
namespace CheckIDNo
{
    partial class Form
    {
      

        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.Label_ID_Number = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.BirthDay = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.txtIDNumber);
            this.groupBox1.Controls.Add(this.Label_ID_Number);
            this.groupBox1.Controls.Add(this.labelBirthDay);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.BirthDay);
            this.groupBox1.Controls.Add(this.LabelSurname);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.txtİsim);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(9, 210);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(367, 22);
            this.txtBirthday.TabIndex = 7;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(9, 58);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(367, 22);
            this.txtIDNumber.TabIndex = 6;
            // 
            // Label_ID_Number
            // 
            this.Label_ID_Number.AutoSize = true;
            this.Label_ID_Number.Location = new System.Drawing.Point(6, 38);
            this.Label_ID_Number.Name = "Label_ID_Number";
            this.Label_ID_Number.Size = new System.Drawing.Size(79, 17);
            this.Label_ID_Number.TabIndex = 5;
            this.Label_ID_Number.Text = "ID_Number";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(6, 189);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(62, 17);
            this.labelBirthDay.TabIndex = 4;
            this.labelBirthDay.Text = "BirthDay";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(9, 160);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(367, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(6, 189);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(62, 17);
            this.BirthDay.TabIndex = 4;
            this.BirthDay.Text = "BirthDay";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(6, 140);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(65, 17);
            this.LabelSurname.TabIndex = 2;
            this.LabelSurname.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(6, 139);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(9, 105);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(367, 22);
            this.txtİsim.TabIndex = 1;
          //  this.txtİsim.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 22);
            this.textBox1.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(6, 84);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 83);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckButton);
            this.groupBox2.Location = new System.Drawing.Point(403, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(34, 38);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(150, 39);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
         //   this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TcKimlikNoDogrulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label Label_ID_Number;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelName;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox txtBirthday;
    }
}

