namespace VeterinarySystem
{
    partial class OwnerNewPetWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerNewPetWindow));
            this.required = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.species = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.petsLabel = new System.Windows.Forms.Label();
            this.choosePet = new System.Windows.Forms.ComboBox();
            this.survive = new System.Windows.Forms.CheckBox();
            this.weightFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // required
            // 
            this.required.AutoSize = true;
            this.required.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.required.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required.Location = new System.Drawing.Point(310, 178);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(98, 15);
            this.required.TabIndex = 60;
            this.required.Text = "* Required fields";
            this.required.UseMnemonic = false;
            // 
            // birth
            // 
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Location = new System.Drawing.Point(67, 233);
            this.birth.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.birth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(238, 22);
            this.birth.TabIndex = 59;
            this.birth.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.birth.ValueChanged += new System.EventHandler(this.birth_ValueChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(230, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 26);
            this.name.TabIndex = 58;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(230, 86);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(178, 26);
            this.type.TabIndex = 57;
            // 
            // species
            // 
            this.species.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.species.Location = new System.Drawing.Point(230, 118);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(178, 26);
            this.species.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Species:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(149, 90);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(50, 18);
            this.typeLabel.TabIndex = 52;
            this.typeLabel.Text = "*Type:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(149, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 18);
            this.nameLabel.TabIndex = 51;
            this.nameLabel.Text = "*Name:";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(230, 149);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(125, 26);
            this.weight.TabIndex = 50;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(249, 321);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 49;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Control;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(99, 321);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 30);
            this.ok.TabIndex = 48;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 155);
            this.label1.TabIndex = 47;
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(67, 193);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(341, 26);
            this.color.TabIndex = 61;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.Location = new System.Drawing.Point(12, 237);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(42, 18);
            this.birthLabel.TabIndex = 62;
            this.birthLabel.Text = "Birth:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(12, 264);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(38, 18);
            this.endLabel.TabIndex = 63;
            this.endLabel.Text = "End:";
            this.endLabel.Visible = false;
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(67, 261);
            this.endDate.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(238, 22);
            this.endDate.TabIndex = 64;
            this.endDate.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.endDate.Visible = false;
            // 
            // petsLabel
            // 
            this.petsLabel.AutoSize = true;
            this.petsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.petsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsLabel.Location = new System.Drawing.Point(154, 24);
            this.petsLabel.Name = "petsLabel";
            this.petsLabel.Size = new System.Drawing.Size(42, 18);
            this.petsLabel.TabIndex = 65;
            this.petsLabel.Text = "Pets:";
            this.petsLabel.Visible = false;
            // 
            // choosePet
            // 
            this.choosePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePet.FormattingEnabled = true;
            this.choosePet.Location = new System.Drawing.Point(230, 20);
            this.choosePet.Name = "choosePet";
            this.choosePet.Size = new System.Drawing.Size(178, 28);
            this.choosePet.TabIndex = 66;
            this.choosePet.Visible = false;
            this.choosePet.SelectedIndexChanged += new System.EventHandler(this.choosePet_SelectedIndexChanged);
            // 
            // survive
            // 
            this.survive.AutoSize = true;
            this.survive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survive.Location = new System.Drawing.Point(311, 265);
            this.survive.Name = "survive";
            this.survive.Size = new System.Drawing.Size(130, 20);
            this.survive.TabIndex = 67;
            this.survive.Text = "Did not survive";
            this.survive.UseVisualStyleBackColor = true;
            this.survive.Visible = false;
            // 
            // weightFormat
            // 
            this.weightFormat.AutoSize = true;
            this.weightFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.weightFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightFormat.ForeColor = System.Drawing.Color.DarkBlue;
            this.weightFormat.Location = new System.Drawing.Point(360, 152);
            this.weightFormat.Name = "weightFormat";
            this.weightFormat.Size = new System.Drawing.Size(48, 20);
            this.weightFormat.TabIndex = 68;
            this.weightFormat.Text = "xx.yyy";
            // 
            // OwnerNewPetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(443, 363);
            this.Controls.Add(this.weightFormat);
            this.Controls.Add(this.survive);
            this.Controls.Add(this.choosePet);
            this.Controls.Add(this.petsLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.color);
            this.Controls.Add(this.required);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.type);
            this.Controls.Add(this.species);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwnerNewPetWindow";
            this.Text = "Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox species;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label petsLabel;
        private System.Windows.Forms.ComboBox choosePet;
        private System.Windows.Forms.CheckBox survive;
        private System.Windows.Forms.Label weightFormat;
    }
}