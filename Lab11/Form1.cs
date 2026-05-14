using System.Drawing.Printing;
using System.Reflection;
using System.Xml.Linq;

namespace Lab11
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
    class mainPoint
    {
        protected int X_point;
        protected int Y_point;
        public virtual String Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point}";
        }
        public mainPoint()
        {
            this.X_point = 0;
            this.Y_point = 0;
        }
        public mainPoint(int X_point, int Y_point)
        {
            this.X_point = X_point;
            this.Y_point = Y_point;
        }
    }

    class ColoredPoint : mainPoint
    {
        private String Color;

        public override String Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point} \nColor = {this.Color}";
        }

        public ColoredPoint()
        {
            this.Color = "red";
        }

        public ColoredPoint(int X_point, int Y_point, string Color)
        {
            this.X_point = X_point;
            this.Y_point = Y_point;
            this.Color = Color;
        }
    }

    class Line : mainPoint
    {
        protected int Length;
        private int angle;

        public override String Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point} \nAngle = {this.angle}\nLength = {this.Length}";
        }

        public void LastPointer()
        {
            double X_Point2 = this.X_point + this.Length * Math.Cos(this.angle);
            double Y_Point2 = this.Y_point + this.Length*Math.Sin(this.angle);


            MessageBox.Show($"X cord = {this.X_point}\nY cord = {this.Y_point}\nFinal X Point = {X_Point2}\nFinal Y Point = {Y_Point2}");

        } 

        public Line()
        {
            this.Length = 0;
        }

        public Line(int X_Point, int Y_Point,int angle, int Lenght)
        {
            this.X_point = X_Point;
            this.Y_point = Y_Point;
            this.angle = angle;
            this.Length = Lenght;
        }
    }
    class ColoredLine : Line
    {
        private string Color;
        public override string Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point} \nColor = {this.Color}\nLength = {this.Length}";
        }

        public ColoredLine()
        {
            this.Color = "red";
        }

        public ColoredLine(int X_Point, int Y_Point, int Lenght, string Color)
        {
            this.X_point = X_Point;
            this.Y_point = Y_Point;
            this.Length = Lenght;
            this.Color = Color;
        }
    }
    class PolyLine : Line
    {
        private int Angles;

        public override string Printer()
        {
            return $"X cord = {this.X_point}\nY cord = {this.Y_point}\nLength = {this.Length}\nAngles Counter = {this.Angles}";
        }

        public PolyLine()
        {
            this.Angles = 0;
        }
        public PolyLine(int X_Point, int Y_Point, int Lenght, int Angles)
        {
            this.X_point = X_Point;
            this.Y_point = Y_Point;
            this.Length = Lenght;
            this.Angles = Angles;
        }
    }
}