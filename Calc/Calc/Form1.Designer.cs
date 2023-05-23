namespace Calc
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
            btnBs = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPlusMinus = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btnMult = new Button();
            txtResult = new TextBox();
            btnDot = new Button();
            btn0 = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btn2 = new Button();
            button1 = new Button();
            btnSin = new Button();
            btnTan = new Button();
            btnPi = new Button();
            btnEquals = new Button();
            btnSqaure = new Button();
            btnCos = new Button();
            btnLog = new Button();
            btnCube = new Button();
            SuspendLayout();
            // 
            // btnBs
            // 
            btnBs.Font = new Font("Wingdings", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBs.Location = new Point(13, 70);
            btnBs.Margin = new Padding(4);
            btnBs.Name = "btnBs";
            btnBs.Size = new Size(93, 60);
            btnBs.TabIndex = 0;
            btnBs.Text = "";
            btnBs.UseVisualStyleBackColor = true;
            btnBs.Click += btnBs_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(112, 70);
            btnClearEntry.Margin = new Padding(4);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(93, 60);
            btnClearEntry.TabIndex = 0;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(211, 70);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 60);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlusMinus.Location = new Point(310, 70);
            btnPlusMinus.Margin = new Padding(4);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(93, 60);
            btnPlusMinus.TabIndex = 0;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(13, 136);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 60);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(112, 136);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 60);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(211, 136);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 60);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(310, 136);
            btnPlus.Margin = new Padding(4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(93, 60);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += numberOper;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(13, 206);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 60);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(112, 206);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 60);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(211, 206);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 60);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(310, 206);
            btnMinus.Margin = new Padding(4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(93, 60);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += numberOper;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(13, 272);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 60);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(211, 272);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 60);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(310, 272);
            btnMult.Margin = new Padding(4);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(93, 60);
            btnMult.TabIndex = 0;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOper;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(14, 16);
            txtResult.Margin = new Padding(4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(588, 46);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.Click += numberOper;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(13, 342);
            btnDot.Margin = new Padding(4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(93, 60);
            btnDot.TabIndex = 0;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(112, 342);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(93, 60);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPercent.Location = new Point(211, 342);
            btnPercent.Margin = new Padding(4);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(93, 60);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(310, 342);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(93, 60);
            btnDivide.TabIndex = 0;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += numberOper;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(112, 272);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 60);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // button1
            // 
            button1.Location = new Point(410, 72);
            button1.Name = "button1";
            button1.Size = new Size(93, 60);
            button1.TabIndex = 3;
            button1.Text = "Sqrt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSin
            // 
            btnSin.Location = new Point(410, 138);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(93, 60);
            btnSin.TabIndex = 3;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnTan
            // 
            btnTan.Location = new Point(410, 204);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(93, 60);
            btnTan.TabIndex = 3;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnPi
            // 
            btnPi.Location = new Point(410, 272);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(93, 60);
            btnPi.TabIndex = 3;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(410, 342);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(191, 60);
            btnEquals.TabIndex = 3;
            btnEquals.Text = "EXE";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSqaure
            // 
            btnSqaure.Location = new Point(509, 72);
            btnSqaure.Name = "btnSqaure";
            btnSqaure.Size = new Size(93, 60);
            btnSqaure.TabIndex = 3;
            btnSqaure.Text = "x^2";
            btnSqaure.UseVisualStyleBackColor = true;
            btnSqaure.Click += btnSqaure_Click;
            // 
            // btnCos
            // 
            btnCos.Location = new Point(509, 138);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(93, 60);
            btnCos.TabIndex = 3;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(509, 204);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(93, 60);
            btnLog.TabIndex = 3;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCube
            // 
            btnCube.Location = new Point(509, 272);
            btnCube.Name = "btnCube";
            btnCube.Size = new Size(93, 60);
            btnCube.TabIndex = 3;
            btnCube.Text = "x^3";
            btnCube.UseVisualStyleBackColor = true;
            btnCube.Click += btnCube_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(613, 411);
            Controls.Add(btnEquals);
            Controls.Add(btnCube);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnCos);
            Controls.Add(btnTan);
            Controls.Add(btnSqaure);
            Controls.Add(btnSin);
            Controls.Add(button1);
            Controls.Add(btn2);
            Controls.Add(txtResult);
            Controls.Add(btnDivide);
            Controls.Add(btnPercent);
            Controls.Add(btnMult);
            Controls.Add(btn3);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btnDot);
            Controls.Add(btnPlusMinus);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btnClear);
            Controls.Add(btn7);
            Controls.Add(btnClearEntry);
            Controls.Add(btnBs);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBs;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPlusMinus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn3;
        private Button btnMult;
        private TextBox txtResult;
        private Button btnDot;
        private Button btn0;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn2;
        private Button button1;
        private Button btnSin;
        private Button btnTan;
        private Button btnPi;
        private Button btnEquals;
        private Button btnSqaure;
        private Button btnCos;
        private Button btnLog;
        private Button btnCube;
    }
}