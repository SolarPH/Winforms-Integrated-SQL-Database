namespace IntegratedDatabase
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
            label1 = new Label();
            label2 = new Label();
            txt_Text = new TextBox();
            num_Number = new NumericUpDown();
            btn_Insert = new Button();
            ((System.ComponentModel.ISupportInitialize)num_Number).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Number:";
            // 
            // txt_Text
            // 
            txt_Text.Location = new Point(49, 6);
            txt_Text.Name = "txt_Text";
            txt_Text.Size = new Size(100, 23);
            txt_Text.TabIndex = 2;
            // 
            // num_Number
            // 
            num_Number.Location = new Point(250, 6);
            num_Number.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_Number.Name = "num_Number";
            num_Number.Size = new Size(120, 23);
            num_Number.TabIndex = 3;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(12, 35);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(358, 23);
            btn_Insert.TabIndex = 4;
            btn_Insert.Text = "Insert to Database";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 68);
            Controls.Add(btn_Insert);
            Controls.Add(num_Number);
            Controls.Add(txt_Text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)num_Number).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Text;
        private NumericUpDown num_Number;
        private Button btn_Insert;
    }
}
