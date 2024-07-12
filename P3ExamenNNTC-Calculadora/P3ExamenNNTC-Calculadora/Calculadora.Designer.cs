using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P3ExamenNNTC_Calculadora
{
    partial class Calculadora
    {
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
            MainLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnPrctg = new Button();
            btnSum = new Button();
            btnSbst = new Button();
            btnMltp = new Button();
            btnDvs = new Button();
            btnEquals = new Button();
            btnBack = new Button();
            btnCE = new Button();
            btnC = new Button();
            resContainer = new TableLayoutPanel();
            resBox = new TextBox();
            lbsRes = new Label();
            MainLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            resContainer.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayout
            // 
            MainLayout.ColumnCount = 1;
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            MainLayout.Controls.Add(resContainer, 0, 0);
            MainLayout.Dock = DockStyle.Fill;
            MainLayout.Location = new Point(0, 0);
            MainLayout.Margin = new Padding(5);
            MainLayout.Name = "MainLayout";
            MainLayout.RowCount = 2;
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4305954F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 83.5694046F));
            MainLayout.Size = new Size(482, 353);
            MainLayout.TabIndex = 0;
            MainLayout.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn0, 0, 3);
            tableLayoutPanel1.Controls.Add(btnDot, 1, 3);
            tableLayoutPanel1.Controls.Add(btnPrctg, 4, 1);
            tableLayoutPanel1.Controls.Add(btnSum, 3, 2);
            tableLayoutPanel1.Controls.Add(btnSbst, 3, 3);
            tableLayoutPanel1.Controls.Add(btnMltp, 4, 2);
            tableLayoutPanel1.Controls.Add(btnDvs, 4, 3);
            tableLayoutPanel1.Controls.Add(btnEquals, 2, 3);
            tableLayoutPanel1.Controls.Add(btnBack, 3, 1);
            tableLayoutPanel1.Controls.Add(btnCE, 3, 0);
            tableLayoutPanel1.Controls.Add(btnC, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(476, 289);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(193, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(89, 66);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.UseWaitCursor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(98, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 66);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.UseWaitCursor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 66);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.UseWaitCursor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 75);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 66);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.UseWaitCursor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(98, 75);
            btn5.Name = "btn5";
            btn5.Size = new Size(89, 66);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.UseWaitCursor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(193, 75);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 66);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.UseWaitCursor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 147);
            btn7.Name = "btn7";
            btn7.Size = new Size(89, 66);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.UseWaitCursor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(98, 147);
            btn8.Name = "btn8";
            btn8.Size = new Size(89, 66);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.UseWaitCursor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(193, 147);
            btn9.Name = "btn9";
            btn9.Size = new Size(89, 66);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.UseWaitCursor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(3, 219);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 67);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.UseWaitCursor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.Location = new Point(98, 219);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(89, 67);
            btnDot.TabIndex = 10;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.UseWaitCursor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnPrctg
            // 
            btnPrctg.Dock = DockStyle.Fill;
            btnPrctg.Location = new Point(383, 75);
            btnPrctg.Name = "btnPrctg";
            btnPrctg.Size = new Size(90, 66);
            btnPrctg.TabIndex = 11;
            btnPrctg.Text = "%";
            btnPrctg.UseVisualStyleBackColor = true;
            btnPrctg.UseWaitCursor = true;
            btnPrctg.Click += btnPrctg_Click;
            // 
            // btnSum
            // 
            btnSum.Dock = DockStyle.Fill;
            btnSum.Location = new Point(288, 147);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(89, 66);
            btnSum.TabIndex = 12;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.UseWaitCursor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnSbst
            // 
            btnSbst.Dock = DockStyle.Fill;
            btnSbst.Location = new Point(288, 219);
            btnSbst.Name = "btnSbst";
            btnSbst.Size = new Size(89, 67);
            btnSbst.TabIndex = 13;
            btnSbst.Text = "-";
            btnSbst.UseVisualStyleBackColor = true;
            btnSbst.UseWaitCursor = true;
            btnSbst.Click += btnSbst_Click;
            // 
            // btnMltp
            // 
            btnMltp.Dock = DockStyle.Fill;
            btnMltp.Location = new Point(383, 147);
            btnMltp.Name = "btnMltp";
            btnMltp.Size = new Size(90, 66);
            btnMltp.TabIndex = 15;
            btnMltp.Text = "X";
            btnMltp.UseVisualStyleBackColor = true;
            btnMltp.UseWaitCursor = true;
            btnMltp.Click += btnMltp_Click;
            // 
            // btnDvs
            // 
            btnDvs.Dock = DockStyle.Fill;
            btnDvs.Location = new Point(383, 219);
            btnDvs.Name = "btnDvs";
            btnDvs.Size = new Size(90, 67);
            btnDvs.TabIndex = 16;
            btnDvs.Text = "/";
            btnDvs.UseVisualStyleBackColor = true;
            btnDvs.UseWaitCursor = true;
            btnDvs.Click += btnDvs_Click;
            // 
            // btnEquals
            // 
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Location = new Point(193, 219);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(89, 67);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.UseWaitCursor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(288, 75);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 66);
            btnBack.TabIndex = 18;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.UseWaitCursor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.Location = new Point(288, 3);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(89, 66);
            btnCE.TabIndex = 19;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.UseWaitCursor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.Location = new Point(383, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(90, 66);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.UseWaitCursor = true;
            btnC.Click += btnC_Click;
            // 
            // resContainer
            // 
            resContainer.ColumnCount = 1;
            resContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            resContainer.Controls.Add(resBox, 0, 1);
            resContainer.Controls.Add(lbsRes, 0, 0);
            resContainer.Dock = DockStyle.Fill;
            resContainer.Location = new Point(3, 3);
            resContainer.Name = "resContainer";
            resContainer.RowCount = 2;
            resContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            resContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            resContainer.Size = new Size(476, 52);
            resContainer.TabIndex = 2;
            resContainer.UseWaitCursor = true;
            // 
            // resBox
            // 
            resBox.Dock = DockStyle.Fill;
            resBox.Location = new Point(3, 29);
            resBox.Name = "resBox";
            resBox.Size = new Size(470, 27);
            resBox.TabIndex = 0;
            resBox.TextAlign = HorizontalAlignment.Right;
            resBox.UseWaitCursor = true;
            // 
            // lbsRes
            // 
            lbsRes.AutoSize = true;
            lbsRes.Dock = DockStyle.Fill;
            lbsRes.Location = new Point(3, 0);
            lbsRes.Name = "lbsRes";
            lbsRes.Size = new Size(470, 26);
            lbsRes.TabIndex = 1;
            lbsRes.TextAlign = ContentAlignment.TopRight;
            lbsRes.UseWaitCursor = true;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(MainLayout);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            UseWaitCursor = true;
            MainLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            resContainer.ResumeLayout(false);
            resContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
        private Button btnPrctg;
        private Button btnSum;
        private Button btnSbst;
        private Button btnMltp;
        private Button btnDvs;
        private Button btnEquals;
        private TableLayoutPanel resContainer;
        private TextBox resBox;
        private Button btnBack;
        private Button btnCE;
        private Label lbsRes;
        private Button btnC;
    }
}