namespace С__Lab10
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
            textlabel_1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Row_textbox = new TextBox();
            Column_textbox = new TextBox();
            MIN_textbox = new TextBox();
            MAX_textbox = new TextBox();
            createMatrix_button = new Button();
            sortMatrix_btn = new Button();
            FirstTaskResultLabel = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textlabel_1
            // 
            textlabel_1.AutoSize = true;
            textlabel_1.Font = new Font("Comic Sans MS", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textlabel_1.Location = new Point(112, 9);
            textlabel_1.Name = "textlabel_1";
            textlabel_1.Size = new Size(338, 46);
            textlabel_1.TabIndex = 0;
            textlabel_1.Text = "Параметри Матриці";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 102);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 1;
            label1.Text = "К-сть Рядків:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 158);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 2;
            label2.Text = "К-сть Стовбців:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(389, 102);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 3;
            label3.Text = "MIN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(389, 158);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 4;
            label4.Text = "MAX:";
            // 
            // Row_textbox
            // 
            Row_textbox.Location = new Point(150, 102);
            Row_textbox.Name = "Row_textbox";
            Row_textbox.Size = new Size(100, 23);
            Row_textbox.TabIndex = 5;
            // 
            // Column_textbox
            // 
            Column_textbox.Location = new Point(150, 158);
            Column_textbox.Name = "Column_textbox";
            Column_textbox.Size = new Size(100, 23);
            Column_textbox.TabIndex = 6;
            // 
            // MIN_textbox
            // 
            MIN_textbox.Location = new Point(447, 102);
            MIN_textbox.Name = "MIN_textbox";
            MIN_textbox.Size = new Size(100, 23);
            MIN_textbox.TabIndex = 7;
            // 
            // MAX_textbox
            // 
            MAX_textbox.Location = new Point(447, 158);
            MAX_textbox.Name = "MAX_textbox";
            MAX_textbox.Size = new Size(100, 23);
            MAX_textbox.TabIndex = 8;
            // 
            // createMatrix_button
            // 
            createMatrix_button.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createMatrix_button.Location = new Point(24, 197);
            createMatrix_button.Name = "createMatrix_button";
            createMatrix_button.Size = new Size(226, 84);
            createMatrix_button.TabIndex = 9;
            createMatrix_button.Text = "Створити матрицю";
            createMatrix_button.UseVisualStyleBackColor = true;
            createMatrix_button.Click += createMatrix_button_Click;
            // 
            // sortMatrix_btn
            // 
            sortMatrix_btn.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sortMatrix_btn.Location = new Point(321, 197);
            sortMatrix_btn.Name = "sortMatrix_btn";
            sortMatrix_btn.Size = new Size(226, 84);
            sortMatrix_btn.TabIndex = 10;
            sortMatrix_btn.Text = "Сортувати матрицю";
            sortMatrix_btn.UseVisualStyleBackColor = true;
            sortMatrix_btn.Click += sortMatrix_btn_Click;
            // 
            // FirstTaskResultLabel
            // 
            FirstTaskResultLabel.AutoSize = true;
            FirstTaskResultLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstTaskResultLabel.Location = new Point(312, 296);
            FirstTaskResultLabel.Name = "FirstTaskResultLabel";
            FirstTaskResultLabel.Size = new Size(24, 23);
            FirstTaskResultLabel.TabIndex = 11;
            FirstTaskResultLabel.Text = "-1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(165, 296);
            label5.Name = "label5";
            label5.Size = new Size(141, 23);
            label5.TabIndex = 12;
            label5.Text = "Перше Завдання:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(24, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(523, 174);
            dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 535);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(FirstTaskResultLabel);
            Controls.Add(sortMatrix_btn);
            Controls.Add(createMatrix_button);
            Controls.Add(MAX_textbox);
            Controls.Add(MIN_textbox);
            Controls.Add(Column_textbox);
            Controls.Add(Row_textbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textlabel_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textlabel_1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Row_textbox;
        private TextBox Column_textbox;
        private TextBox MIN_textbox;
        private TextBox MAX_textbox;
        private Button createMatrix_button;
        private Button sortMatrix_btn;
        private Label FirstTaskResultLabel;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
