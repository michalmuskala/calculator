namespace calculator
{
    partial class CalculatorView
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
            this.output = new System.Windows.Forms.TextBox();
            this.btn7 = new calculator.Button();
            this.btn8 = new calculator.Button();
            this.btn9 = new calculator.Button();
            this.btn4 = new calculator.Button();
            this.btn5 = new calculator.Button();
            this.btn6 = new calculator.Button();
            this.btn2 = new calculator.Button();
            this.btn3 = new calculator.Button();
            this.btn1 = new calculator.Button();
            this.btn0 = new calculator.Button();
            this.btnDot = new calculator.Button();
            this.btnSub = new calculator.Button();
            this.btnDiv = new calculator.Button();
            this.btnAdd = new calculator.Button();
            this.btnMul = new calculator.Button();
            this.btnEq = new calculator.Button();
            this.btnCE = new calculator.Button();
            this.btnC = new calculator.Button();
            this.btnBsp = new calculator.Button();
            this.btnNeg = new calculator.Button();
            this.operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.Location = new System.Drawing.Point(12, 41);
            this.output.MaxLength = 15;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(317, 45);
            this.output.TabIndex = 0;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.ASCIIText = "7";
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn7.Location = new System.Drawing.Point(9, 149);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 60);
            this.btn7.TabIndex = 1;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.ASCIIText = "8";
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.Location = new System.Drawing.Point(89, 149);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 60);
            this.btn8.TabIndex = 2;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.ASCIIText = "9";
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.Location = new System.Drawing.Point(169, 149);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 60);
            this.btn9.TabIndex = 3;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.ASCIIText = "4";
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.Location = new System.Drawing.Point(9, 209);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 60);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.ASCIIText = "5";
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.Location = new System.Drawing.Point(89, 209);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 60);
            this.btn5.TabIndex = 5;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.ASCIIText = "6";
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.Location = new System.Drawing.Point(169, 209);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 60);
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.ASCIIText = "2";
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(89, 269);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 60);
            this.btn2.TabIndex = 7;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.ASCIIText = "3";
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(169, 269);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 60);
            this.btn3.TabIndex = 8;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn1
            // 
            this.btn1.ASCIIText = "1";
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(9, 269);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 60);
            this.btn1.TabIndex = 9;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn0
            // 
            this.btn0.ASCIIText = "0";
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(89, 329);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 60);
            this.btn0.TabIndex = 10;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.ASCIIText = ".";
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDot.Location = new System.Drawing.Point(169, 329);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(80, 60);
            this.btnDot.TabIndex = 11;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSub
            // 
            this.btnSub.ASCIIText = "-";
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSub.Location = new System.Drawing.Point(249, 149);
            this.btnSub.Margin = new System.Windows.Forms.Padding(0);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 60);
            this.btnSub.TabIndex = 12;
            this.btnSub.TabStop = false;
            this.btnSub.Text = "−";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.ASCIIText = "/";
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDiv.Location = new System.Drawing.Point(249, 89);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(80, 60);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ASCIIText = "+";
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(249, 269);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 60);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMul
            // 
            this.btnMul.ASCIIText = "*";
            this.btnMul.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMul.Location = new System.Drawing.Point(249, 209);
            this.btnMul.Margin = new System.Windows.Forms.Padding(0);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(80, 60);
            this.btnMul.TabIndex = 15;
            this.btnMul.TabStop = false;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnEq
            // 
            this.btnEq.ASCIIText = "=";
            this.btnEq.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEq.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEq.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEq.Location = new System.Drawing.Point(249, 329);
            this.btnEq.Margin = new System.Windows.Forms.Padding(0);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(80, 60);
            this.btnEq.TabIndex = 0;
            this.btnEq.TabStop = false;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // btnCE
            // 
            this.btnCE.ASCIIText = "ce";
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCE.Location = new System.Drawing.Point(12, 89);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(80, 60);
            this.btnCE.TabIndex = 16;
            this.btnCE.TabStop = false;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.ASCIIText = "c";
            this.btnC.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC.Location = new System.Drawing.Point(92, 89);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(80, 60);
            this.btnC.TabIndex = 17;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBsp
            // 
            this.btnBsp.ASCIIText = "bsp";
            this.btnBsp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBsp.Location = new System.Drawing.Point(169, 89);
            this.btnBsp.Margin = new System.Windows.Forms.Padding(0);
            this.btnBsp.Name = "btnBsp";
            this.btnBsp.Size = new System.Drawing.Size(80, 60);
            this.btnBsp.TabIndex = 18;
            this.btnBsp.TabStop = false;
            this.btnBsp.Text = "←";
            this.btnBsp.UseVisualStyleBackColor = true;
            this.btnBsp.Click += new System.EventHandler(this.btnBsp_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.ASCIIText = "neg";
            this.btnNeg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNeg.Location = new System.Drawing.Point(12, 329);
            this.btnNeg.Margin = new System.Windows.Forms.Padding(0);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(80, 60);
            this.btnNeg.TabIndex = 19;
            this.btnNeg.TabStop = false;
            this.btnNeg.Text = "±";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.btnNeg_Click);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.operation.Location = new System.Drawing.Point(12, 9);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(118, 29);
            this.operation.TabIndex = 20;
            this.operation.Text = "operation";
            this.operation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CalculatorView
            // 
            this.AcceptButton = this.btnEq;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 399);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.btnNeg);
            this.Controls.Add(this.btnBsp);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorView";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorView_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btn0;
        private Button btnDot;
        private Button btnSub;
        private Button btnDiv;
        private Button btnAdd;
        private Button btnMul;
        private Button btnEq;
        private Button btnCE;
        private Button btnC;
        private Button btnBsp;
        private Button btnNeg;
        private System.Windows.Forms.Label operation;
    }
}

