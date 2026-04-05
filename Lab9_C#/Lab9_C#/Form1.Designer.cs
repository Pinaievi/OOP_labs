namespace Lab9_C_
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
            countryTextBox = new TextBox();
            zipcodeTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            StaticObjectCounter = new Label();
            SuspendLayout();
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(97, 76);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(100, 23);
            countryTextBox.TabIndex = 0;
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.Location = new Point(97, 128);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(100, 23);
            zipcodeTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(233, 88);
            button1.Name = "button1";
            button1.Size = new Size(111, 58);
            button1.TabIndex = 3;
            button1.Text = "Сторити новий обь'єкт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 79);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Країна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 131);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Zip Код:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 219);
            label3.Name = "label3";
            label3.Size = new Size(193, 15);
            label3.TabIndex = 6;
            label3.Text = "Загальна кількість доданих адрес:";
            // 
            // StaticObjectCounter
            // 
            StaticObjectCounter.AutoSize = true;
            StaticObjectCounter.Location = new Point(233, 219);
            StaticObjectCounter.Name = "StaticObjectCounter";
            StaticObjectCounter.Size = new Size(29, 15);
            StaticObjectCounter.TabIndex = 7;
            StaticObjectCounter.Text = "Null";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 276);
            Controls.Add(StaticObjectCounter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(zipcodeTextBox);
            Controls.Add(countryTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox countryTextBox;
        private TextBox zipcodeTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label StaticObjectCounter;
    }
}
