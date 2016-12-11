namespace VeterinarySystem
{
    partial class OwnerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.seePetInfo = new System.Windows.Forms.Button();
            this.seeVetInfo = new System.Windows.Forms.Button();
            this.seeClinicInfo = new System.Windows.Forms.Button();
            this.insertNewPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 290);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(118, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 60);
            this.label2.TabIndex = 3;
            // 
            // logout
            // 
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(252, 296);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 41);
            this.logout.TabIndex = 8;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // editProfile
            // 
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(160, 95);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(178, 27);
            this.editProfile.TabIndex = 9;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.UseVisualStyleBackColor = true;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // seePetInfo
            // 
            this.seePetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seePetInfo.Location = new System.Drawing.Point(160, 164);
            this.seePetInfo.Name = "seePetInfo";
            this.seePetInfo.Size = new System.Drawing.Size(178, 27);
            this.seePetInfo.TabIndex = 10;
            this.seePetInfo.Text = "Pets\' information";
            this.seePetInfo.UseVisualStyleBackColor = true;
            this.seePetInfo.Click += new System.EventHandler(this.seePetInfo_Click);
            // 
            // seeVetInfo
            // 
            this.seeVetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeVetInfo.Location = new System.Drawing.Point(160, 197);
            this.seeVetInfo.Name = "seeVetInfo";
            this.seeVetInfo.Size = new System.Drawing.Size(178, 27);
            this.seeVetInfo.TabIndex = 11;
            this.seeVetInfo.Text = "Vet\'s information";
            this.seeVetInfo.UseVisualStyleBackColor = true;
            // 
            // seeClinicInfo
            // 
            this.seeClinicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeClinicInfo.Location = new System.Drawing.Point(160, 230);
            this.seeClinicInfo.Name = "seeClinicInfo";
            this.seeClinicInfo.Size = new System.Drawing.Size(178, 27);
            this.seeClinicInfo.TabIndex = 12;
            this.seeClinicInfo.Text = "Clinic information";
            this.seeClinicInfo.UseVisualStyleBackColor = true;
            this.seeClinicInfo.Click += new System.EventHandler(this.seeClinicInfo_Click);
            // 
            // insertNewPet
            // 
            this.insertNewPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNewPet.Location = new System.Drawing.Point(160, 131);
            this.insertNewPet.Name = "insertNewPet";
            this.insertNewPet.Size = new System.Drawing.Size(178, 27);
            this.insertNewPet.TabIndex = 13;
            this.insertNewPet.Text = "New pet";
            this.insertNewPet.UseVisualStyleBackColor = true;
            this.insertNewPet.Click += new System.EventHandler(this.insertNewPet_Click);
            // 
            // OwnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(356, 351);
            this.Controls.Add(this.insertNewPet);
            this.Controls.Add(this.seeClinicInfo);
            this.Controls.Add(this.seeVetInfo);
            this.Controls.Add(this.seePetInfo);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OwnerWindow";
            this.Text = "Owner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button seePetInfo;
        private System.Windows.Forms.Button seeVetInfo;
        private System.Windows.Forms.Button seeClinicInfo;
        private System.Windows.Forms.Button insertNewPet;
    }
}