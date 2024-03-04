
namespace WForm2
{
    partial class NoteForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            input_note_textBox = new TextBox();
            label3 = new Label();
            input_date_textBox = new TextBox();
            remove_note_btn = new Button();
            add_task_btn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Bisque;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(105, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(334, 368);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tomato;
            label1.Font = new Font("Rockwell", 16F);
            label1.Location = new Point(223, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Rockwell", 15.75F);
            label2.Location = new Point(545, 42);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 2;
            label2.Text = "Input note";
            // 
            // input_note_textBox
            // 
            input_note_textBox.Location = new Point(681, 45);
            input_note_textBox.Name = "input_note_textBox";
            input_note_textBox.Size = new Size(179, 23);
            input_note_textBox.TabIndex = 3;
            input_note_textBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 15.75F);
            label3.Location = new Point(545, 90);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 4;
            label3.Text = "Input desc";
            // 
            // input_date_textBox
            // 
            input_date_textBox.Location = new Point(681, 92);
            input_date_textBox.Name = "input_date_textBox";
            input_date_textBox.Size = new Size(179, 23);
            input_date_textBox.TabIndex = 5;
            // 
            // remove_note_btn
            // 
            remove_note_btn.BackColor = Color.LightCoral;
            remove_note_btn.Enabled = false;
            remove_note_btn.Font = new Font("Century Gothic", 15.75F);
            remove_note_btn.Location = new Point(464, 271);
            remove_note_btn.Name = "remove_note_btn";
            remove_note_btn.Size = new Size(174, 37);
            remove_note_btn.TabIndex = 6;
            remove_note_btn.Text = "Remove note";
            remove_note_btn.UseVisualStyleBackColor = false;
            remove_note_btn.Click += Remove_note_btn_Click;
            // 
            // add_task_btn
            // 
            add_task_btn.BackColor = Color.LightGreen;
            add_task_btn.Font = new Font("Century Gothic", 15.75F);
            add_task_btn.Location = new Point(545, 148);
            add_task_btn.Name = "add_task_btn";
            add_task_btn.Size = new Size(315, 38);
            add_task_btn.TabIndex = 7;
            add_task_btn.Text = "Task completed";
            add_task_btn.UseVisualStyleBackColor = false;
            add_task_btn.Click += Add_task_btn_Click;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(949, 506);
            Controls.Add(add_task_btn);
            Controls.Add(remove_note_btn);
            Controls.Add(input_date_textBox);
            Controls.Add(label3);
            Controls.Add(input_note_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "NoteForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox input_note_textBox;
        private Label label3;
        private TextBox input_date_textBox;
        private Button remove_note_btn;
        private Button add_task_btn;
        private System.Windows.Forms.Timer timer1;
    }
}
