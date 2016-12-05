namespace VeterinarySystem
{
    partial class ClinicWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insertNewVet = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 290);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 60);
            this.label2.TabIndex = 1;
            // 
            // insertNewVet
            // 
            this.insertNewVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNewVet.Location = new System.Drawing.Point(203, 195);
            this.insertNewVet.Name = "insertNewVet";
            this.insertNewVet.Size = new System.Drawing.Size(172, 25);
            this.insertNewVet.TabIndex = 2;
            this.insertNewVet.Text = "New Vet";
            this.insertNewVet.UseVisualStyleBackColor = true;
            // 
            // editProfile
            // 
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(203, 96);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(172, 27);
            this.editProfile.TabIndex = 4;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.UseVisualStyleBackColor = true;
            this.editProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // information
            // 
            this.information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information.Location = new System.Drawing.Point(203, 162);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(172, 27);
            this.information.TabIndex = 5;
            this.information.Text = "All information";
            this.information.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(289, 239);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 41);
            this.logout.TabIndex = 6;
            this.logout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Once information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Clinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.information);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.insertNewVet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clinic";
            this.Text = "Clinic";
            this.Load += new System.EventHandler(this.Clinic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertNewVet;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
    }
}