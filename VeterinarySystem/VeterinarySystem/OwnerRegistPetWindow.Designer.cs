namespace VeterinarySystem
{
    partial class OwnerRegistPetWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerRegistPetWindow));
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.choosePet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.chooseVet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseClinic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vetsInfoButton = new System.Windows.Forms.Button();
            this.clinicInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(150, 185);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(264, 26);
            this.startDate.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Treatement start:";
            // 
            // choosePet
            // 
            this.choosePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePet.FormattingEnabled = true;
            this.choosePet.Location = new System.Drawing.Point(206, 37);
            this.choosePet.Name = "choosePet";
            this.choosePet.Size = new System.Drawing.Size(208, 28);
            this.choosePet.TabIndex = 28;
            this.choosePet.Text = "Pets";
            this.choosePet.SelectedIndexChanged += new System.EventHandler(this.choosePet_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Choose pet:";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(259, 240);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 26;
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Control;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(121, 240);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 30);
            this.ok.TabIndex = 25;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // chooseVet
            // 
            this.chooseVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseVet.FormattingEnabled = true;
            this.chooseVet.Location = new System.Drawing.Point(209, 141);
            this.chooseVet.Name = "chooseVet";
            this.chooseVet.Size = new System.Drawing.Size(205, 28);
            this.chooseVet.TabIndex = 24;
            this.chooseVet.Text = "Vets";
            this.chooseVet.SelectedIndexChanged += new System.EventHandler(this.chooseVet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Choose vet:";
            // 
            // chooseClinic
            // 
            this.chooseClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseClinic.FormattingEnabled = true;
            this.chooseClinic.Location = new System.Drawing.Point(206, 87);
            this.chooseClinic.Name = "chooseClinic";
            this.chooseClinic.Size = new System.Drawing.Size(208, 28);
            this.chooseClinic.TabIndex = 22;
            this.chooseClinic.Text = "Clinics";
            this.chooseClinic.SelectedIndexChanged += new System.EventHandler(this.chooseClinic_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choose clinic:";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 145);
            this.label1.TabIndex = 20;
            // 
            // vetsInfoButton
            // 
            this.vetsInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("vetsInfoButton.Image")));
            this.vetsInfoButton.Location = new System.Drawing.Point(421, 137);
            this.vetsInfoButton.Name = "vetsInfoButton";
            this.vetsInfoButton.Size = new System.Drawing.Size(44, 37);
            this.vetsInfoButton.TabIndex = 31;
            this.vetsInfoButton.UseVisualStyleBackColor = true;
            this.vetsInfoButton.Click += new System.EventHandler(this.vetsInfoButton_Click);
            // 
            // clinicInfoButton
            // 
            this.clinicInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("clinicInfoButton.Image")));
            this.clinicInfoButton.Location = new System.Drawing.Point(420, 83);
            this.clinicInfoButton.Name = "clinicInfoButton";
            this.clinicInfoButton.Size = new System.Drawing.Size(44, 37);
            this.clinicInfoButton.TabIndex = 32;
            this.clinicInfoButton.UseVisualStyleBackColor = true;
            this.clinicInfoButton.Click += new System.EventHandler(this.clinicInfoButton_Click);
            // 
            // OwnerRegistPetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(477, 282);
            this.Controls.Add(this.clinicInfoButton);
            this.Controls.Add(this.vetsInfoButton);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.choosePet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.chooseVet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseClinic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OwnerRegistPetWindow";
            this.Text = "OwnerRegistPetWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choosePet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox chooseVet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chooseClinic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vetsInfoButton;
        private System.Windows.Forms.Button clinicInfoButton;
    }
}