namespace Converter
{
    partial class Form1
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
            this.lblStepOne = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rbMetToFee = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbFeeToMet = new System.Windows.Forms.RadioButton();
            this.rbKilToMil = new System.Windows.Forms.RadioButton();
            this.rbMilToKil = new System.Windows.Forms.RadioButton();
            this.rbCelToFah = new System.Windows.Forms.RadioButton();
            this.rbKilToPou = new System.Windows.Forms.RadioButton();
            this.rbPouToKil = new System.Windows.Forms.RadioButton();
            this.rbGraToOun = new System.Windows.Forms.RadioButton();
            this.rbOunToGra = new System.Windows.Forms.RadioButton();
            this.rbFahToCel = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblStepTwo = new System.Windows.Forms.Label();
            this.lblStepThree = new System.Windows.Forms.Label();
            this.lblStepFour = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStepOne
            // 
            this.lblStepOne.AutoSize = true;
            this.lblStepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepOne.Location = new System.Drawing.Point(14, 149);
            this.lblStepOne.Name = "lblStepOne";
            this.lblStepOne.Size = new System.Drawing.Size(338, 20);
            this.lblStepOne.TabIndex = 0;
            this.lblStepOne.Text = "Step 1: Enter Your Current Measurement";
            this.lblStepOne.Click += new System.EventHandler(this.lblExplination_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtInput.Location = new System.Drawing.Point(25, 183);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(327, 30);
            this.txtInput.TabIndex = 1;
            // 
            // rbMetToFee
            // 
            this.rbMetToFee.AutoSize = true;
            this.rbMetToFee.Location = new System.Drawing.Point(408, 102);
            this.rbMetToFee.Name = "rbMetToFee";
            this.rbMetToFee.Size = new System.Drawing.Size(93, 17);
            this.rbMetToFee.TabIndex = 2;
            this.rbMetToFee.TabStop = true;
            this.rbMetToFee.Text = "Meters to Feet";
            this.rbMetToFee.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvert.Location = new System.Drawing.Point(98, 393);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(167, 36);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert now!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbFeeToMet
            // 
            this.rbFeeToMet.AutoSize = true;
            this.rbFeeToMet.Location = new System.Drawing.Point(408, 125);
            this.rbFeeToMet.Name = "rbFeeToMet";
            this.rbFeeToMet.Size = new System.Drawing.Size(93, 17);
            this.rbFeeToMet.TabIndex = 4;
            this.rbFeeToMet.TabStop = true;
            this.rbFeeToMet.Text = "Feet to Meters";
            this.rbFeeToMet.UseVisualStyleBackColor = true;
            // 
            // rbKilToMil
            // 
            this.rbKilToMil.AutoSize = true;
            this.rbKilToMil.Location = new System.Drawing.Point(408, 149);
            this.rbKilToMil.Name = "rbKilToMil";
            this.rbKilToMil.Size = new System.Drawing.Size(112, 17);
            this.rbKilToMil.TabIndex = 5;
            this.rbKilToMil.TabStop = true;
            this.rbKilToMil.Text = "Kilometers to Miles";
            this.rbKilToMil.UseVisualStyleBackColor = true;
            // 
            // rbMilToKil
            // 
            this.rbMilToKil.AutoSize = true;
            this.rbMilToKil.Location = new System.Drawing.Point(408, 172);
            this.rbMilToKil.Name = "rbMilToKil";
            this.rbMilToKil.Size = new System.Drawing.Size(112, 17);
            this.rbMilToKil.TabIndex = 6;
            this.rbMilToKil.TabStop = true;
            this.rbMilToKil.Text = "Miles to Kilometers";
            this.rbMilToKil.UseVisualStyleBackColor = true;
            // 
            // rbCelToFah
            // 
            this.rbCelToFah.AutoSize = true;
            this.rbCelToFah.Location = new System.Drawing.Point(408, 225);
            this.rbCelToFah.Name = "rbCelToFah";
            this.rbCelToFah.Size = new System.Drawing.Size(127, 17);
            this.rbCelToFah.TabIndex = 7;
            this.rbCelToFah.TabStop = true;
            this.rbCelToFah.Text = "Celsius To Fahrenheit";
            this.rbCelToFah.UseVisualStyleBackColor = true;
            // 
            // rbKilToPou
            // 
            this.rbKilToPou.AutoSize = true;
            this.rbKilToPou.Location = new System.Drawing.Point(408, 249);
            this.rbKilToPou.Name = "rbKilToPou";
            this.rbKilToPou.Size = new System.Drawing.Size(120, 17);
            this.rbKilToPou.TabIndex = 8;
            this.rbKilToPou.TabStop = true;
            this.rbKilToPou.Text = "Kilogram To Pounds";
            this.rbKilToPou.UseVisualStyleBackColor = true;
            // 
            // rbPouToKil
            // 
            this.rbPouToKil.AutoSize = true;
            this.rbPouToKil.Location = new System.Drawing.Point(408, 273);
            this.rbPouToKil.Name = "rbPouToKil";
            this.rbPouToKil.Size = new System.Drawing.Size(121, 17);
            this.rbPouToKil.TabIndex = 9;
            this.rbPouToKil.TabStop = true;
            this.rbPouToKil.Text = "Pounds to Kilograms";
            this.rbPouToKil.UseVisualStyleBackColor = true;
            // 
            // rbGraToOun
            // 
            this.rbGraToOun.AutoSize = true;
            this.rbGraToOun.Location = new System.Drawing.Point(408, 297);
            this.rbGraToOun.Name = "rbGraToOun";
            this.rbGraToOun.Size = new System.Drawing.Size(107, 17);
            this.rbGraToOun.TabIndex = 10;
            this.rbGraToOun.TabStop = true;
            this.rbGraToOun.Text = "Grams to Ounces";
            this.rbGraToOun.UseVisualStyleBackColor = true;
            // 
            // rbOunToGra
            // 
            this.rbOunToGra.AutoSize = true;
            this.rbOunToGra.Location = new System.Drawing.Point(408, 321);
            this.rbOunToGra.Name = "rbOunToGra";
            this.rbOunToGra.Size = new System.Drawing.Size(111, 17);
            this.rbOunToGra.TabIndex = 11;
            this.rbOunToGra.TabStop = true;
            this.rbOunToGra.Text = "Ounces To Grams";
            this.rbOunToGra.UseVisualStyleBackColor = true;
            // 
            // rbFahToCel
            // 
            this.rbFahToCel.AutoSize = true;
            this.rbFahToCel.Location = new System.Drawing.Point(408, 196);
            this.rbFahToCel.Name = "rbFahToCel";
            this.rbFahToCel.Size = new System.Drawing.Size(128, 17);
            this.rbFahToCel.TabIndex = 12;
            this.rbFahToCel.TabStop = true;
            this.rbFahToCel.Text = "Fahrenheit To Celcius";
            this.rbFahToCel.UseVisualStyleBackColor = true;
            this.rbFahToCel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtOutput.Location = new System.Drawing.Point(408, 399);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(380, 30);
            this.txtOutput.TabIndex = 13;
            // 
            // lblStepTwo
            // 
            this.lblStepTwo.AutoSize = true;
            this.lblStepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepTwo.Location = new System.Drawing.Point(404, 68);
            this.lblStepTwo.Name = "lblStepTwo";
            this.lblStepTwo.Size = new System.Drawing.Size(270, 20);
            this.lblStepTwo.TabIndex = 14;
            this.lblStepTwo.Text = "Step 2: Choose Your Conversion";
            // 
            // lblStepThree
            // 
            this.lblStepThree.AutoSize = true;
            this.lblStepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepThree.Location = new System.Drawing.Point(78, 356);
            this.lblStepThree.Name = "lblStepThree";
            this.lblStepThree.Size = new System.Drawing.Size(211, 20);
            this.lblStepThree.TabIndex = 15;
            this.lblStepThree.Text = "Step 3: Go ahead, click it";
            // 
            // lblStepFour
            // 
            this.lblStepFour.AutoSize = true;
            this.lblStepFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepFour.Location = new System.Drawing.Point(466, 376);
            this.lblStepFour.Name = "lblStepFour";
            this.lblStepFour.Size = new System.Drawing.Size(261, 20);
            this.lblStepFour.TabIndex = 16;
            this.lblStepFour.Text = "Step 4: There\'s your conversion";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(754, 31);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Welcome to my CS311 Final Project, The Unit Converter!";
            this.lblTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStepFour);
            this.Controls.Add(this.lblStepThree);
            this.Controls.Add(this.lblStepTwo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.rbFahToCel);
            this.Controls.Add(this.rbOunToGra);
            this.Controls.Add(this.rbGraToOun);
            this.Controls.Add(this.rbPouToKil);
            this.Controls.Add(this.rbKilToPou);
            this.Controls.Add(this.rbCelToFah);
            this.Controls.Add(this.rbMilToKil);
            this.Controls.Add(this.rbKilToMil);
            this.Controls.Add(this.rbFeeToMet);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbMetToFee);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblStepOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStepOne;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rbMetToFee;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbFeeToMet;
        private System.Windows.Forms.RadioButton rbKilToMil;
        private System.Windows.Forms.RadioButton rbMilToKil;
        private System.Windows.Forms.RadioButton rbCelToFah;
        private System.Windows.Forms.RadioButton rbKilToPou;
        private System.Windows.Forms.RadioButton rbPouToKil;
        private System.Windows.Forms.RadioButton rbGraToOun;
        private System.Windows.Forms.RadioButton rbOunToGra;
        private System.Windows.Forms.RadioButton rbFahToCel;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblStepTwo;
        private System.Windows.Forms.Label lblStepThree;
        private System.Windows.Forms.Label lblStepFour;
        private System.Windows.Forms.Label lblTitle;
    }
}

