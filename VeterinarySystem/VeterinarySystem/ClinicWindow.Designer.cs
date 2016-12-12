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
            this.allInformation = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.onceInformation = new System.Windows.Forms.Button();
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
            this.insertNewVet.Click += new System.EventHandler(this.insertNewVet_Click);
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
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // allInformation
            // 
            this.allInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allInformation.Location = new System.Drawing.Point(203, 162);
            this.allInformation.Name = "allInformation";
            this.allInformation.Size = new System.Drawing.Size(172, 27);
            this.allInformation.TabIndex = 5;
            this.allInformation.Text = "All information";
            this.allInformation.UseVisualStyleBackColor = true;
            this.allInformation.Click += new System.EventHandler(this.allInformation_Click);
            // 
            // logout
            // 
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(289, 239);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 41);
            this.logout.TabIndex = 6;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // onceInformation
            // 
            this.onceInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onceInformation.Location = new System.Drawing.Point(203, 129);
            this.onceInformation.Name = "onceInformation";
            this.onceInformation.Size = new System.Drawing.Size(172, 27);
            this.onceInformation.TabIndex = 7;
            this.onceInformation.Text = "Once information";
            this.onceInformation.UseVisualStyleBackColor = true;
            this.onceInformation.Click += new System.EventHandler(this.onceInformation_Click);
            // 
            // ClinicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.onceInformation);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.allInformation);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.insertNewVet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClinicWindow";
            this.Text = "Clinic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insertNewVet;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button allInformation;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button onceInformation;
    }
}