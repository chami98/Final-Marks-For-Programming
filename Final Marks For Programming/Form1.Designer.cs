﻿
namespace Final_Marks_For_Programming
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateFinalGrade = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.studentName = new System.Windows.Forms.TextBox();
            this.inputMajorTest1 = new System.Windows.Forms.TextBox();
            this.inputClassTest = new System.Windows.Forms.TextBox();
            this.inputExamMark = new System.Windows.Forms.TextBox();
            this.inputMajorTest2 = new System.Windows.Forms.TextBox();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " Enter Following marks as a percentage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major Test 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exam Mark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Major Test 2";
            // 
            // calculateFinalGrade
            // 
            this.calculateFinalGrade.Location = new System.Drawing.Point(270, 217);
            this.calculateFinalGrade.Name = "calculateFinalGrade";
            this.calculateFinalGrade.Size = new System.Drawing.Size(176, 23);
            this.calculateFinalGrade.TabIndex = 6;
            this.calculateFinalGrade.Text = "Calculate Final Grade";
            this.calculateFinalGrade.UseVisualStyleBackColor = true;
            this.calculateFinalGrade.Click += new System.EventHandler(this.calculateFinalGrade_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Final Mark";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Grade";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(313, 327);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 23);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(169, 22);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(242, 22);
            this.studentName.TabIndex = 10;
            // 
            // inputMajorTest1
            // 
            this.inputMajorTest1.Location = new System.Drawing.Point(148, 137);
            this.inputMajorTest1.Name = "inputMajorTest1";
            this.inputMajorTest1.Size = new System.Drawing.Size(50, 22);
            this.inputMajorTest1.TabIndex = 11;
            // 
            // inputClassTest
            // 
            this.inputClassTest.Location = new System.Drawing.Point(148, 178);
            this.inputClassTest.Name = "inputClassTest";
            this.inputClassTest.Size = new System.Drawing.Size(50, 22);
            this.inputClassTest.TabIndex = 12;
            // 
            // inputExamMark
            // 
            this.inputExamMark.Location = new System.Drawing.Point(148, 217);
            this.inputExamMark.Name = "inputExamMark";
            this.inputExamMark.Size = new System.Drawing.Size(50, 22);
            this.inputExamMark.TabIndex = 13;
            // 
            // inputMajorTest2
            // 
            this.inputMajorTest2.Location = new System.Drawing.Point(396, 137);
            this.inputMajorTest2.Name = "inputMajorTest2";
            this.inputMajorTest2.Size = new System.Drawing.Size(50, 22);
            this.inputMajorTest2.TabIndex = 14;
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.ForeColor = System.Drawing.Color.Red;
            this.lblFinalMark.Location = new System.Drawing.Point(145, 283);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(36, 17);
            this.lblFinalMark.TabIndex = 15;
            this.lblFinalMark.Text = "0.00\r\n";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.ForeColor = System.Drawing.Color.Red;
            this.lblGrade.Location = new System.Drawing.Point(145, 333);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(31, 17);
            this.lblGrade.TabIndex = 16;
            this.lblGrade.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 456);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblFinalMark);
            this.Controls.Add(this.inputMajorTest2);
            this.Controls.Add(this.inputExamMark);
            this.Controls.Add(this.inputClassTest);
            this.Controls.Add(this.inputMajorTest1);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateFinalGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Final Marks For Programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateFinalGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox inputMajorTest1;
        private System.Windows.Forms.TextBox inputClassTest;
        private System.Windows.Forms.TextBox inputExamMark;
        private System.Windows.Forms.TextBox inputMajorTest2;
        private System.Windows.Forms.Label lblFinalMark;
        private System.Windows.Forms.Label lblGrade;
    }
}

