namespace VeterinarySystem
{
    partial class SignUpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pCodeLabel = new System.Windows.Forms.Label();
            this.clinic_pCodeTextBox = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.city_sNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.clinicNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.phoneClinicLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.noLabel = new System.Windows.Forms.Label();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.clinicLabel = new System.Windows.Forms.Label();
            this.owner2Label = new System.Windows.Forms.Label();
            this.clinic2Label = new System.Windows.Forms.Label();
            this.phoneOwnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 88);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign Up as:";
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "Šeimininkas",
            "Veterinarijos klinika"});
            this.choose.Location = new System.Drawing.Point(240, 100);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(156, 28);
            this.choose.TabIndex = 2;
            this.choose.Text = "Šeimininkas";
            this.choose.SelectedIndexChanged += new System.EventHandler(this.choose_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // pCodeLabel
            // 
            this.pCodeLabel.AutoSize = true;
            this.pCodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeLabel.Location = new System.Drawing.Point(125, 138);
            this.pCodeLabel.Name = "pCodeLabel";
            this.pCodeLabel.Size = new System.Drawing.Size(114, 18);
            this.pCodeLabel.TabIndex = 4;
            this.pCodeLabel.Text = "*Personal code:";
            // 
            // clinic_pCodeTextBox
            // 
            this.clinic_pCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic_pCodeTextBox.Location = new System.Drawing.Point(239, 134);
            this.clinic_pCodeTextBox.Name = "clinic_pCodeTextBox";
            this.clinic_pCodeTextBox.Size = new System.Drawing.Size(157, 26);
            this.clinic_pCodeTextBox.TabIndex = 5;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(125, 170);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(88, 18);
            this.fNameLabel.TabIndex = 6;
            this.fNameLabel.Text = "*First name:";
            // 
            // city_sNameTextBox
            // 
            this.city_sNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_sNameTextBox.Location = new System.Drawing.Point(239, 166);
            this.city_sNameTextBox.Name = "city_sNameTextBox";
            this.city_sNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.city_sNameTextBox.TabIndex = 7;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameTextBox.Location = new System.Drawing.Point(240, 198);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.sNameTextBox.TabIndex = 8;
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameLabel.Location = new System.Drawing.Point(125, 202);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(87, 18);
            this.sNameLabel.TabIndex = 9;
            this.sNameLabel.Text = "*Last name:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(240, 231);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(157, 26);
            this.phoneTextBox.TabIndex = 11;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Control;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(159, 350);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 30);
            this.ok.TabIndex = 12;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(286, 350);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 13;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "* Required fields";
            this.label8.UseMnemonic = false;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerLabel.Location = new System.Drawing.Point(125, 291);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(178, 15);
            this.ownerLabel.TabIndex = 15;
            this.ownerLabel.Text = "\'First name\' will be a username";
            this.ownerLabel.UseMnemonic = false;
            // 
            // clinicNameLabel
            // 
            this.clinicNameLabel.AutoSize = true;
            this.clinicNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clinicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicNameLabel.Location = new System.Drawing.Point(125, 138);
            this.clinicNameLabel.Name = "clinicNameLabel";
            this.clinicNameLabel.Size = new System.Drawing.Size(95, 18);
            this.clinicNameLabel.TabIndex = 16;
            this.clinicNameLabel.Text = "*Clinic name:";
            this.clinicNameLabel.Visible = false;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(125, 170);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(43, 18);
            this.cityLabel.TabIndex = 17;
            this.cityLabel.Text = "*City:";
            this.cityLabel.Visible = false;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.Location = new System.Drawing.Point(125, 202);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(57, 18);
            this.streetLabel.TabIndex = 18;
            this.streetLabel.Text = "*Street:";
            this.streetLabel.Visible = false;
            // 
            // phoneClinicLabel
            // 
            this.phoneClinicLabel.AutoSize = true;
            this.phoneClinicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.phoneClinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneClinicLabel.Location = new System.Drawing.Point(125, 235);
            this.phoneClinicLabel.Name = "phoneClinicLabel";
            this.phoneClinicLabel.Size = new System.Drawing.Size(86, 18);
            this.phoneClinicLabel.TabIndex = 19;
            this.phoneClinicLabel.Text = "*Phone no.:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(239, 198);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(85, 26);
            this.streetTextBox.TabIndex = 20;
            this.streetTextBox.Visible = false;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.Location = new System.Drawing.Point(324, 202);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(42, 18);
            this.noLabel.TabIndex = 21;
            this.noLabel.Text = "*No.:";
            this.noLabel.Visible = false;
            // 
            // noTextBox
            // 
            this.noTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTextBox.Location = new System.Drawing.Point(366, 198);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(31, 26);
            this.noTextBox.TabIndex = 22;
            this.noTextBox.Visible = false;
            // 
            // clinicLabel
            // 
            this.clinicLabel.AutoSize = true;
            this.clinicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicLabel.Location = new System.Drawing.Point(127, 291);
            this.clinicLabel.Name = "clinicLabel";
            this.clinicLabel.Size = new System.Drawing.Size(185, 15);
            this.clinicLabel.TabIndex = 23;
            this.clinicLabel.Text = "\'Clinic name\' will be a username";
            this.clinicLabel.UseMnemonic = false;
            this.clinicLabel.Visible = false;
            // 
            // owner2Label
            // 
            this.owner2Label.AutoSize = true;
            this.owner2Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.owner2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner2Label.Location = new System.Drawing.Point(125, 306);
            this.owner2Label.Name = "owner2Label";
            this.owner2Label.Size = new System.Drawing.Size(194, 15);
            this.owner2Label.TabIndex = 24;
            this.owner2Label.Text = "\'Second name\' will be a password";
            this.owner2Label.UseMnemonic = false;
            this.owner2Label.Visible = false;
            // 
            // clinic2Label
            // 
            this.clinic2Label.AutoSize = true;
            this.clinic2Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clinic2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic2Label.Location = new System.Drawing.Point(127, 306);
            this.clinic2Label.Name = "clinic2Label";
            this.clinic2Label.Size = new System.Drawing.Size(136, 15);
            this.clinic2Label.TabIndex = 25;
            this.clinic2Label.Text = "\'City\' will be a password";
            this.clinic2Label.UseMnemonic = false;
            this.clinic2Label.Visible = false;
            // 
            // phoneOwnerLabel
            // 
            this.phoneOwnerLabel.AutoSize = true;
            this.phoneOwnerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.phoneOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneOwnerLabel.Location = new System.Drawing.Point(127, 235);
            this.phoneOwnerLabel.Name = "phoneOwnerLabel";
            this.phoneOwnerLabel.Size = new System.Drawing.Size(80, 18);
            this.phoneOwnerLabel.TabIndex = 26;
            this.phoneOwnerLabel.Text = "Phone no.:";
            // 
            // SignUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(516, 392);
            this.Controls.Add(this.phoneOwnerLabel);
            this.Controls.Add(this.clinic2Label);
            this.Controls.Add(this.owner2Label);
            this.Controls.Add(this.clinicLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.phoneClinicLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.clinicNameLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(this.city_sNameTextBox);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.clinic_pCodeTextBox);
            this.Controls.Add(this.pCodeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpWindow";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.SignUpWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pCodeLabel;
        private System.Windows.Forms.TextBox clinic_pCodeTextBox;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox city_sNameTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label clinicNameLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label phoneClinicLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.Label clinicLabel;
        private System.Windows.Forms.Label owner2Label;
        private System.Windows.Forms.Label clinic2Label;
        private System.Windows.Forms.Label phoneOwnerLabel;
    }
}