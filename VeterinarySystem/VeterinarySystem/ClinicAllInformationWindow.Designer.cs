namespace VeterinarySystem
{
    partial class ClinicAllInformationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicAllInformationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.seeLabel = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.top5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(264, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 97);
            this.label1.TabIndex = 0;
            // 
            // seeLabel
            // 
            this.seeLabel.AutoSize = true;
            this.seeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeLabel.Location = new System.Drawing.Point(103, 98);
            this.seeLabel.Name = "seeLabel";
            this.seeLabel.Size = new System.Drawing.Size(158, 16);
            this.seeLabel.TabIndex = 1;
            this.seeLabel.Text = "See all information about:";
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "Vets",
            "Owners",
            "Pets"});
            this.choose.Location = new System.Drawing.Point(267, 92);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(194, 28);
            this.choose.TabIndex = 2;
            this.choose.Text = "Choose";
            this.choose.SelectedIndexChanged += new System.EventHandler(this.choose_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(314, 346);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 22;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Location = new System.Drawing.Point(21, 128);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(658, 212);
            this.tableDataGridView.TabIndex = 23;
            // 
            // top5
            // 
            this.top5.AutoSize = true;
            this.top5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5.Location = new System.Drawing.Point(519, 102);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(59, 20);
            this.top5.TabIndex = 24;
            this.top5.Text = "Top5";
            this.top5.UseVisualStyleBackColor = true;
            this.top5.Visible = false;
            this.top5.CheckedChanged += new System.EventHandler(this.top5_CheckedChanged);
            // 
            // ClinicAllInformationWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(709, 388);
            this.Controls.Add(this.top5);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.seeLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClinicAllInformationWindow";
            this.Text = "Clinic information";
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seeLabel;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.CheckBox top5;
    }
}