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
            radWhiteSauce = new RadioButton();
            radRedSauce = new RadioButton();
            grpSauce = new GroupBox();
            chkPepperoni = new CheckBox();
            chkSausage = new CheckBox();
            chkHam = new CheckBox();
            chkBacon = new CheckBox();
            chkChicken = new CheckBox();
            chkPeppers = new CheckBox();
            chkMushrooms = new CheckBox();
            chkOlives = new CheckBox();
            chkJalapenos = new CheckBox();
            btnSubmit = new Button();
            btnEdit = new Button();
            radThin = new RadioButton();
            radRegular = new RadioButton();
            radStuffed = new RadioButton();
            grpCrust = new GroupBox();
            btnPreset = new Button();
            grpIngredients = new GroupBox();
            grpPizzaSizes = new GroupBox();
            radLargeSize = new RadioButton();
            radMediumSize = new RadioButton();
            radSmallSize = new RadioButton();
            txtOrderName = new TextBox();
            label1 = new Label();
            chkPineapple = new CheckBox();
            chkOnions = new CheckBox();
            grpSauce.SuspendLayout();
            grpCrust.SuspendLayout();
            grpIngredients.SuspendLayout();
            grpPizzaSizes.SuspendLayout();
            SuspendLayout();
            // 
            // radWhiteSauce
            // 
            radWhiteSauce.AutoSize = true;
            radWhiteSauce.Location = new Point(6, 24);
            radWhiteSauce.Name = "radWhiteSauce";
            radWhiteSauce.Size = new Size(56, 19);
            radWhiteSauce.TabIndex = 3;
            radWhiteSauce.Text = "White";
            radWhiteSauce.UseVisualStyleBackColor = true;
            // 
            // radRedSauce
            // 
            radRedSauce.AutoSize = true;
            radRedSauce.Checked = true;
            radRedSauce.Location = new Point(6, 47);
            radRedSauce.Name = "radRedSauce";
            radRedSauce.Size = new Size(45, 19);
            radRedSauce.TabIndex = 4;
            radRedSauce.TabStop = true;
            radRedSauce.Text = "Red";
            radRedSauce.UseVisualStyleBackColor = true;
            // 
            // grpSauce
            // 
            grpSauce.Controls.Add(radWhiteSauce);
            grpSauce.Controls.Add(radRedSauce);
            grpSauce.Location = new Point(141, 14);
            grpSauce.Name = "grpSauce";
            grpSauce.Size = new Size(110, 78);
            grpSauce.TabIndex = 5;
            grpSauce.TabStop = false;
            grpSauce.Text = "Sauce";
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(6, 24);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(80, 19);
            chkPepperoni.TabIndex = 11;
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            chkSausage.AutoSize = true;
            chkSausage.Location = new Point(6, 50);
            chkSausage.Name = "chkSausage";
            chkSausage.Size = new Size(69, 19);
            chkSausage.TabIndex = 12;
            chkSausage.Text = "Sausage";
            chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            chkHam.AutoSize = true;
            chkHam.Location = new Point(6, 76);
            chkHam.Name = "chkHam";
            chkHam.Size = new Size(52, 19);
            chkHam.TabIndex = 13;
            chkHam.Text = "Ham";
            chkHam.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(6, 102);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(59, 19);
            chkBacon.TabIndex = 14;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            chkChicken.AutoSize = true;
            chkChicken.Location = new Point(6, 128);
            chkChicken.Name = "chkChicken";
            chkChicken.Size = new Size(69, 19);
            chkChicken.TabIndex = 15;
            chkChicken.Text = "Chicken";
            chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            chkPeppers.AutoSize = true;
            chkPeppers.Location = new Point(6, 154);
            chkPeppers.Name = "chkPeppers";
            chkPeppers.Size = new Size(68, 19);
            chkPeppers.TabIndex = 16;
            chkPeppers.Text = "Peppers";
            chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(6, 180);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(90, 19);
            chkMushrooms.TabIndex = 17;
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Location = new Point(6, 206);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(58, 19);
            chkOlives.TabIndex = 18;
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkJalapenos
            // 
            chkJalapenos.AutoSize = true;
            chkJalapenos.Location = new Point(6, 232);
            chkJalapenos.Name = "chkJalapenos";
            chkJalapenos.Size = new Size(77, 19);
            chkJalapenos.TabIndex = 19;
            chkJalapenos.Text = "Jalapenos";
            chkJalapenos.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(132, 380);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(130, 23);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit New Order";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(132, 409);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 23);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Update Existing Order";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += editBtn_Click;
            // 
            // radThin
            // 
            radThin.AutoSize = true;
            radThin.Location = new Point(6, 22);
            radThin.Name = "radThin";
            radThin.Size = new Size(48, 19);
            radThin.TabIndex = 23;
            radThin.Text = "Thin";
            radThin.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            radRegular.AutoSize = true;
            radRegular.Checked = true;
            radRegular.Location = new Point(6, 47);
            radRegular.Name = "radRegular";
            radRegular.Size = new Size(65, 19);
            radRegular.TabIndex = 24;
            radRegular.TabStop = true;
            radRegular.Text = "Regular";
            radRegular.UseVisualStyleBackColor = true;
            // 
            // radStuffed
            // 
            radStuffed.AutoSize = true;
            radStuffed.Location = new Point(6, 72);
            radStuffed.Name = "radStuffed";
            radStuffed.Size = new Size(63, 19);
            radStuffed.TabIndex = 25;
            radStuffed.Text = "Stuffed";
            radStuffed.UseVisualStyleBackColor = true;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(radThin);
            grpCrust.Controls.Add(radStuffed);
            grpCrust.Controls.Add(radRegular);
            grpCrust.Location = new Point(141, 94);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(110, 98);
            grpCrust.TabIndex = 26;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // btnPreset
            // 
            btnPreset.Location = new Point(132, 307);
            btnPreset.Name = "btnPreset";
            btnPreset.Size = new Size(130, 23);
            btnPreset.TabIndex = 27;
            btnPreset.Text = "Preset Pizzas";
            btnPreset.UseVisualStyleBackColor = true;
            btnPreset.Click += btnPreset_Click;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chkOnions);
            grpIngredients.Controls.Add(chkPineapple);
            grpIngredients.Controls.Add(chkJalapenos);
            grpIngredients.Controls.Add(chkPepperoni);
            grpIngredients.Controls.Add(chkSausage);
            grpIngredients.Controls.Add(chkHam);
            grpIngredients.Controls.Add(chkBacon);
            grpIngredients.Controls.Add(chkChicken);
            grpIngredients.Controls.Add(chkPeppers);
            grpIngredients.Controls.Add(chkOlives);
            grpIngredients.Controls.Add(chkMushrooms);
            grpIngredients.Location = new Point(8, 14);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(117, 310);
            grpIngredients.TabIndex = 28;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // grpPizzaSizes
            // 
            grpPizzaSizes.Controls.Add(radLargeSize);
            grpPizzaSizes.Controls.Add(radMediumSize);
            grpPizzaSizes.Controls.Add(radSmallSize);
            grpPizzaSizes.Location = new Point(141, 198);
            grpPizzaSizes.Name = "grpPizzaSizes";
            grpPizzaSizes.Size = new Size(117, 103);
            grpPizzaSizes.TabIndex = 29;
            grpPizzaSizes.TabStop = false;
            grpPizzaSizes.Text = "Pizza Sizes";
            grpPizzaSizes.Enter += PizzaAppForm_Load;
            // 
            // radLargeSize
            // 
            radLargeSize.AutoSize = true;
            radLargeSize.Location = new Point(2, 72);
            radLargeSize.Name = "radLargeSize";
            radLargeSize.Size = new Size(54, 19);
            radLargeSize.TabIndex = 2;
            radLargeSize.Text = "Large";
            radLargeSize.UseVisualStyleBackColor = true;
            // 
            // radMediumSize
            // 
            radMediumSize.AutoSize = true;
            radMediumSize.Checked = true;
            radMediumSize.Location = new Point(2, 47);
            radMediumSize.Name = "radMediumSize";
            radMediumSize.Size = new Size(70, 19);
            radMediumSize.TabIndex = 1;
            radMediumSize.TabStop = true;
            radMediumSize.Text = "Medium";
            radMediumSize.UseVisualStyleBackColor = true;
            // 
            // radSmallSize
            // 
            radSmallSize.AutoSize = true;
            radSmallSize.Location = new Point(2, 22);
            radSmallSize.Name = "radSmallSize";
            radSmallSize.Size = new Size(54, 19);
            radSmallSize.TabIndex = 0;
            radSmallSize.Text = "Small";
            radSmallSize.UseVisualStyleBackColor = true;
            // 
            // txtOrderName
            // 
            txtOrderName.Location = new Point(6, 379);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new Size(118, 23);
            txtOrderName.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 359);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 31;
            label1.Text = "Order Name:";
            // 
            // chkPineapple
            // 
            chkPineapple.AutoSize = true;
            chkPineapple.Location = new Point(6, 258);
            chkPineapple.Name = "chkPineapple";
            chkPineapple.Size = new Size(78, 19);
            chkPineapple.TabIndex = 20;
            chkPineapple.Text = "Pineapple";
            chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            chkOnions.AutoSize = true;
            chkOnions.Location = new Point(6, 284);
            chkOnions.Name = "chkOnions";
            chkOnions.Size = new Size(64, 19);
            chkOnions.TabIndex = 21;
            chkOnions.Text = "Onions";
            chkOnions.UseVisualStyleBackColor = true;
            // 
            // PizzaAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 450);
            Controls.Add(label1);
            Controls.Add(txtOrderName);
            Controls.Add(grpPizzaSizes);
            Controls.Add(grpIngredients);
            Controls.Add(btnPreset);
            Controls.Add(grpCrust);
            Controls.Add(btnEdit);
            Controls.Add(btnSubmit);
            Controls.Add(grpSauce);
            Name = "PizzaAppForm";
            Text = "Pizza App";
            grpSauce.ResumeLayout(false);
            grpSauce.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpPizzaSizes.ResumeLayout(false);
            grpPizzaSizes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private RadioButton radThin;
        private RadioButton radRegular;
        private RadioButton radStuffed;
        private GroupBox grpCrust;
        private Button btnPreset;
        private GroupBox grpIngredients;
        private GroupBox grpPizzaSizes;
        private RadioButton radLargeSize;
        private RadioButton radMediumSize;
        private RadioButton radSmallSize;
        private TextBox txtOrderName;
        private Label label1;
        private CheckBox chkPineapple;
        private CheckBox chkOnions;
    }
}