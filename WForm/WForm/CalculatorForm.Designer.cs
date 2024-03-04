namespace WForm
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
            components = new System.ComponentModel.Container();
            result_label = new Label();
            plus_btn = new Button();
            textBox_1 = new TextBox();
            sumbit_btn = new Button();
            minus_btn = new Button();
            divide_btn = new Button();
            multi_btn = new Button();
            btn_8 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_7 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_0 = new Button();
            btn_9 = new Button();
            textBox_2 = new TextBox();
            textBox_sign = new TextBox();
            radio_btn_1 = new RadioButton();
            radio_btn_2 = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.BackColor = SystemColors.ActiveCaption;
            result_label.Font = new Font("Verdana", 14F);
            result_label.Location = new Point(362, 80);
            result_label.Name = "result_label";
            result_label.Size = new Size(69, 23);
            result_label.TabIndex = 0;
            result_label.Text = "Result";
            // 
            // plus_btn
            // 
            plus_btn.Location = new Point(286, 127);
            plus_btn.Name = "plus_btn";
            plus_btn.Size = new Size(27, 23);
            plus_btn.TabIndex = 1;
            plus_btn.Text = "+";
            plus_btn.UseVisualStyleBackColor = true;
            plus_btn.Click += plus_btn_Click;
            // 
            // textBox_1
            // 
            textBox_1.Location = new Point(167, 80);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(58, 23);
            textBox_1.TabIndex = 2;
            textBox_1.TextChanged += textBox1_TextChanged;
            // 
            // sumbit_btn
            // 
            sumbit_btn.Enabled = false;
            sumbit_btn.Location = new Point(345, 127);
            sumbit_btn.Name = "sumbit_btn";
            sumbit_btn.Size = new Size(100, 111);
            sumbit_btn.TabIndex = 3;
            sumbit_btn.Text = "Submit";
            sumbit_btn.UseVisualStyleBackColor = true;
            sumbit_btn.Click += submit_btn_Click;
            // 
            // minus_btn
            // 
            minus_btn.Location = new Point(286, 156);
            minus_btn.Name = "minus_btn";
            minus_btn.Size = new Size(27, 23);
            minus_btn.TabIndex = 9;
            minus_btn.Text = "-";
            minus_btn.UseVisualStyleBackColor = true;
            minus_btn.Click += minus_btn_Click;
            // 
            // divide_btn
            // 
            divide_btn.Location = new Point(286, 214);
            divide_btn.Name = "divide_btn";
            divide_btn.Size = new Size(27, 23);
            divide_btn.TabIndex = 11;
            divide_btn.Text = "/";
            divide_btn.UseVisualStyleBackColor = true;
            divide_btn.Click += divide_btn_Click;
            // 
            // multi_btn
            // 
            multi_btn.FlatStyle = FlatStyle.System;
            multi_btn.Location = new Point(286, 185);
            multi_btn.Name = "multi_btn";
            multi_btn.Size = new Size(27, 23);
            multi_btn.TabIndex = 12;
            multi_btn.Text = "*";
            multi_btn.TextAlign = ContentAlignment.BottomCenter;
            multi_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            multi_btn.UseVisualStyleBackColor = true;
            multi_btn.Click += multi_btn_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(198, 186);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(27, 23);
            btn_8.TabIndex = 13;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(231, 157);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(27, 23);
            btn_6.TabIndex = 14;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(198, 156);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(27, 23);
            btn_5.TabIndex = 15;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(165, 156);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(27, 23);
            btn_4.TabIndex = 16;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(165, 186);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(27, 23);
            btn_7.TabIndex = 17;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(231, 127);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(27, 23);
            btn_3.TabIndex = 18;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(198, 127);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(27, 23);
            btn_2.TabIndex = 19;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(165, 127);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(27, 23);
            btn_1.TabIndex = 20;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(198, 215);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(27, 23);
            btn_0.TabIndex = 21;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(231, 186);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(27, 23);
            btn_9.TabIndex = 22;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // textBox_2
            // 
            textBox_2.Enabled = false;
            textBox_2.Location = new Point(257, 80);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(58, 23);
            textBox_2.TabIndex = 23;
            textBox_2.TextChanged += textBox2_TextChanged;
            // 
            // textBox_sign
            // 
            textBox_sign.Location = new Point(231, 80);
            textBox_sign.Name = "textBox_sign";
            textBox_sign.Size = new Size(20, 23);
            textBox_sign.TabIndex = 24;
            textBox_sign.TextChanged += textBox3_TextChanged;
            // 
            // radio_btn_1
            // 
            radio_btn_1.AutoSize = true;
            radio_btn_1.BackColor = SystemColors.ActiveCaption;
            radio_btn_1.Checked = true;
            radio_btn_1.Font = new Font("Segoe UI", 8F);
            radio_btn_1.Location = new Point(167, 57);
            radio_btn_1.Name = "radio_btn_1";
            radio_btn_1.Size = new Size(58, 17);
            radio_btn_1.TabIndex = 25;
            radio_btn_1.TabStop = true;
            radio_btn_1.Text = "Num 1";
            radio_btn_1.UseVisualStyleBackColor = false;
            radio_btn_1.CheckedChanged += radio_btn_1_CheckedChanged;
            // 
            // radio_btn_2
            // 
            radio_btn_2.AutoSize = true;
            radio_btn_2.BackColor = SystemColors.ActiveCaption;
            radio_btn_2.Font = new Font("Segoe UI", 8F);
            radio_btn_2.Location = new Point(257, 57);
            radio_btn_2.Name = "radio_btn_2";
            radio_btn_2.Size = new Size(58, 17);
            radio_btn_2.TabIndex = 26;
            radio_btn_2.TabStop = true;
            radio_btn_2.Text = "Num 2";
            radio_btn_2.UseVisualStyleBackColor = false;
            radio_btn_2.CheckedChanged += radio_btn_2_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 336);
            Controls.Add(radio_btn_2);
            Controls.Add(radio_btn_1);
            Controls.Add(textBox_sign);
            Controls.Add(textBox_2);
            Controls.Add(btn_9);
            Controls.Add(btn_0);
            Controls.Add(btn_1);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Controls.Add(btn_7);
            Controls.Add(btn_4);
            Controls.Add(btn_5);
            Controls.Add(btn_6);
            Controls.Add(btn_8);
            Controls.Add(multi_btn);
            Controls.Add(divide_btn);
            Controls.Add(minus_btn);
            Controls.Add(sumbit_btn);
            Controls.Add(textBox_1);
            Controls.Add(plus_btn);
            Controls.Add(result_label);
            Name = "Form1";
            Text = "Calculator_Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result_label;
        private Button plus_btn;
        private TextBox textBox_1;
        private Button sumbit_btn;
        private Button minus_btn;
        private Button divide_btn;
        private Button multi_btn;
        private Button btn_8;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_7;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_0;
        private Button btn_9;
        private TextBox textBox_2;
        private TextBox textBox_sign;
        private RadioButton radio_btn_1;
        private RadioButton radio_btn_2;
        private System.Windows.Forms.Timer timer1;
    }
}
