namespace Calcualtor
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            MainLayout = new System.Windows.Forms.TableLayoutPanel();
            ControlLayout = new System.Windows.Forms.TableLayoutPanel();
            bResult = new System.Windows.Forms.Button();
            bPow = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            bDot = new System.Windows.Forms.Button();
            bPlus = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            bMinus = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            bMultiple = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            bDevide = new System.Windows.Forms.Button();
            bSqrt = new System.Windows.Forms.Button();
            bSign = new System.Windows.Forms.Button();
            bClear = new System.Windows.Forms.Button();
            lInput = new System.Windows.Forms.Label();
            MainLayout.SuspendLayout();
            ControlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayout
            // 
            MainLayout.ColumnCount = 1;
            MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MainLayout.Controls.Add(ControlLayout, 0, 1);
            MainLayout.Controls.Add(lInput, 0, 0);
            MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            MainLayout.Location = new System.Drawing.Point(0, 0);
            MainLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MainLayout.Name = "MainLayout";
            MainLayout.RowCount = 2;
            MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            MainLayout.Size = new System.Drawing.Size(376, 559);
            MainLayout.TabIndex = 0;
            // 
            // ControlLayout
            // 
            ControlLayout.ColumnCount = 4;
            ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            ControlLayout.Controls.Add(bResult, 3, 4);
            ControlLayout.Controls.Add(bPow, 2, 4);
            ControlLayout.Controls.Add(btn0, 1, 4);
            ControlLayout.Controls.Add(bDot, 0, 4);
            ControlLayout.Controls.Add(bPlus, 3, 3);
            ControlLayout.Controls.Add(btn3, 2, 3);
            ControlLayout.Controls.Add(btn2, 1, 3);
            ControlLayout.Controls.Add(btn1, 0, 3);
            ControlLayout.Controls.Add(bMinus, 3, 2);
            ControlLayout.Controls.Add(btn6, 2, 2);
            ControlLayout.Controls.Add(btn5, 1, 2);
            ControlLayout.Controls.Add(btn4, 0, 2);
            ControlLayout.Controls.Add(bMultiple, 3, 1);
            ControlLayout.Controls.Add(btn9, 2, 1);
            ControlLayout.Controls.Add(btn8, 1, 1);
            ControlLayout.Controls.Add(btn7, 0, 1);
            ControlLayout.Controls.Add(bDevide, 3, 0);
            ControlLayout.Controls.Add(bSqrt, 2, 0);
            ControlLayout.Controls.Add(bSign, 1, 0);
            ControlLayout.Controls.Add(bClear, 0, 0);
            ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            ControlLayout.Location = new System.Drawing.Point(3, 87);
            ControlLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ControlLayout.Name = "ControlLayout";
            ControlLayout.RowCount = 5;
            ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            ControlLayout.Size = new System.Drawing.Size(370, 468);
            ControlLayout.TabIndex = 0;
            // 
            // bResult
            // 
            bResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bResult.Dock = System.Windows.Forms.DockStyle.Fill;
            bResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bResult.Location = new System.Drawing.Point(282, 379);
            bResult.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bResult.Name = "bResult";
            bResult.Size = new System.Drawing.Size(82, 82);
            bResult.TabIndex = 19;
            bResult.Text = "=";
            bResult.UseVisualStyleBackColor = false;
            bResult.Click += bResult_Click;
            // 
            // bPow
            // 
            bPow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bPow.Dock = System.Windows.Forms.DockStyle.Fill;
            bPow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bPow.Location = new System.Drawing.Point(190, 379);
            bPow.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bPow.Name = "bPow";
            bPow.Size = new System.Drawing.Size(80, 82);
            bPow.TabIndex = 18;
            bPow.Text = "x^2";
            bPow.UseVisualStyleBackColor = false;
            bPow.Click += bPow_Click;
            // 
            // btn0
            // 
            btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn0.Location = new System.Drawing.Point(98, 379);
            btn0.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(80, 82);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Btn_Number;
            // 
            // bDot
            // 
            bDot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bDot.Dock = System.Windows.Forms.DockStyle.Fill;
            bDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bDot.Location = new System.Drawing.Point(6, 379);
            bDot.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bDot.Name = "bDot";
            bDot.Size = new System.Drawing.Size(80, 82);
            bDot.TabIndex = 16;
            bDot.Text = ",";
            bDot.UseVisualStyleBackColor = false;
            bDot.Click += bDot_Click;
            // 
            // bPlus
            // 
            bPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            bPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bPlus.Location = new System.Drawing.Point(282, 286);
            bPlus.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bPlus.Name = "bPlus";
            bPlus.Size = new System.Drawing.Size(82, 79);
            bPlus.TabIndex = 15;
            bPlus.Text = "+";
            bPlus.UseVisualStyleBackColor = false;
            bPlus.Click += bPlus_Click;
            // 
            // btn3
            // 
            btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn3.Location = new System.Drawing.Point(190, 286);
            btn3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(80, 79);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Btn_Number;
            // 
            // btn2
            // 
            btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn2.Location = new System.Drawing.Point(98, 286);
            btn2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(80, 79);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Btn_Number;
            // 
            // btn1
            // 
            btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn1.Location = new System.Drawing.Point(6, 286);
            btn1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(80, 79);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Btn_Number;
            // 
            // bMinus
            // 
            bMinus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            bMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bMinus.Location = new System.Drawing.Point(282, 193);
            bMinus.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bMinus.Name = "bMinus";
            bMinus.Size = new System.Drawing.Size(82, 79);
            bMinus.TabIndex = 11;
            bMinus.Text = "-";
            bMinus.UseVisualStyleBackColor = false;
            bMinus.Click += bMinus_Click;
            // 
            // btn6
            // 
            btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn6.Location = new System.Drawing.Point(190, 193);
            btn6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(80, 79);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Btn_Number;
            // 
            // btn5
            // 
            btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn5.Location = new System.Drawing.Point(98, 193);
            btn5.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(80, 79);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Btn_Number;
            // 
            // btn4
            // 
            btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn4.Location = new System.Drawing.Point(6, 193);
            btn4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(80, 79);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Btn_Number;
            // 
            // bMultiple
            // 
            bMultiple.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            bMultiple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bMultiple.Location = new System.Drawing.Point(282, 100);
            bMultiple.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bMultiple.Name = "bMultiple";
            bMultiple.Size = new System.Drawing.Size(82, 79);
            bMultiple.TabIndex = 7;
            bMultiple.Text = "*";
            bMultiple.UseVisualStyleBackColor = false;
            bMultiple.Click += bMultiple_Click;
            // 
            // btn9
            // 
            btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn9.Location = new System.Drawing.Point(190, 100);
            btn9.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(80, 79);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Btn_Number;
            // 
            // btn8
            // 
            btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn8.Location = new System.Drawing.Point(98, 100);
            btn8.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(80, 79);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Btn_Number;
            // 
            // btn7
            // 
            btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn7.Location = new System.Drawing.Point(6, 100);
            btn7.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(80, 79);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Btn_Number;
            // 
            // bDevide
            // 
            bDevide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bDevide.Dock = System.Windows.Forms.DockStyle.Fill;
            bDevide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bDevide.Location = new System.Drawing.Point(282, 7);
            bDevide.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bDevide.Name = "bDevide";
            bDevide.Size = new System.Drawing.Size(82, 79);
            bDevide.TabIndex = 3;
            bDevide.Text = "/";
            bDevide.UseVisualStyleBackColor = false;
            bDevide.Click += bDevide_Click;
            // 
            // bSqrt
            // 
            bSqrt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            bSqrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bSqrt.Location = new System.Drawing.Point(190, 7);
            bSqrt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bSqrt.Name = "bSqrt";
            bSqrt.Size = new System.Drawing.Size(80, 79);
            bSqrt.TabIndex = 2;
            bSqrt.Text = "√";
            bSqrt.UseVisualStyleBackColor = false;
            bSqrt.Click += bSqrt_Click;
            // 
            // bSign
            // 
            bSign.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bSign.Dock = System.Windows.Forms.DockStyle.Fill;
            bSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bSign.Location = new System.Drawing.Point(98, 7);
            bSign.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bSign.Name = "bSign";
            bSign.Size = new System.Drawing.Size(80, 79);
            bSign.TabIndex = 1;
            bSign.Text = "+/-";
            bSign.UseVisualStyleBackColor = false;
            bSign.Click += bSign_Click;
            // 
            // bClear
            // 
            bClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bClear.Dock = System.Windows.Forms.DockStyle.Fill;
            bClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bClear.Location = new System.Drawing.Point(6, 7);
            bClear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bClear.Name = "bClear";
            bClear.Size = new System.Drawing.Size(80, 79);
            bClear.TabIndex = 0;
            bClear.Text = "A/C";
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_Click;
            // 
            // lInput
            // 
            lInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lInput.Dock = System.Windows.Forms.DockStyle.Fill;
            lInput.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lInput.Location = new System.Drawing.Point(3, 0);
            lInput.Name = "lInput";
            lInput.Size = new System.Drawing.Size(370, 83);
            lInput.TabIndex = 1;
            lInput.Text = "0";
            lInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 559);
            Controls.Add(MainLayout);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "CalculatorForm";
            Text = "Calculator";
            MainLayout.ResumeLayout(false);
            ControlLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel ControlLayout;
        private System.Windows.Forms.Label lInput;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.Button bPow;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button bMultiple;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button bDevide;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bSign;
        private System.Windows.Forms.Button bClear;
    }
}