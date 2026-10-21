using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(6, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(6, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(323, 163);
            this.Display.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(87, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "AC";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(168, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 71);
            this.button3.TabIndex = 11;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(249, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 71);
            this.button4.TabIndex = 12;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(249, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 71);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(168, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 71);
            this.button6.TabIndex = 15;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(87, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 71);
            this.button7.TabIndex = 14;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(6, 263);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 71);
            this.button8.TabIndex = 13;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(249, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 71);
            this.button9.TabIndex = 20;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(168, 340);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 71);
            this.button10.TabIndex = 19;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(87, 340);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 71);
            this.button11.TabIndex = 18;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(6, 340);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 71);
            this.button12.TabIndex = 17;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(249, 417);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 71);
            this.button13.TabIndex = 24;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(168, 417);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 71);
            this.button14.TabIndex = 23;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(87, 417);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 71);
            this.button15.TabIndex = 22;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(6, 417);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 71);
            this.button16.TabIndex = 21;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(249, 494);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 71);
            this.button17.TabIndex = 28;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(168, 494);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 71);
            this.button18.TabIndex = 27;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(87, 494);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 71);
            this.button19.TabIndex = 26;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.allBtnClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(6, 494);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 71);
            this.button20.TabIndex = 25;
            this.button20.Text = "+/-";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(333, 575);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox Display;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}