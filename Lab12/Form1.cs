using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;



namespace Lab11
{
    interface IPointInfo
    {
        string GetFullDetails();
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void point_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XtextBox.Text) || string.IsNullOrWhiteSpace(YtextBox.Text))
            {
                mainPoint a = new mainPoint();

                cout_label.Text = a.Printer();
            }
            else
            {
                try
                {
                    int X_Cord = Int32.Parse(XtextBox.Text);
                    int Y_Cord = Int32.Parse(YtextBox.Text);

                    mainPoint a = new mainPoint(X_Cord, Y_Cord);

                    cout_label.Text = a.Printer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ColoredPointBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XtextBox.Text) || string.IsNullOrWhiteSpace(YtextBox.Text) || string.IsNullOrWhiteSpace(ColortextBox.Text))
            {
                ColoredPoint a = new ColoredPoint();

                cout_label.Text = a.Printer();
            }
            else
            {
                try
                {
                    int X_Cord = Int32.Parse(XtextBox.Text);
                    int Y_Cord = Int32.Parse(YtextBox.Text);

                    ColoredPoint a = new ColoredPoint(X_Cord, Y_Cord, ColortextBox.Text);

                    cout_label.Text = a.Printer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XtextBox.Text) || string.IsNullOrWhiteSpace(YtextBox.Text) || string.IsNullOrWhiteSpace(LengthtextBox.Text))
            {
                Line a = new Line();

                cout_label.Text = a.Printer();
            }
            else
            {
                try
                {
                    int X_Cord = Int32.Parse(XtextBox.Text);
                    int Y_Cord = Int32.Parse(YtextBox.Text);
                    int Length = Int32.Parse(LengthtextBox.Text);
                    int angle = Int32.Parse(AnglestextBox.Text);

                    Line a = new Line(X_Cord, Y_Cord, angle, Length);

                    cout_label.Text = a.Printer();

                    a.LastPointer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ColLineBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XtextBox.Text) || string.IsNullOrWhiteSpace(YtextBox.Text) || string.IsNullOrWhiteSpace(LengthtextBox.Text) || string.IsNullOrWhiteSpace(ColortextBox.Text))
            {
                ColoredLine a = new ColoredLine();

                cout_label.Text = a.Printer();
            }
            else
            {
                try
                {
                    int X_Cord = Int32.Parse(XtextBox.Text);
                    int Y_Cord = Int32.Parse(YtextBox.Text);
                    int Length = Int32.Parse(LengthtextBox.Text);

                    ColoredLine a = new ColoredLine(X_Cord, Y_Cord, Length, ColortextBox.Text);

                    cout_label.Text = a.Printer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PolyLineBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(XtextBox.Text) || string.IsNullOrWhiteSpace(YtextBox.Text) || string.IsNullOrWhiteSpace(LengthtextBox.Text) || string.IsNullOrWhiteSpace(AnglestextBox.Text))
            {
                PolyLine a = new PolyLine();

                cout_label.Text = a.Printer();
            }
            else
            {
                try
                {
                    int X_Cord = Int32.Parse(XtextBox.Text);
                    int Y_Cord = Int32.Parse(YtextBox.Text);
                    int Length = Int32.Parse(LengthtextBox.Text);
                    int Angles = Int32.Parse(AnglestextBox.Text);

                    PolyLine a = new PolyLine(X_Cord, Y_Cord, Length, Angles);

                    cout_label.Text = a.Printer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RunArrayLogic_Click(object sender, EventArgs e)
        {
            try
            {
                mainPoint[] points = new mainPoint[4];
                points[0] = new mainPoint(10, 20);
                points[1] = new ColoredPoint(5, 5, "Blue");

                for (int i = 0; i < points.Length / 2; i++)
                {
                    points[i + points.Length / 2] = (mainPoint)points[i].Clone();
                }

                Array.Sort(points);

                string result = "Sorted and Cloned Array:\n";
                foreach (var p in points)
                {
                    result += p.Printer() + "\n---\n";
                }
                cout_label.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при роботі з масивом: {ex.Message}");
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mainPoint[] points = new mainPoint[4];

                points[0] = new mainPoint(50, 50);
                points[1] = new ColoredPoint(10, 20, "Green");

                points[2] = (mainPoint)points[0].Clone();
                points[3] = (mainPoint)points[1].Clone();


                Array.Sort(points);

                string output = "Результат роботи:\n";
                foreach (var p in points)
                {
                    output += p.Printer() + "\n----------\n";
                }

                cout_label.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка: " + ex.Message);
            }
        }
    }

    class mainPoint : ICloneable, IComparable<mainPoint>, IPointInfo
    {
        protected int X_point;
        protected int Y_point;

        public virtual string Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point}";
        }

        public string GetFullDetails() => Printer();

        public mainPoint() { }
        public mainPoint(int X_point, int Y_point)
        {
            this.X_point = X_point;
            this.Y_point = Y_point;
        }

        public virtual object Clone()
        {
            return new mainPoint(this.X_point, this.Y_point);
        }

        public int CompareTo(mainPoint other)
        {
            if (other == null) return 1;
            int thisSum = this.X_point + this.Y_point;
            int otherSum = other.X_point + other.Y_point;
            return thisSum.CompareTo(otherSum);
        }
    }

    class ColoredPoint : mainPoint
    {
        private string Color;

        public override string Printer()
        {
            return base.Printer() + $"\nColor = {this.Color}";
        }

        public ColoredPoint() : base() { this.Color = "red"; }
        public ColoredPoint(int X, int Y, string color) : base(X, Y)
        {
            this.Color = color;
        }

        public override object Clone()
        {
            return new ColoredPoint(this.X_point, this.Y_point, this.Color);
        }
    }

    class Line : mainPoint
    {
        protected int Length;
        protected int angle;

        public override string Printer()
        {
            return base.Printer() + $"\nAngle = {this.angle}\nLength = {this.Length}";
        }

        public Line() : base() { }
        public Line(int X, int Y, int angle, int length) : base(X, Y)
        {
            this.angle = angle;
            this.Length = length;
        }

        public void LastPointer()
        {
            double X_Point2 = this.X_point + this.Length * Math.Cos(this.angle);
            double Y_Point2 = this.Y_point + this.Length * Math.Sin(this.angle);

            MessageBox.Show($"X cord = {this.X_point}\nY cord = {this.Y_point}\nFinal X Point = {X_Point2}\nFinal Y Point = {Y_Point2}");
        }

        public override object Clone()
        {
            return new Line(this.X_point, this.Y_point, this.angle, this.Length);
        }
    }

    class ColoredLine : Line
    {
        private string Color;
        public override string Printer()
        {
            return base.Printer() + $"\nColor = {this.Color}";
        }

        public ColoredLine() : base() { this.Color = "red"; }
        public ColoredLine(int X, int Y, int length, string color) : base(X, Y, 0, length)
        {
            this.Color = color;
        }

        public override object Clone()
        {
            return new ColoredLine(this.X_point, this.Y_point, this.Length, this.Color);
        }
    }

    class PolyLine : Line
    {
        private int Angles;

        public override string Printer()
        {
            return base.Printer() + $"\nAngles Counter = {this.Angles}";
        }

        public PolyLine() : base() { }
        public PolyLine(int X, int Y, int length, int angles) : base(X, Y, 0, length)
        {
            this.Angles = angles;
        }

        public override object Clone()
        {
            return new PolyLine(this.X_point, this.Y_point, this.Length, this.Angles);
        }
    }
}