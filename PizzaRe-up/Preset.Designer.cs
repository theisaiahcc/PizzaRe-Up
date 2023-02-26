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
            grpSpecial = new GroupBox();
            radSupreme = new RadioButton();
            radVegetarian = new RadioButton();
            radMemphisChicken = new RadioButton();
            radHawaiian = new RadioButton();
            radMeatLover = new RadioButton();
            btnSelect = new Button();
            btnCancel = new Button();
            txtDescription = new TextBox();
            grpSpecial.SuspendLayout();
            SuspendLayout();
            // 
            // grpSpecial
            // 
            grpSpecial.Controls.Add(radSupreme);
            grpSpecial.Controls.Add(radVegetarian);
            grpSpecial.Controls.Add(radMemphisChicken);
            grpSpecial.Controls.Add(radHawaiian);
            grpSpecial.Controls.Add(radMeatLover);
            grpSpecial.Location = new Point(12, 12);
            grpSpecial.Name = "grpSpecial";
            grpSpecial.Size = new Size(129, 136);
            grpSpecial.TabIndex = 0;
            grpSpecial.TabStop = false;
            grpSpecial.Text = "SpecialtyPizzas";
            // 
            // radSupreme
            // 
            radSupreme.AutoSize = true;
            radSupreme.Location = new Point(3, 111);
            radSupreme.Name = "radSupreme";
            radSupreme.Size = new Size(72, 19);
            radSupreme.TabIndex = 4;
            radSupreme.TabStop = true;
            radSupreme.Text = "Supreme";
            radSupreme.UseVisualStyleBackColor = true;
            radSupreme.CheckedChanged += radSupreme_CheckedChanged;
            // 
            // radVegetarian
            // 
            radVegetarian.AutoSize = true;
            radVegetarian.Location = new Point(3, 88);
            radVegetarian.Name = "radVegetarian";
            radVegetarian.Size = new Size(80, 19);
            radVegetarian.TabIndex = 3;
            radVegetarian.TabStop = true;
            radVegetarian.Text = "Vegetarian";
            radVegetarian.UseVisualStyleBackColor = true;
            radVegetarian.CheckedChanged += radVegan_CheckedChanged;
            // 
            // radMemphisChicken
            // 
            radMemphisChicken.AutoSize = true;
            radMemphisChicken.Location = new Point(3, 65);
            radMemphisChicken.Name = "radMemphisChicken";
            radMemphisChicken.Size = new Size(121, 19);
            radMemphisChicken.TabIndex = 2;
            radMemphisChicken.TabStop = true;
            radMemphisChicken.Text = "Memphis Chicken";
            radMemphisChicken.UseVisualStyleBackColor = true;
            radMemphisChicken.CheckedChanged += radMemphisChicken_CheckedChanged;
            // 
            // radHawaiian
            // 
            radHawaiian.AutoSize = true;
            radHawaiian.Location = new Point(3, 42);
            radHawaiian.Name = "radHawaiian";
            radHawaiian.Size = new Size(77, 19);
            radHawaiian.TabIndex = 1;
            radHawaiian.TabStop = true;
            radHawaiian.Text = "Hawaiian ";
            radHawaiian.UseVisualStyleBackColor = true;
            radHawaiian.CheckedChanged += radHawaiian_CheckedChanged;
            // 
            // radMeatLover
            // 
            radMeatLover.AutoSize = true;
            radMeatLover.Location = new Point(3, 19);
            radMeatLover.Name = "radMeatLover";
            radMeatLover.Size = new Size(84, 19);
            radMeatLover.TabIndex = 0;
            radMeatLover.TabStop = true;
            radMeatLover.Text = "Meat Lover";
            radMeatLover.UseVisualStyleBackColor = true;
            radMeatLover.CheckedChanged += radMeatLover_CheckedChanged;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(15, 206);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(103, 40);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(164, 209);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(12, 168);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 23);
            txtDescription.TabIndex = 0;
            // 
            // Preset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 258);
            Controls.Add(txtDescription);
            Controls.Add(btnSelect);
            Controls.Add(btnCancel);
            Controls.Add(grpSpecial);
            Name = "Preset";
            Text = "Preset";
            Load += Preset_Load;
            grpSpecial.ResumeLayout(false);
            grpSpecial.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSpecial;
        private Button btnSelect;
        private Button btnCancel;
        private RadioButton radSupreme;
        private RadioButton radVegetarian;
        private RadioButton radMemphisChicken;
        private RadioButton radHawaiian;
        private RadioButton radMeatLover;
        private TextBox txtDescription;
    }
}