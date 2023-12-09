namespace CS311_FinalProject_RLV
{
    partial class Form1
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
            lblConversionCalc = new Label();
            txtValue = new TextBox();
            textBox2 = new TextBox();
            lblEnterValue = new Label();
            lblResult = new Label();
            grpConversion = new GroupBox();
            rdoOuncesG = new RadioButton();
            rdoPoundsK = new RadioButton();
            rdoMilesK = new RadioButton();
            rdoFeetM = new RadioButton();
            rdoGramsO = new RadioButton();
            rdoFtoC = new RadioButton();
            rdoKiloM = new RadioButton();
            rdoMetersF = new RadioButton();
            rdoKilP = new RadioButton();
            rdoCtoF = new RadioButton();
            btnConvert = new Button();
            btnClear = new Button();
            lblInstructions = new Label();
            grpConversion.SuspendLayout();
            SuspendLayout();
            // 
            // lblConversionCalc
            // 
            lblConversionCalc.AutoSize = true;
            lblConversionCalc.Font = new Font("Century Gothic", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            lblConversionCalc.Location = new Point(287, 41);
            lblConversionCalc.Name = "lblConversionCalc";
            lblConversionCalc.Size = new Size(353, 56);
            lblConversionCalc.TabIndex = 0;
            lblConversionCalc.Text = "Unit Converter";
            lblConversionCalc.Click += lblConversionCalc_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(1006, 294);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(219, 37);
            txtValue.TabIndex = 1;
            txtValue.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(1018, 510);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 30);
            textBox2.TabIndex = 2;
            // 
            // lblEnterValue
            // 
            lblEnterValue.AutoSize = true;
            lblEnterValue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnterValue.Location = new Point(1006, 242);
            lblEnterValue.Name = "lblEnterValue";
            lblEnterValue.Size = new Size(175, 34);
            lblEnterValue.TabIndex = 3;
            lblEnterValue.Text = "Enter value:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(1006, 543);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(109, 34);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result: ";
            // 
            // grpConversion
            // 
            grpConversion.Controls.Add(rdoOuncesG);
            grpConversion.Controls.Add(rdoPoundsK);
            grpConversion.Controls.Add(rdoMilesK);
            grpConversion.Controls.Add(rdoFeetM);
            grpConversion.Controls.Add(rdoGramsO);
            grpConversion.Controls.Add(rdoFtoC);
            grpConversion.Controls.Add(rdoKiloM);
            grpConversion.Controls.Add(rdoMetersF);
            grpConversion.Controls.Add(rdoKilP);
            grpConversion.Controls.Add(rdoCtoF);
            grpConversion.Font = new Font("Century Gothic", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            grpConversion.Location = new Point(87, 215);
            grpConversion.Name = "grpConversion";
            grpConversion.Size = new Size(789, 471);
            grpConversion.TabIndex = 5;
            grpConversion.TabStop = false;
            grpConversion.Text = "Unit sets:";
            // 
            // rdoOuncesG
            // 
            rdoOuncesG.AutoSize = true;
            rdoOuncesG.Location = new Point(455, 250);
            rdoOuncesG.Name = "rdoOuncesG";
            rdoOuncesG.Size = new Size(240, 32);
            rdoOuncesG.TabIndex = 1;
            rdoOuncesG.TabStop = true;
            rdoOuncesG.Text = "Ounces to Grams";
            rdoOuncesG.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsK
            // 
            rdoPoundsK.AutoSize = true;
            rdoPoundsK.Location = new Point(79, 250);
            rdoPoundsK.Name = "rdoPoundsK";
            rdoPoundsK.Size = new Size(272, 32);
            rdoPoundsK.TabIndex = 1;
            rdoPoundsK.TabStop = true;
            rdoPoundsK.Text = "Pounds to Kilograms";
            rdoPoundsK.UseVisualStyleBackColor = true;
            rdoPoundsK.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // rdoMilesK
            // 
            rdoMilesK.AutoSize = true;
            rdoMilesK.Location = new Point(455, 110);
            rdoMilesK.Name = "rdoMilesK";
            rdoMilesK.Size = new Size(254, 32);
            rdoMilesK.TabIndex = 1;
            rdoMilesK.TabStop = true;
            rdoMilesK.Text = "Miles to Kilometers";
            rdoMilesK.UseVisualStyleBackColor = true;
            rdoMilesK.CheckedChanged += rdoMilesK_CheckedChanged;
            // 
            // rdoFeetM
            // 
            rdoFeetM.AutoSize = true;
            rdoFeetM.Location = new Point(77, 107);
            rdoFeetM.Name = "rdoFeetM";
            rdoFeetM.Size = new Size(200, 32);
            rdoFeetM.TabIndex = 8;
            rdoFeetM.TabStop = true;
            rdoFeetM.Text = "Feet to Meters";
            rdoFeetM.UseVisualStyleBackColor = true;
            // 
            // rdoGramsO
            // 
            rdoGramsO.AutoSize = true;
            rdoGramsO.Location = new Point(455, 199);
            rdoGramsO.Name = "rdoGramsO";
            rdoGramsO.Size = new Size(240, 32);
            rdoGramsO.TabIndex = 0;
            rdoGramsO.TabStop = true;
            rdoGramsO.Text = "Grams to Ounces";
            rdoGramsO.UseVisualStyleBackColor = true;
            // 
            // rdoFtoC
            // 
            rdoFtoC.AutoSize = true;
            rdoFtoC.Location = new Point(255, 391);
            rdoFtoC.Name = "rdoFtoC";
            rdoFtoC.Size = new Size(276, 32);
            rdoFtoC.TabIndex = 1;
            rdoFtoC.TabStop = true;
            rdoFtoC.Text = "Fahrenheit to Celsius";
            rdoFtoC.UseVisualStyleBackColor = true;
            rdoFtoC.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // rdoKiloM
            // 
            rdoKiloM.AutoSize = true;
            rdoKiloM.Location = new Point(455, 54);
            rdoKiloM.Name = "rdoKiloM";
            rdoKiloM.Size = new Size(254, 32);
            rdoKiloM.TabIndex = 0;
            rdoKiloM.TabStop = true;
            rdoKiloM.Text = "Kilometers to Miles";
            rdoKiloM.UseVisualStyleBackColor = true;
            // 
            // rdoMetersF
            // 
            rdoMetersF.AutoSize = true;
            rdoMetersF.Location = new Point(79, 54);
            rdoMetersF.Name = "rdoMetersF";
            rdoMetersF.Size = new Size(200, 32);
            rdoMetersF.TabIndex = 7;
            rdoMetersF.TabStop = true;
            rdoMetersF.Text = "Meters to Feet";
            rdoMetersF.UseVisualStyleBackColor = true;
            // 
            // rdoKilP
            // 
            rdoKilP.AutoSize = true;
            rdoKilP.Location = new Point(79, 199);
            rdoKilP.Name = "rdoKilP";
            rdoKilP.Size = new Size(272, 32);
            rdoKilP.TabIndex = 0;
            rdoKilP.TabStop = true;
            rdoKilP.Text = "Kilograms to Pounds";
            rdoKilP.UseVisualStyleBackColor = true;
            // 
            // rdoCtoF
            // 
            rdoCtoF.AutoSize = true;
            rdoCtoF.Location = new Point(255, 335);
            rdoCtoF.Name = "rdoCtoF";
            rdoCtoF.Size = new Size(276, 32);
            rdoCtoF.TabIndex = 0;
            rdoCtoF.TabStop = true;
            rdoCtoF.Text = "Celsius to Fahrenheit";
            rdoCtoF.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Century Gothic", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(1053, 351);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(131, 40);
            btnConvert.TabIndex = 8;
            btnConvert.Text = "CONVERT";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century Gothic", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(1053, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 40);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.ImageAlign = ContentAlignment.TopCenter;
            lblInstructions.Location = new Point(246, 116);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(457, 48);
            lblInstructions.TabIndex = 10;
            lblInstructions.Text = "Choose a unit set to convert, enter a value \r\nand click on convert for the result.\r\n";
            lblInstructions.TextAlign = ContentAlignment.TopCenter;
            lblInstructions.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 722);
            Controls.Add(lblInstructions);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(grpConversion);
            Controls.Add(lblResult);
            Controls.Add(lblEnterValue);
            Controls.Add(textBox2);
            Controls.Add(txtValue);
            Controls.Add(lblConversionCalc);
            Name = "Form1";
            Text = "Unit Converter";
            grpConversion.ResumeLayout(false);
            grpConversion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConversionCalc;
        private TextBox txtValue;
        private TextBox textBox2;
        private Label lblEnterValue;
        private Label lblResult;
        private GroupBox grpConversion;
        private RadioButton rdoFeetM;
        private RadioButton rdoMetersF;
        private RadioButton rdoMilesK;
        private RadioButton rdoKiloM;
        private RadioButton rdoPoundsK;
        private RadioButton rdoKilP;
        private RadioButton rdoFtoC;
        private RadioButton rdoCtoF;
        private RadioButton rdoOuncesG;
        private RadioButton rdoGramsO;
        private Button btnConvert;
        private Button btnClear;
        private Label lblInstructions;
    }
}