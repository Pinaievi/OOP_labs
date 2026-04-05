using System.Diagnostics.Metrics;

namespace Lab9_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StaticObjectCounter.Text = Adress.ObjectCounter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(zipcodeTextBox.Text, out int parsedZip))
            {
                try
                {
                    Adress myAdress1 = new Adress(countryTextBox.Text, parsedZip, housenumTextBox.Text);

                    StaticObjectCounter.Text = Adress.ObjectCounter.ToString();
                    MessageBox.Show(myAdress1.GetFullInfo());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    class Adress
    {
        private string country;
        private int zipcode;
        private int houseNum;

        private static int objectCounter = 0;

        public Adress()
        {
            this.country = "Україна";
            this.zipcode = 1;
            this.houseNum  = 1;

            objectCounter++;
        }

        public Adress(string country, int zipcode, int houseNum)
        {
            this.Country = country;
            this.Zipcode = zipcode;

            this.HouseNum = houseNum;

            objectCounter++;
        }


        public static int ObjectCounter
        {
            get { return objectCounter; }
        }
        public string GetFullInfo()
        {
            return $"Країна: {Country}\nКод:{Zipcode}\nНомер будинку{HouseNum}";
        }


        #region Сеттери та гетери з можливістю throw
        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Країна не може бути порожньою.");
                country = value;
            }
        }

        public int HouseNum
        {
            get { return houseNum; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Номер будинку не може бути відємним");
                
                houseNum = value;
            }
        }

        public int Zipcode
        {
            get { return zipcode; }
            set
            {
                if (value <= 0 || value > 99999)
                    throw new ArgumentException("Вказаний неправильний формат коду");

                zipcode = value;
            }
        }
        #endregion

        #region Оновлення параметрів
        public void CountryUpdate(string country)
        {
            this.country = country;
        }
        public void ZipCodeUpdate(int code)
        {
            this.Zipcode = code;
        }
        
        public void HouseNumUpdate(int houseNum) 
        {
            this.HouseNum = houseNum;
        }
        #endregion
    }
}
