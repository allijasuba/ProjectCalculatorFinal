
namespace ProjectCalculatorFinal
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
            this.result = new System.Windows.Forms.TextBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnSquared = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(21, 36);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.result.Size = new System.Drawing.Size(379, 50);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Thistle;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeven.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(21, 185);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(71, 68);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.button_click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Thistle;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEight.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnEight.Location = new System.Drawing.Point(99, 185);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(71, 68);
            this.btnEight.TabIndex = 2;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.button_click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Thistle;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNine.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnNine.Location = new System.Drawing.Point(176, 185);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(71, 68);
            this.btnNine.TabIndex = 3;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.button_click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Thistle;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnDivide.Location = new System.Drawing.Point(252, 185);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(71, 68);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnClear.Location = new System.Drawing.Point(329, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 52);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnDelete.Location = new System.Drawing.Point(329, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 52);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "⌫ ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Thistle;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnMultiply.Location = new System.Drawing.Point(252, 259);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(71, 68);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Thistle;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSix.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnSix.Location = new System.Drawing.Point(176, 259);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(71, 68);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.button_click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Thistle;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFive.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnFive.Location = new System.Drawing.Point(99, 259);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(71, 68);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.button_click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Thistle;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFour.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnFour.Location = new System.Drawing.Point(21, 259);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(71, 68);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.button_click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Thistle;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnMinus.Location = new System.Drawing.Point(252, 333);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(71, 68);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Thistle;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThree.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnThree.Location = new System.Drawing.Point(176, 333);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(71, 68);
            this.btnThree.TabIndex = 13;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.button_click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Thistle;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwo.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnTwo.Location = new System.Drawing.Point(99, 333);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(71, 68);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.button_click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Thistle;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOne.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnOne.Location = new System.Drawing.Point(21, 333);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(71, 68);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.button_click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Thistle;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquals.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnEquals.Location = new System.Drawing.Point(329, 362);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(71, 113);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Thistle;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnPlus.Location = new System.Drawing.Point(252, 407);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(71, 68);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Thistle;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnDot.Location = new System.Drawing.Point(176, 407);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(71, 68);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.button_click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Thistle;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZero.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnZero.Location = new System.Drawing.Point(21, 407);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(149, 68);
            this.btnZero.TabIndex = 16;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.button_click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.Thistle;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearEntry.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnClearEntry.Location = new System.Drawing.Point(329, 185);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(71, 52);
            this.btnClearEntry.TabIndex = 22;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.Location = new System.Drawing.Point(25, 10);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(0, 20);
            this.lblEquation.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.button1.Location = new System.Drawing.Point(21, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "sqrt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.operator_click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Thistle;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnPercent.Location = new System.Drawing.Point(120, 111);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(93, 68);
            this.btnPercent.TabIndex = 25;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.Thistle;
            this.btnPi.FlatAppearance.BorderSize = 0;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPi.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnPi.Location = new System.Drawing.Point(219, 111);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(93, 68);
            this.btnPi.TabIndex = 26;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnSquared
            // 
            this.btnSquared.BackColor = System.Drawing.Color.Thistle;
            this.btnSquared.FlatAppearance.BorderSize = 0;
            this.btnSquared.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquared.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.btnSquared.Location = new System.Drawing.Point(318, 111);
            this.btnSquared.Name = "btnSquared";
            this.btnSquared.Size = new System.Drawing.Size(82, 68);
            this.btnSquared.TabIndex = 27;
            this.btnSquared.Text = "x²";
            this.btnSquared.UseVisualStyleBackColor = false;
            this.btnSquared.Click += new System.EventHandler(this.btnSquared_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(424, 501);
            this.Controls.Add(this.btnSquared);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 540);
            this.MinimumSize = new System.Drawing.Size(440, 540);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnSquared;
    }
}

