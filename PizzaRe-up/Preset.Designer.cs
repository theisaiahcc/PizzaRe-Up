namespace PizzaRe_up
{
    partial class Preset
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
            this.grpSpecial = new System.Windows.Forms.GroupBox();
            this.radSupreme = new System.Windows.Forms.RadioButton();
            this.radVegan = new System.Windows.Forms.RadioButton();
            this.radMemphisChicken = new System.Windows.Forms.RadioButton();
            this.radHawaiian = new System.Windows.Forms.RadioButton();
            this.radMeatLover = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpSpecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSpecial
            // 
            this.grpSpecial.Controls.Add(this.radSupreme);
            this.grpSpecial.Controls.Add(this.radVegan);
            this.grpSpecial.Controls.Add(this.radMemphisChicken);
            this.grpSpecial.Controls.Add(this.radHawaiian);
            this.grpSpecial.Controls.Add(this.radMeatLover);
            this.grpSpecial.Location = new System.Drawing.Point(12, 12);
            this.grpSpecial.Name = "grpSpecial";
            this.grpSpecial.Size = new System.Drawing.Size(129, 136);
            this.grpSpecial.TabIndex = 0;
            this.grpSpecial.TabStop = false;
            this.grpSpecial.Text = "SpecialtyPizzas";
            // 
            // radSupreme
            // 
            this.radSupreme.AutoSize = true;
            this.radSupreme.Location = new System.Drawing.Point(3, 111);
            this.radSupreme.Name = "radSupreme";
            this.radSupreme.Size = new System.Drawing.Size(72, 19);
            this.radSupreme.TabIndex = 4;
            this.radSupreme.TabStop = true;
            this.radSupreme.Text = "Supreme";
            this.radSupreme.UseVisualStyleBackColor = true;
            this.radSupreme.CheckedChanged += new System.EventHandler(this.radSupreme_CheckedChanged);
            // 
            // radVegan
            // 
            this.radVegan.AutoSize = true;
            this.radVegan.Location = new System.Drawing.Point(3, 88);
            this.radVegan.Name = "radVegan";
            this.radVegan.Size = new System.Drawing.Size(57, 19);
            this.radVegan.TabIndex = 3;
            this.radVegan.TabStop = true;
            this.radVegan.Text = "Vegan";
            this.radVegan.UseVisualStyleBackColor = true;
            this.radVegan.CheckedChanged += new System.EventHandler(this.radVegan_CheckedChanged);
            // 
            // radMemphisChicken
            // 
            this.radMemphisChicken.AutoSize = true;
            this.radMemphisChicken.Location = new System.Drawing.Point(3, 65);
            this.radMemphisChicken.Name = "radMemphisChicken";
            this.radMemphisChicken.Size = new System.Drawing.Size(121, 19);
            this.radMemphisChicken.TabIndex = 2;
            this.radMemphisChicken.TabStop = true;
            this.radMemphisChicken.Text = "Memphis Chicken";
            this.radMemphisChicken.UseVisualStyleBackColor = true;
            this.radMemphisChicken.CheckedChanged += new System.EventHandler(this.radMemphisChicken_CheckedChanged);
            // 
            // radHawaiian
            // 
            this.radHawaiian.AutoSize = true;
            this.radHawaiian.Location = new System.Drawing.Point(3, 42);
            this.radHawaiian.Name = "radHawaiian";
            this.radHawaiian.Size = new System.Drawing.Size(77, 19);
            this.radHawaiian.TabIndex = 1;
            this.radHawaiian.TabStop = true;
            this.radHawaiian.Text = "Hawaiian ";
            this.radHawaiian.UseVisualStyleBackColor = true;
            this.radHawaiian.CheckedChanged += new System.EventHandler(this.radHawaiian_CheckedChanged);
            // 
            // radMeatLover
            // 
            this.radMeatLover.AutoSize = true;
            this.radMeatLover.Location = new System.Drawing.Point(3, 19);
            this.radMeatLover.Name = "radMeatLover";
            this.radMeatLover.Size = new System.Drawing.Size(84, 19);
            this.radMeatLover.TabIndex = 0;
            this.radMeatLover.TabStop = true;
            this.radMeatLover.Text = "Meat Lover";
            this.radMeatLover.UseVisualStyleBackColor = true;
            this.radMeatLover.CheckedChanged += new System.EventHandler(this.radMeatLover_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 209);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 40);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(70, 154);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(146, 23);
            this.txtDescription.TabIndex = 0;
            // 
            // Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpSpecial);
            this.Name = "Preset";
            this.Text = "Preset";
            this.grpSpecial.ResumeLayout(false);
            this.grpSpecial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpSpecial;
        private Button btnSelect;
        private Button btnCancel;
        private RadioButton radSupreme;
        private RadioButton radVegan;
        private RadioButton radMemphisChicken;
        private RadioButton radHawaiian;
        private RadioButton radMeatLover;
        private TextBox txtDescription;
    }
}