namespace VeterinarySystem
{
    partial class VetWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.insertNewPatient = new System.Windows.Forms.Button();
            this.editPatient = new System.Windows.Forms.Button();
            this.ownerInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 290);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 60);
            this.label2.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(292, 269);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 41);
            this.logout.TabIndex = 7;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // editProfile
            // 
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(176, 84);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(178, 27);
            this.editProfile.TabIndex = 8;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.UseVisualStyleBackColor = true;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // insertNewPatient
            // 
            this.insertNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNewPatient.Location = new System.Drawing.Point(176, 117);
            this.insertNewPatient.Name = "insertNewPatient";
            this.insertNewPatient.Size = new System.Drawing.Size(178, 27);
            this.insertNewPatient.TabIndex = 9;
            this.insertNewPatient.Text = "New patient";
            this.insertNewPatient.UseVisualStyleBackColor = true;
            // 
            // editPatient
            // 
            this.editPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatient.Location = new System.Drawing.Point(176, 150);
            this.editPatient.Name = "editPatient";
            this.editPatient.Size = new System.Drawing.Size(178, 27);
            this.editPatient.TabIndex = 10;
            this.editPatient.Text = "Edit patient";
            this.editPatient.UseVisualStyleBackColor = true;
            // 
            // ownerInfo
            // 
            this.ownerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerInfo.Location = new System.Drawing.Point(176, 183);
            this.ownerInfo.Name = "ownerInfo";
            this.ownerInfo.Size = new System.Drawing.Size(178, 27);
            this.ownerInfo.TabIndex = 11;
            this.ownerInfo.Text = "Patient\'s owner\'s info";
            this.ownerInfo.UseVisualStyleBackColor = true;
            // 
            // VetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(394, 322);
            this.Controls.Add(this.ownerInfo);
            this.Controls.Add(this.editPatient);
            this.Controls.Add(this.insertNewPatient);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VetWindow";
            this.Text = "Vet";
            this.Load += new System.EventHandler(this.Vet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button insertNewPatient;
        private System.Windows.Forms.Button editPatient;
        private System.Windows.Forms.Button ownerInfo;
    }
}