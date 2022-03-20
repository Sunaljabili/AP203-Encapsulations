using System;
namespace AP204classwork
{
    public class Product
    {
        private string _name;
        public double Price;
        public int Count;
        public double Totalcome;

        public string Name

        {
            get
            {
                return _name;
            }

            set
            {
                if (value == "")
                {
                    Console.WriteLine("Mehsulun adini daxil etmemisiniz...");
                }
                else
                {
                    _name = value;
                }
            }
           
        }
        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                Totalcome += Price;

            }
            else
            {
                Console.WriteLine("Satis mumkun deyil...");
            }
        }

    }

  


}
