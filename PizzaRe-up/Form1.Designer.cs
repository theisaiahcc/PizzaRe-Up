namespace PizzaRe_up
{
    partial class PizzaAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radWhiteSauce = new System.Windows.Forms.RadioButton();
            this.radRedSauce = new System.Windows.Forms.RadioButton();
            this.grpSauce = new System.Windows.Forms.GroupBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkJalapenos = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radThick = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.btnPreset = new System.Windows.Forms.Button();
            this.grpSauce.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // radWhiteSauce
            // 
            this.radWhiteSauce.AutoSize = true;
            this.radWhiteSauce.Location = new System.Drawing.Point(6, 24);
            this.radWhiteSauce.Name = "radWhiteSauce";
            this.radWhiteSauce.Size = new System.Drawing.Size(56, 19);
            this.radWhiteSauce.TabIndex = 3;
            this.radWhiteSauce.Text = "White";
            this.radWhiteSauce.UseVisualStyleBackColor = true;
            // 
            // radRedSauce
            // 
            this.radRedSauce.AutoSize = true;
            this.radRedSauce.Checked = true;
            this.radRedSauce.Location = new System.Drawing.Point(6, 47);
            this.radRedSauce.Name = "radRedSauce";
            this.radRedSauce.Size = new System.Drawing.Size(45, 19);
            this.radRedSauce.TabIndex = 4;
            this.radRedSauce.TabStop = true;
            this.radRedSauce.Text = "Red";
            this.radRedSauce.UseVisualStyleBackColor = true;
            // 
            // grpSauce
            // 
            this.grpSauce.Controls.Add(this.radWhiteSauce);
            this.grpSauce.Controls.Add(this.radRedSauce);
            this.grpSauce.Location = new System.Drawing.Point(125, 14);
            this.grpSauce.Name = "grpSauce";
            this.grpSauce.Size = new System.Drawing.Size(110, 78);
            this.grpSauce.TabIndex = 5;
            this.grpSauce.TabStop = false;
            this.grpSauce.Text = "Sauce";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(18, 28);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(80, 19);
            this.chkPepperoni.TabIndex = 11;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(18, 56);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(69, 19);
            this.chkSausage.TabIndex = 12;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(18, 84);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(52, 19);
            this.chkHam.TabIndex = 13;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(18, 112);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(59, 19);
            this.chkBacon.TabIndex = 14;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(18, 140);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(69, 19);
            this.chkChicken.TabIndex = 15;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(18, 168);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(68, 19);
            this.chkPeppers.TabIndex = 16;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(18, 196);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(90, 19);
            this.chkMushrooms.TabIndex = 17;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(18, 224);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(58, 19);
            this.chkOlives.TabIndex = 18;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkJalapenos
            // 
            this.chkJalapenos.AutoSize = true;
            this.chkJalapenos.Location = new System.Drawing.Point(18, 252);
            this.chkJalapenos.Name = "chkJalapenos";
            this.chkJalapenos.Size = new System.Drawing.Size(77, 19);
            this.chkJalapenos.TabIndex = 19;
            this.chkJalapenos.Text = "Jalapenos";
            this.chkJalapenos.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(143, 234);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(143, 263);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ingredients";
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(6, 22);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(48, 19);
            this.radThin.TabIndex = 23;
            this.radThin.Text = "Thin";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Checked = true;
            this.radRegular.Location = new System.Drawing.Point(6, 47);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(65, 19);
            this.radRegular.TabIndex = 24;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radThick
            // 
            this.radThick.AutoSize = true;
            this.radThick.Location = new System.Drawing.Point(6, 72);
            this.radThick.Name = "radThick";
            this.radThick.Size = new System.Drawing.Size(53, 19);
            this.radThick.TabIndex = 25;
            this.radThick.Text = "Thick";
            this.radThick.UseVisualStyleBackColor = true;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.radThin);
            this.grpCrust.Controls.Add(this.radThick);
            this.grpCrust.Controls.Add(this.radRegular);
            this.grpCrust.Location = new System.Drawing.Point(125, 101);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(110, 98);
            this.grpCrust.TabIndex = 26;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // btnPreset
            // 
            this.btnPreset.Location = new System.Drawing.Point(143, 205);
            this.btnPreset.Name = "btnPreset";
            this.btnPreset.Size = new System.Drawing.Size(75, 23);
            this.btnPreset.TabIndex = 27;
            this.btnPreset.Text = "Preset";
            this.btnPreset.UseVisualStyleBackColor = true;
            this.btnPreset.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // PizzaAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 320);
            this.Controls.Add(this.btnPreset);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkJalapenos);
            this.Controls.Add(this.chkOlives);
            this.Controls.Add(this.chkMushrooms);
            this.Controls.Add(this.chkPeppers);
            this.Controls.Add(this.chkChicken);
            this.Controls.Add(this.chkBacon);
            this.Controls.Add(this.chkHam);
            this.Controls.Add(this.chkSausage);
            this.Controls.Add(this.chkPepperoni);
            this.Controls.Add(this.grpSauce);
            this.Name = "PizzaAppForm";
            this.Text = "Pizza App";
            this.grpSauce.ResumeLayout(false);
            this.grpSauce.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton radWhiteSauce;
        private RadioButton radRedSauce;
        private GroupBox grpSauce;
        private CheckBox chkPepperoni;
        private CheckBox chkSausage;
        private CheckBox chkHam;
        private CheckBox chkBacon;
        private CheckBox chkChicken;
        private CheckBox chkPeppers;
        private CheckBox chkMushrooms;
        private CheckBox chkOlives;
        private CheckBox chkJalapenos;
        private Button btnSubmit;
        private Button btnEdit;
        private Label label1;
        private RadioButton radThin;
        private RadioButton radRegular;
        private RadioButton radThick;
        private GroupBox grpCrust;
        private Button btnPreset;
    }
}