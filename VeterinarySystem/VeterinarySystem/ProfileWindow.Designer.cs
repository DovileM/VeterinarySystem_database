namespace VeterinarySystem
{
    partial class ProfileWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.clinicLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.noLabel = new System.Windows.Forms.Label();
            this.city_fNameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.pCodeLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.clinic_pCode = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Label();
            this.startedLabel = new System.Windows.Forms.Label();
            this.startedDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 212);
            this.label1.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Control;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(221, 223);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 30);
            this.ok.TabIndex = 13;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(340, 223);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 14;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clinicLabel
            // 
            this.clinicLabel.AutoSize = true;
            this.clinicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicLabel.Location = new System.Drawing.Point(159, 62);
            this.clinicLabel.Name = "clinicLabel";
            this.clinicLabel.Size = new System.Drawing.Size(89, 18);
            this.clinicLabel.TabIndex = 15;
            this.clinicLabel.Text = "Clinic name:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(159, 94);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 18);
            this.cityLabel.TabIndex = 18;
            this.cityLabel.Text = "City:";
            this.cityLabel.Visible = false;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.Location = new System.Drawing.Point(159, 126);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(51, 18);
            this.streetLabel.TabIndex = 19;
            this.streetLabel.Text = "Street:";
            this.streetLabel.Visible = false;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(159, 155);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(80, 18);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone no.:";
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLabel.Location = new System.Drawing.Point(397, 130);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(36, 18);
            this.noLabel.TabIndex = 26;
            this.noLabel.Text = "No.:";
            this.noLabel.Visible = false;
            // 
            // city_fNameTextBox
            // 
            this.city_fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_fNameTextBox.Location = new System.Drawing.Point(252, 90);
            this.city_fNameTextBox.Name = "city_fNameTextBox";
            this.city_fNameTextBox.Size = new System.Drawing.Size(238, 26);
            this.city_fNameTextBox.TabIndex = 28;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(252, 122);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(139, 26);
            this.streetTextBox.TabIndex = 29;
            // 
            // noTextBox
            // 
            this.noTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTextBox.Location = new System.Drawing.Point(439, 122);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(51, 26);
            this.noTextBox.TabIndex = 30;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(252, 151);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(238, 26);
            this.phoneTextBox.TabIndex = 31;
            // 
            // pCodeLabel
            // 
            this.pCodeLabel.AutoSize = true;
            this.pCodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeLabel.Location = new System.Drawing.Point(140, 66);
            this.pCodeLabel.Name = "pCodeLabel";
            this.pCodeLabel.Size = new System.Drawing.Size(108, 18);
            this.pCodeLabel.TabIndex = 32;
            this.pCodeLabel.Text = "Personal code:";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(159, 94);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(82, 18);
            this.fNameLabel.TabIndex = 33;
            this.fNameLabel.Text = "First name:";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameLabel.Location = new System.Drawing.Point(144, 126);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(104, 18);
            this.sNameLabel.TabIndex = 34;
            this.sNameLabel.Text = "Second name:";
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameTextBox.Location = new System.Drawing.Point(252, 122);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(238, 26);
            this.sNameTextBox.TabIndex = 35;
            // 
            // clinic_pCode
            // 
            this.clinic_pCode.AutoSize = true;
            this.clinic_pCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic_pCode.Location = new System.Drawing.Point(254, 58);
            this.clinic_pCode.Name = "clinic_pCode";
            this.clinic_pCode.Size = new System.Drawing.Size(47, 25);
            this.clinic_pCode.TabIndex = 36;
            this.clinic_pCode.Text = "text";
            // 
            // delete
            // 
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(426, 219);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(74, 55);
            this.delete.TabIndex = 37;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // startedLabel
            // 
            this.startedLabel.AutoSize = true;
            this.startedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedLabel.Location = new System.Drawing.Point(140, 186);
            this.startedLabel.Name = "startedLabel";
            this.startedLabel.Size = new System.Drawing.Size(112, 18);
            this.startedLabel.TabIndex = 38;
            this.startedLabel.Text = "Started work at:";
            // 
            // startedDate
            // 
            this.startedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedDate.Location = new System.Drawing.Point(252, 183);
            this.startedDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.startedDate.Name = "startedDate";
            this.startedDate.Size = new System.Drawing.Size(238, 22);
            this.startedDate.TabIndex = 39;
            this.startedDate.Value = new System.DateTime(2016, 12, 12, 0, 0, 0, 0);
            // 
            // ProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(502, 292);
            this.Controls.Add(this.startedDate);
            this.Controls.Add(this.startedLabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clinic_pCode);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.pCodeLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.city_fNameTextBox);
            this.Controls.Add(this.noLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.clinicLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileWindow";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label clinicLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.TextBox city_fNameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label pCodeLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.Label clinic_pCode;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label startedLabel;
        private System.Windows.Forms.DateTimePicker startedDate;
    }
}