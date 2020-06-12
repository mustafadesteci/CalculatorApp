using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            //TextBox
            this.TextBox = new System.Windows.Forms.TextBox();

            //Buttons
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multiplion = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();

            //additions for fixed size
            this.border = new System.Windows.Forms.Label();                 
            this.SuspendLayout();

            //
            //TextBox
            //
            this.TextBox.Location = new System.Drawing.Point(200, 30);
            this.TextBox.Size = new System.Drawing.Size(200,60);
            

            //for multiple lines of Textbox
            //=> (Yukaridaki size metodunda en sadece bir satır için geçerlidir.)
            //=> (it applies only to one line,in the size method above)
            this.TextBox.Multiline = MultilineStringConverter.Equals(1, 1);
            this.TextBox.TextAlign = HorizontalAlignment.Center;
             
            //
            //button 0
            //
            this.zero.Location = new System.Drawing.Point(250,290);
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.Text = "0";
            this.zero.Click += new System.EventHandler(this.zero_Click);

            //
            //button 1
            //
            this.one.Location = new System.Drawing.Point(200, 240);
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.Text = "1";
            this.one.Click += new System.EventHandler(this.one_Click);

            //
            //button 2
            //
            this.two.Location = new System.Drawing.Point(250, 240);
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.Text = "2";
            this.two.Click += new System.EventHandler(this.two_Click);

            //
            //button 3
            //
            this.three.Location = new System.Drawing.Point(300, 240);
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.Text = "3";
            this.three.Click += new System.EventHandler(this.three_Click);

            //
            //button 4
            //
            this.four.Location = new System.Drawing.Point(200, 190);
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.Text = "4";
            this.four.Click += new System.EventHandler(this.four_Click);

            //
            //button 5
            //
            this.five.Location = new System.Drawing.Point(250, 190);
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.Text = "5";
            this.five.Click += new System.EventHandler(this.five_Click);

            //
            //button 6
            //
            this.six.Location = new System.Drawing.Point(300, 190);
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.Text = "6";
            this.six.Click += new System.EventHandler(this.six_Click);

            //
            //button 7
            //
            this.seven.Location = new System.Drawing.Point(200, 140);
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.Text = "7";         
            this.seven.Click += new System.EventHandler(this.seven_Click);

            //
            //button 8
            //
            this.eight.Location = new System.Drawing.Point(250, 140);
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.Text = "8";
            this.eight.Click += new System.EventHandler(this.eight_Click);

            //
            //button 9
            //
            this.nine.Location = new System.Drawing.Point(300, 140);
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.Text = "9";
            this.nine.Click += new System.EventHandler(this.nine_Click);


            //
            //button add
            //
            this.add.Location = new System.Drawing.Point(350,90);
            this.add.Size = new System.Drawing.Size(50, 100);
            this.add.Text = "+";
            this.add.Click += new System.EventHandler(this.add_Click);

            //
            //button sub
            //
            this.sub.Location = new System.Drawing.Point(300, 90);
            this.sub.Size = new System.Drawing.Size(50, 50);
            this.sub.Text = "-";
            this.sub.Click += new System.EventHandler(this.sub_Click);

            //
            //button multiplion
            //
            this.multiplion.Location = new System.Drawing.Point(250, 90);
            this.multiplion.Size = new System.Drawing.Size(50, 50);
            this.multiplion.Text = "*";
            this.multiplion.Click += new System.EventHandler(this.multiplion_Click);

            //
            //button div
            //
            this.div.Location = new System.Drawing.Point(200, 90);
            this.div.Size = new System.Drawing.Size(50, 50);
            this.div.Text = "/";
            this.div.Click += new System.EventHandler(this.div_Click);

            //
            //button clear
            //
            this.clear.Location = new System.Drawing.Point(350, 190);
            this.clear.Size = new System.Drawing.Size(50, 150);
            this.clear.Text = "C";
            this.clear.Click += new System.EventHandler(this.clear_Click);

            //
            //button dot
            //
            this.dot.Location = new System.Drawing.Point(200, 290);
            this.dot.Size = new System.Drawing.Size(50, 50);
            this.dot.Text = ".";
            this.dot.Click += new System.EventHandler(this.dot_Click);

            //
            //button equals
            //
            this.equals.Location = new System.Drawing.Point(300, 290);
            this.equals.Size = new System.Drawing.Size(50, 50);
            this.equals.Text = "=";
            this.equals.Click += new System.EventHandler(this.equals_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.BackColor = Color.GhostWhite;
            this.Name = "Form1";
            this.Text = "CALCULATOR made by Mustafa Desteci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

            //additions to the form for fixed size
            this.border.Location = new System.Drawing.Point(700, 300);       
            this.border.Size = new System.Drawing.Size(800, 500);       
            this.Controls.Add(border);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
       
            //buttons and textbox additions to the form
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.multiplion);
            this.Controls.Add(this.div);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.equals);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multiplion;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label border;
       
                

    }
}

