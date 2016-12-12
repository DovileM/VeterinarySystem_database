namespace VeterinarySystem
{
    partial class OnceInformationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnceInformationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.ComboBox();
            this.chooseVetLabel = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.startedAt = new System.Windows.Forms.Label();
            this.animals = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.Label();
            this.sNameText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.pCodeText = new System.Windows.Forms.Label();
            this.started_animalTypeText = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.seeAllAnimals = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.animalComboBox = new System.Windows.Forms.ComboBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.animalsCount = new System.Windows.Forms.Label();
            this.allOwnerAnimals = new System.Windows.Forms.Button();
            this.chooseVet = new System.Windows.Forms.ComboBox();
            this.animalType = new System.Windows.Forms.Label();
            this.pCodeLabel = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 0;
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "Vet",
            "Owner"});
            this.choose.Location = new System.Drawing.Point(70, 67);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(247, 28);
            this.choose.TabIndex = 1;
            this.choose.Text = "Choose information type";
            this.choose.SelectedIndexChanged += new System.EventHandler(this.choose_SelectedIndexChanged);
            // 
            // chooseVetLabel
            // 
            this.chooseVetLabel.AutoSize = true;
            this.chooseVetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseVetLabel.Location = new System.Drawing.Point(67, 98);
            this.chooseVetLabel.Name = "chooseVetLabel";
            this.chooseVetLabel.Size = new System.Drawing.Size(90, 16);
            this.chooseVetLabel.TabIndex = 4;
            this.chooseVetLabel.Text = "Choose a vet:";
            this.chooseVetLabel.Visible = false;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(67, 159);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(73, 16);
            this.fName.TabIndex = 5;
            this.fName.Text = "First name:";
            this.fName.Visible = false;
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(67, 185);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(95, 16);
            this.sName.TabIndex = 6;
            this.sName.Text = "Second name:";
            this.sName.Visible = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(67, 210);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(74, 16);
            this.phone.TabIndex = 11;
            this.phone.Text = "Phone No.:";
            this.phone.Visible = false;
            // 
            // startedAt
            // 
            this.startedAt.AutoSize = true;
            this.startedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedAt.Location = new System.Drawing.Point(68, 290);
            this.startedAt.Name = "startedAt";
            this.startedAt.Size = new System.Drawing.Size(99, 16);
            this.startedAt.TabIndex = 12;
            this.startedAt.Text = "Started work at:";
            this.startedAt.Visible = false;
            // 
            // animals
            // 
            this.animals.AutoSize = true;
            this.animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals.Location = new System.Drawing.Point(67, 261);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(111, 16);
            this.animals.TabIndex = 13;
            this.animals.Text = "Treating animals:";
            this.animals.Visible = false;
            // 
            // fNameText
            // 
            this.fNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameText.Location = new System.Drawing.Point(182, 156);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(134, 19);
            this.fNameText.TabIndex = 15;
            this.fNameText.Visible = false;
            // 
            // sNameText
            // 
            this.sNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameText.Location = new System.Drawing.Point(182, 182);
            this.sNameText.Name = "sNameText";
            this.sNameText.Size = new System.Drawing.Size(134, 19);
            this.sNameText.TabIndex = 16;
            this.sNameText.Visible = false;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(182, 207);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(134, 19);
            this.phoneText.TabIndex = 17;
            this.phoneText.Visible = false;
            // 
            // pCodeText
            // 
            this.pCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeText.Location = new System.Drawing.Point(182, 232);
            this.pCodeText.Name = "pCodeText";
            this.pCodeText.Size = new System.Drawing.Size(134, 19);
            this.pCodeText.TabIndex = 18;
            this.pCodeText.Visible = false;
            // 
            // started_animalTypeText
            // 
            this.started_animalTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.started_animalTypeText.Location = new System.Drawing.Point(182, 287);
            this.started_animalTypeText.Name = "started_animalTypeText";
            this.started_animalTypeText.Size = new System.Drawing.Size(135, 19);
            this.started_animalTypeText.TabIndex = 19;
            this.started_animalTypeText.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(153, 376);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 21;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // seeAllAnimals
            // 
            this.seeAllAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllAnimals.Location = new System.Drawing.Point(70, 329);
            this.seeAllAnimals.Name = "seeAllAnimals";
            this.seeAllAnimals.Size = new System.Drawing.Size(246, 30);
            this.seeAllAnimals.TabIndex = 22;
            this.seeAllAnimals.Text = "See all treating animals info";
            this.seeAllAnimals.UseVisualStyleBackColor = true;
            this.seeAllAnimals.Visible = false;
            this.seeAllAnimals.Click += new System.EventHandler(this.seeAllAnimals_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(68, 98);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(122, 16);
            this.chooseLabel.TabIndex = 23;
            this.chooseLabel.Text = "Choose the animal:";
            this.chooseLabel.Visible = false;
            // 
            // animalComboBox
            // 
            this.animalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.animalComboBox.FormattingEnabled = true;
            this.animalComboBox.Location = new System.Drawing.Point(71, 117);
            this.animalComboBox.Name = "animalComboBox";
            this.animalComboBox.Size = new System.Drawing.Size(246, 28);
            this.animalComboBox.TabIndex = 26;
            this.animalComboBox.Text = "Choose the animal";
            this.animalComboBox.Visible = false;
            this.animalComboBox.SelectedIndexChanged += new System.EventHandler(this.animalComboBox_SelectedIndexChanged);
            // 
            // backLabel
            // 
            this.backLabel.Image = ((System.Drawing.Image)(resources.GetObject("backLabel.Image")));
            this.backLabel.Location = new System.Drawing.Point(12, 98);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(329, 259);
            this.backLabel.TabIndex = 27;
            // 
            // animalsCount
            // 
            this.animalsCount.AutoSize = true;
            this.animalsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalsCount.Location = new System.Drawing.Point(67, 261);
            this.animalsCount.Name = "animalsCount";
            this.animalsCount.Size = new System.Drawing.Size(59, 16);
            this.animalsCount.TabIndex = 28;
            this.animalsCount.Text = "Animals:";
            this.animalsCount.Visible = false;
            // 
            // allOwnerAnimals
            // 
            this.allOwnerAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOwnerAnimals.Location = new System.Drawing.Point(71, 329);
            this.allOwnerAnimals.Name = "allOwnerAnimals";
            this.allOwnerAnimals.Size = new System.Drawing.Size(246, 30);
            this.allOwnerAnimals.TabIndex = 29;
            this.allOwnerAnimals.Text = "See all owner\'s animals\' info";
            this.allOwnerAnimals.UseVisualStyleBackColor = true;
            this.allOwnerAnimals.Visible = false;
            this.allOwnerAnimals.Click += new System.EventHandler(this.allOwnerAnimals_Click);
            // 
            // chooseVet
            // 
            this.chooseVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseVet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chooseVet.FormattingEnabled = true;
            this.chooseVet.Location = new System.Drawing.Point(70, 117);
            this.chooseVet.Name = "chooseVet";
            this.chooseVet.Size = new System.Drawing.Size(246, 28);
            this.chooseVet.TabIndex = 30;
            this.chooseVet.Text = "Choose a vet";
            this.chooseVet.Visible = false;
            this.chooseVet.SelectedIndexChanged += new System.EventHandler(this.chooseVet_SelectedIndexChanged);
            // 
            // animalType
            // 
            this.animalType.AutoSize = true;
            this.animalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalType.Location = new System.Drawing.Point(68, 290);
            this.animalType.Name = "animalType";
            this.animalType.Size = new System.Drawing.Size(81, 16);
            this.animalType.TabIndex = 31;
            this.animalType.Text = "Animal type:";
            this.animalType.Visible = false;
            // 
            // pCodeLabel
            // 
            this.pCodeLabel.AutoSize = true;
            this.pCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeLabel.Location = new System.Drawing.Point(68, 235);
            this.pCodeLabel.Name = "pCodeLabel";
            this.pCodeLabel.Size = new System.Drawing.Size(99, 16);
            this.pCodeLabel.TabIndex = 33;
            this.pCodeLabel.Text = "Personal code:";
            this.pCodeLabel.Visible = false;
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(184, 261);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(135, 19);
            this.count.TabIndex = 34;
            this.count.Visible = false;
            // 
            // ClinicOnceInformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(366, 418);
            this.Controls.Add(this.count);
            this.Controls.Add(this.pCodeLabel);
            this.Controls.Add(this.animalType);
            this.Controls.Add(this.chooseVet);
            this.Controls.Add(this.allOwnerAnimals);
            this.Controls.Add(this.animalsCount);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.animalComboBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.seeAllAnimals);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.started_animalTypeText);
            this.Controls.Add(this.pCodeText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.sNameText);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.startedAt);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.chooseVetLabel);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label1);
            this.Name = "ClinicOnceInformationWindow";
            this.Text = "ClinicInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.Label chooseVetLabel;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label startedAt;
        private System.Windows.Forms.Label animals;
        private System.Windows.Forms.Label fNameText;
        private System.Windows.Forms.Label sNameText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label pCodeText;
        private System.Windows.Forms.Label started_animalTypeText;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button seeAllAnimals;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox animalComboBox;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label animalsCount;
        private System.Windows.Forms.Button allOwnerAnimals;
        private System.Windows.Forms.ComboBox chooseVet;
        private System.Windows.Forms.Label animalType;
        private System.Windows.Forms.Label pCodeLabel;
        private System.Windows.Forms.Label count;
    }
}