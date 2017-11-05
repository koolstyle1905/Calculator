namespace Calculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radDegree = new System.Windows.Forms.RadioButton();
            this.radRadian = new System.Windows.Forms.RadioButton();
            this.btnInverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnHyperbolic = new DevExpress.XtraEditors.SimpleButton();
            this.btnSqrt = new DevExpress.XtraEditors.SimpleButton();
            this.btnXPowY = new DevExpress.XtraEditors.SimpleButton();
            this.btnSin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCos = new DevExpress.XtraEditors.SimpleButton();
            this.btnTan = new DevExpress.XtraEditors.SimpleButton();
            this.btnXPow2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn10PowX = new DevExpress.XtraEditors.SimpleButton();
            this.btnExp = new DevExpress.XtraEditors.SimpleButton();
            this.btnC = new DevExpress.XtraEditors.SimpleButton();
            this.btnMod = new DevExpress.XtraEditors.SimpleButton();
            this.btnCE = new DevExpress.XtraEditors.SimpleButton();
            this.btnEight = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeven = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNine = new DevExpress.XtraEditors.SimpleButton();
            this.btnDivide = new DevExpress.XtraEditors.SimpleButton();
            this.btnMultiply = new DevExpress.XtraEditors.SimpleButton();
            this.btnPi = new DevExpress.XtraEditors.SimpleButton();
            this.btnFive = new DevExpress.XtraEditors.SimpleButton();
            this.btnFour = new DevExpress.XtraEditors.SimpleButton();
            this.btnSix = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinus = new DevExpress.XtraEditors.SimpleButton();
            this.btnFactorial = new DevExpress.XtraEditors.SimpleButton();
            this.btnTwo = new DevExpress.XtraEditors.SimpleButton();
            this.btnOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnThree = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlus = new DevExpress.XtraEditors.SimpleButton();
            this.btnNegative = new DevExpress.XtraEditors.SimpleButton();
            this.btnZero = new DevExpress.XtraEditors.SimpleButton();
            this.btnAns = new DevExpress.XtraEditors.SimpleButton();
            this.btnDot = new DevExpress.XtraEditors.SimpleButton();
            this.btnEqual = new DevExpress.XtraEditors.SimpleButton();
            this.btnLog = new DevExpress.XtraEditors.SimpleButton();
            this.calculatorInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorInformationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 28);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(279, 68);
            this.txtResult.TabIndex = 1;
            // 
            // radDegree
            // 
            this.radDegree.AutoSize = true;
            this.radDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDegree.Location = new System.Drawing.Point(13, 114);
            this.radDegree.Name = "radDegree";
            this.radDegree.Size = new System.Drawing.Size(78, 20);
            this.radDegree.TabIndex = 2;
            this.radDegree.TabStop = true;
            this.radDegree.Text = "Degree";
            this.radDegree.UseVisualStyleBackColor = true;
            // 
            // radRadian
            // 
            this.radRadian.AutoSize = true;
            this.radRadian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRadian.Location = new System.Drawing.Point(97, 114);
            this.radRadian.Name = "radRadian";
            this.radRadian.Size = new System.Drawing.Size(76, 20);
            this.radRadian.TabIndex = 3;
            this.radRadian.TabStop = true;
            this.radRadian.Text = "Radian";
            this.radRadian.UseVisualStyleBackColor = true;
            // 
            // btnInverse
            // 
            this.btnInverse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Appearance.Options.UseFont = true;
            this.btnInverse.Location = new System.Drawing.Point(184, 150);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(108, 41);
            this.btnInverse.TabIndex = 4;
            this.btnInverse.Text = "Inverse";
            // 
            // btnHyperbolic
            // 
            this.btnHyperbolic.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHyperbolic.Appearance.Options.UseFont = true;
            this.btnHyperbolic.Location = new System.Drawing.Point(185, 103);
            this.btnHyperbolic.Name = "btnHyperbolic";
            this.btnHyperbolic.Size = new System.Drawing.Size(107, 41);
            this.btnHyperbolic.TabIndex = 4;
            this.btnHyperbolic.Text = "Hyperbolic";
            // 
            // btnSqrt
            // 
            this.btnSqrt.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Appearance.Options.UseFont = true;
            this.btnSqrt.Location = new System.Drawing.Point(12, 150);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(51, 41);
            this.btnSqrt.TabIndex = 5;
            this.btnSqrt.Text = "√";
            // 
            // btnXPowY
            // 
            this.btnXPowY.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPowY.Appearance.Options.UseFont = true;
            this.btnXPowY.Location = new System.Drawing.Point(70, 150);
            this.btnXPowY.Name = "btnXPowY";
            this.btnXPowY.Size = new System.Drawing.Size(51, 41);
            this.btnXPowY.TabIndex = 5;
            this.btnXPowY.Text = "x^y";
            // 
            // btnSin
            // 
            this.btnSin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Appearance.Options.UseFont = true;
            this.btnSin.Location = new System.Drawing.Point(127, 197);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(51, 41);
            this.btnSin.TabIndex = 5;
            this.btnSin.Text = "sin";
            // 
            // btnCos
            // 
            this.btnCos.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Appearance.Options.UseFont = true;
            this.btnCos.Location = new System.Drawing.Point(184, 197);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(51, 41);
            this.btnCos.TabIndex = 5;
            this.btnCos.Text = "cos";
            // 
            // btnTan
            // 
            this.btnTan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Appearance.Options.UseFont = true;
            this.btnTan.Location = new System.Drawing.Point(241, 197);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(51, 41);
            this.btnTan.TabIndex = 5;
            this.btnTan.Text = "tan";
            // 
            // btnXPow2
            // 
            this.btnXPow2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPow2.Appearance.Options.UseFont = true;
            this.btnXPow2.Location = new System.Drawing.Point(12, 197);
            this.btnXPow2.Name = "btnXPow2";
            this.btnXPow2.Size = new System.Drawing.Size(51, 41);
            this.btnXPow2.TabIndex = 5;
            this.btnXPow2.Text = "x^2";
            // 
            // btn10PowX
            // 
            this.btn10PowX.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10PowX.Appearance.Options.UseFont = true;
            this.btn10PowX.Location = new System.Drawing.Point(71, 197);
            this.btn10PowX.Name = "btn10PowX";
            this.btn10PowX.Size = new System.Drawing.Size(51, 41);
            this.btn10PowX.TabIndex = 5;
            this.btn10PowX.Text = "10^x";
            // 
            // btnExp
            // 
            this.btnExp.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Appearance.Options.UseFont = true;
            this.btnExp.Location = new System.Drawing.Point(12, 244);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(51, 41);
            this.btnExp.TabIndex = 5;
            this.btnExp.Text = "Exp";
            // 
            // btnC
            // 
            this.btnC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Appearance.Options.UseFont = true;
            this.btnC.Location = new System.Drawing.Point(127, 244);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(51, 41);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            // 
            // btnMod
            // 
            this.btnMod.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Appearance.Options.UseFont = true;
            this.btnMod.Location = new System.Drawing.Point(12, 291);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(51, 41);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "Mod";
            // 
            // btnCE
            // 
            this.btnCE.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Appearance.Options.UseFont = true;
            this.btnCE.Location = new System.Drawing.Point(70, 244);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(51, 41);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            // 
            // btnEight
            // 
            this.btnEight.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Appearance.Options.UseFont = true;
            this.btnEight.Location = new System.Drawing.Point(127, 291);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(51, 41);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            // 
            // btnSeven
            // 
            this.btnSeven.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Appearance.Options.UseFont = true;
            this.btnSeven.Location = new System.Drawing.Point(70, 291);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(51, 41);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.Text = "7";
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(184, 244);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "←";
            // 
            // btnNine
            // 
            this.btnNine.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Appearance.Options.UseFont = true;
            this.btnNine.Location = new System.Drawing.Point(184, 291);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(51, 41);
            this.btnNine.TabIndex = 5;
            this.btnNine.Text = "9";
            // 
            // btnDivide
            // 
            this.btnDivide.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Appearance.Options.UseFont = true;
            this.btnDivide.Location = new System.Drawing.Point(241, 244);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(51, 41);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Appearance.Options.UseFont = true;
            this.btnMultiply.Location = new System.Drawing.Point(241, 291);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(51, 41);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            // 
            // btnPi
            // 
            this.btnPi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Appearance.Options.UseFont = true;
            this.btnPi.Location = new System.Drawing.Point(12, 338);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(51, 41);
            this.btnPi.TabIndex = 5;
            this.btnPi.Text = "π";
            // 
            // btnFive
            // 
            this.btnFive.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Appearance.Options.UseFont = true;
            this.btnFive.Location = new System.Drawing.Point(127, 338);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(51, 41);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            // 
            // btnFour
            // 
            this.btnFour.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Appearance.Options.UseFont = true;
            this.btnFour.Location = new System.Drawing.Point(70, 338);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(51, 41);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            // 
            // btnSix
            // 
            this.btnSix.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Appearance.Options.UseFont = true;
            this.btnSix.Location = new System.Drawing.Point(184, 338);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(51, 41);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            // 
            // btnMinus
            // 
            this.btnMinus.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Appearance.Options.UseFont = true;
            this.btnMinus.Location = new System.Drawing.Point(241, 338);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 41);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            // 
            // btnFactorial
            // 
            this.btnFactorial.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Appearance.Options.UseFont = true;
            this.btnFactorial.Location = new System.Drawing.Point(13, 385);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(51, 41);
            this.btnFactorial.TabIndex = 5;
            this.btnFactorial.Text = "n!";
            // 
            // btnTwo
            // 
            this.btnTwo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Appearance.Options.UseFont = true;
            this.btnTwo.Location = new System.Drawing.Point(128, 385);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(51, 41);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "2";
            // 
            // btnOne
            // 
            this.btnOne.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Appearance.Options.UseFont = true;
            this.btnOne.Location = new System.Drawing.Point(71, 385);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(51, 41);
            this.btnOne.TabIndex = 5;
            this.btnOne.Text = "1";
            // 
            // btnThree
            // 
            this.btnThree.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Appearance.Options.UseFont = true;
            this.btnThree.Location = new System.Drawing.Point(185, 385);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(51, 41);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            // 
            // btnPlus
            // 
            this.btnPlus.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Appearance.Options.UseFont = true;
            this.btnPlus.Location = new System.Drawing.Point(242, 385);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 41);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            // 
            // btnNegative
            // 
            this.btnNegative.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Appearance.Options.UseFont = true;
            this.btnNegative.Location = new System.Drawing.Point(13, 432);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(51, 41);
            this.btnNegative.TabIndex = 5;
            this.btnNegative.Text = "+/-";
            // 
            // btnZero
            // 
            this.btnZero.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Appearance.Options.UseFont = true;
            this.btnZero.Location = new System.Drawing.Point(128, 432);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 41);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            // 
            // btnAns
            // 
            this.btnAns.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.Appearance.Options.UseFont = true;
            this.btnAns.Location = new System.Drawing.Point(71, 432);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(51, 41);
            this.btnAns.TabIndex = 5;
            this.btnAns.Text = "Ans";
            // 
            // btnDot
            // 
            this.btnDot.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Appearance.Options.UseFont = true;
            this.btnDot.Location = new System.Drawing.Point(185, 432);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(51, 41);
            this.btnDot.TabIndex = 5;
            this.btnDot.Text = ".";
            // 
            // btnEqual
            // 
            this.btnEqual.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Appearance.Options.UseFont = true;
            this.btnEqual.Location = new System.Drawing.Point(242, 432);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(51, 41);
            this.btnEqual.TabIndex = 5;
            this.btnEqual.Text = "=";
            // 
            // btnLog
            // 
            this.btnLog.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Appearance.Options.UseFont = true;
            this.btnLog.Location = new System.Drawing.Point(127, 150);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(51, 41);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "log";
            // 
            // calculatorInformationToolStripMenuItem
            // 
            this.calculatorInformationToolStripMenuItem.Name = "calculatorInformationToolStripMenuItem";
            this.calculatorInformationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculatorInformationToolStripMenuItem.Text = "Ownership";
            this.calculatorInformationToolStripMenuItem.Click += new System.EventHandler(this.calculatorInformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 481);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn10PowX);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnXPowY);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnXPow2);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnHyperbolic);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.radRadian);
            this.Controls.Add(this.radDegree);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radDegree;
        private System.Windows.Forms.RadioButton radRadian;
        private DevExpress.XtraEditors.SimpleButton btnInverse;
        private DevExpress.XtraEditors.SimpleButton btnHyperbolic;
        private DevExpress.XtraEditors.SimpleButton btnSqrt;
        private DevExpress.XtraEditors.SimpleButton btnXPowY;
        private DevExpress.XtraEditors.SimpleButton btnSin;
        private DevExpress.XtraEditors.SimpleButton btnCos;
        private DevExpress.XtraEditors.SimpleButton btnTan;
        private DevExpress.XtraEditors.SimpleButton btnXPow2;
        private DevExpress.XtraEditors.SimpleButton btn10PowX;
        private DevExpress.XtraEditors.SimpleButton btnExp;
        private DevExpress.XtraEditors.SimpleButton btnC;
        private DevExpress.XtraEditors.SimpleButton btnMod;
        private DevExpress.XtraEditors.SimpleButton btnCE;
        private DevExpress.XtraEditors.SimpleButton btnEight;
        private DevExpress.XtraEditors.SimpleButton btnSeven;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNine;
        private DevExpress.XtraEditors.SimpleButton btnDivide;
        private DevExpress.XtraEditors.SimpleButton btnMultiply;
        private DevExpress.XtraEditors.SimpleButton btnPi;
        private DevExpress.XtraEditors.SimpleButton btnFive;
        private DevExpress.XtraEditors.SimpleButton btnFour;
        private DevExpress.XtraEditors.SimpleButton btnSix;
        private DevExpress.XtraEditors.SimpleButton btnMinus;
        private DevExpress.XtraEditors.SimpleButton btnFactorial;
        private DevExpress.XtraEditors.SimpleButton btnTwo;
        private DevExpress.XtraEditors.SimpleButton btnOne;
        private DevExpress.XtraEditors.SimpleButton btnThree;
        private DevExpress.XtraEditors.SimpleButton btnPlus;
        private DevExpress.XtraEditors.SimpleButton btnNegative;
        private DevExpress.XtraEditors.SimpleButton btnZero;
        private DevExpress.XtraEditors.SimpleButton btnAns;
        private DevExpress.XtraEditors.SimpleButton btnDot;
        private DevExpress.XtraEditors.SimpleButton btnEqual;
        private DevExpress.XtraEditors.SimpleButton btnLog;
        private System.Windows.Forms.ToolStripMenuItem calculatorInformationToolStripMenuItem;
    }
}

