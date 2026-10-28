namespace Bai4._2
{
    partial class Form1
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
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblCourse = new Label();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            rdoMale = new RadioButton();
            rdoNu = new RadioButton();
            tienganh = new CheckBox();
            laptrinh = new CheckBox();
            thietke = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(46, 40);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(36, 20);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "SĐT";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(46, 107);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(41, 20);
            lblBirthDate.TabIndex = 1;
            lblBirthDate.Text = "ngay";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(46, 173);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(69, 20);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "khoa hoc";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(117, 40);
            mtxtPhone.Margin = new Padding(3, 4, 3, 4);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(228, 27);
            mtxtPhone.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(117, 107);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(228, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(117, 170);
            cboCourse.Margin = new Padding(3, 4, 3, 4);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(228, 28);
            cboCourse.TabIndex = 5;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(117, 216);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 6;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(117, 260);
            rdoNu.Margin = new Padding(3, 4, 3, 4);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(49, 24);
            rdoNu.TabIndex = 7;
            rdoNu.Text = "Nu";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // tienganh
            // 
            tienganh.AutoSize = true;
            tienganh.Location = new Point(366, 40);
            tienganh.Margin = new Padding(3, 4, 3, 4);
            tienganh.Name = "tienganh";
            tienganh.Size = new Size(94, 24);
            tienganh.TabIndex = 8;
            tienganh.Text = "tieng nga";
            tienganh.UseVisualStyleBackColor = true;
            tienganh.CheckedChanged += tienganh_CheckedChanged;
            // 
            // laptrinh
            // 
            laptrinh.AutoSize = true;
            laptrinh.Location = new Point(366, 72);
            laptrinh.Margin = new Padding(3, 4, 3, 4);
            laptrinh.Name = "laptrinh";
            laptrinh.Size = new Size(93, 24);
            laptrinh.TabIndex = 9;
            laptrinh.Text = "tieng anh";
            laptrinh.UseVisualStyleBackColor = true;
            // 
            // thietke
            // 
            thietke.AutoSize = true;
            thietke.Location = new Point(366, 103);
            thietke.Margin = new Padding(3, 4, 3, 4);
            thietke.Name = "thietke";
            thietke.Size = new Size(103, 24);
            thietke.TabIndex = 10;
            thietke.Text = "tieng phap";
            thietke.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(280, 230);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 40);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "dang ki";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 440);
            Controls.Add(btnRegister);
            Controls.Add(thietke);
            Controls.Add(laptrinh);
            Controls.Add(tienganh);
            Controls.Add(rdoNu);
            Controls.Add(rdoMale);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Controls.Add(lblCourse);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhone);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox tienganh;
        private System.Windows.Forms.CheckBox laptrinh;
        private System.Windows.Forms.CheckBox thietke;
        private System.Windows.Forms.Button btnRegister;
    }
}