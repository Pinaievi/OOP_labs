namespace Lab11
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
            point_btn = new Button();
            ColoredPointBtn = new Button();
            cout_label = new Label();
            LineBtn = new Button();
            ColLineBtn = new Button();
            PolyLineBtn = new Button();
            XtextBox = new TextBox();
            YtextBox = new TextBox();
            xCord_label = new Label();
            Ycord_label = new Label();
            ColortextBox = new TextBox();
            ColorLabel = new Label();
            label1 = new Label();
            LengthtextBox = new TextBox();
            label2 = new Label();
            AnglestextBox = new TextBox();
            SuspendLayout();
            // 
            // point_btn
            // 
            point_btn.Location = new Point(322, 120);
            point_btn.Name = "point_btn";
            point_btn.Size = new Size(215, 42);
            point_btn.TabIndex = 0;
            point_btn.Text = "Point standart constuctor";
            point_btn.UseVisualStyleBackColor = true;
            point_btn.Click += point_btn_Click;
            // 
            // ColoredPointBtn
            // 
            ColoredPointBtn.Location = new Point(204, 168);
            ColoredPointBtn.Name = "ColoredPointBtn";
            ColoredPointBtn.Size = new Size(215, 42);
            ColoredPointBtn.TabIndex = 1;
            ColoredPointBtn.Text = "ColoredPoint standart constructor";
            ColoredPointBtn.UseVisualStyleBackColor = true;
            ColoredPointBtn.Click += ColoredPointBtn_Click;
            // 
            // cout_label
            // 
            cout_label.AutoSize = true;
            cout_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cout_label.Location = new Point(31, 171);
            cout_label.Name = "cout_label";
            cout_label.Size = new Size(69, 21);
            cout_label.TabIndex = 3;
            cout_label.Text = "Huhwuh";
            // 
            // LineBtn
            // 
            LineBtn.Location = new Point(425, 168);
            LineBtn.Name = "LineBtn";
            LineBtn.Size = new Size(215, 42);
            LineBtn.TabIndex = 4;
            LineBtn.Text = "Line standart constructor";
            LineBtn.UseVisualStyleBackColor = true;
            LineBtn.Click += LineBtn_Click;
            // 
            // ColLineBtn
            // 
            ColLineBtn.Location = new Point(322, 216);
            ColLineBtn.Name = "ColLineBtn";
            ColLineBtn.Size = new Size(215, 42);
            ColLineBtn.TabIndex = 5;
            ColLineBtn.Text = "ColoredLine standart constructor";
            ColLineBtn.UseVisualStyleBackColor = true;
            ColLineBtn.Click += ColLineBtn_Click;
            // 
            // PolyLineBtn
            // 
            PolyLineBtn.Location = new Point(543, 216);
            PolyLineBtn.Name = "PolyLineBtn";
            PolyLineBtn.Size = new Size(215, 42);
            PolyLineBtn.TabIndex = 6;
            PolyLineBtn.Text = "PolyLine standart constructor";
            PolyLineBtn.UseVisualStyleBackColor = true;
            PolyLineBtn.Click += PolyLineBtn_Click;
            // 
            // XtextBox
            // 
            XtextBox.Location = new Point(204, 296);
            XtextBox.Name = "XtextBox";
            XtextBox.Size = new Size(100, 23);
            XtextBox.TabIndex = 7;
            // 
            // YtextBox
            // 
            YtextBox.Location = new Point(204, 335);
            YtextBox.Name = "YtextBox";
            YtextBox.Size = new Size(100, 23);
            YtextBox.TabIndex = 8;
            // 
            // xCord_label
            // 
            xCord_label.AutoSize = true;
            xCord_label.Location = new Point(149, 299);
            xCord_label.Name = "xCord_label";
            xCord_label.Size = new Size(49, 15);
            xCord_label.TabIndex = 9;
            xCord_label.Text = "X CORD";
            // 
            // Ycord_label
            // 
            Ycord_label.AutoSize = true;
            Ycord_label.Location = new Point(149, 338);
            Ycord_label.Name = "Ycord_label";
            Ycord_label.Size = new Size(49, 15);
            Ycord_label.TabIndex = 10;
            Ycord_label.Text = "Y CORD";
            // 
            // ColortextBox
            // 
            ColortextBox.Location = new Point(401, 296);
            ColortextBox.Name = "ColortextBox";
            ColortextBox.Size = new Size(100, 23);
            ColortextBox.TabIndex = 11;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(340, 299);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 15);
            ColorLabel.TabIndex = 12;
            ColorLabel.Text = "Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 341);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 14;
            label1.Text = "Length";
            // 
            // LengthtextBox
            // 
            LengthtextBox.Location = new Point(401, 338);
            LengthtextBox.Name = "LengthtextBox";
            LengthtextBox.Size = new Size(100, 23);
            LengthtextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 320);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 16;
            label2.Text = "Angles";
            // 
            // AnglestextBox
            // 
            AnglestextBox.Location = new Point(598, 317);
            AnglestextBox.Name = "AnglestextBox";
            AnglestextBox.Size = new Size(100, 23);
            AnglestextBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(AnglestextBox);
            Controls.Add(label1);
            Controls.Add(LengthtextBox);
            Controls.Add(ColorLabel);
            Controls.Add(ColortextBox);
            Controls.Add(Ycord_label);
            Controls.Add(xCord_label);
            Controls.Add(YtextBox);
            Controls.Add(XtextBox);
            Controls.Add(PolyLineBtn);
            Controls.Add(ColLineBtn);
            Controls.Add(LineBtn);
            Controls.Add(cout_label);
            Controls.Add(ColoredPointBtn);
            Controls.Add(point_btn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button point_btn;
        private Button ColoredPointBtn;
        private Label cout_label;
        private Button LineBtn;
        private Button ColLineBtn;
        private Button PolyLineBtn;
        private TextBox XtextBox;
        private TextBox YtextBox;
        private Label xCord_label;
        private Label Ycord_label;
        private TextBox ColortextBox;
        private Label ColorLabel;
        private Label label1;
        private TextBox LengthtextBox;
        private Label label2;
        private TextBox AnglestextBox;
    }
}