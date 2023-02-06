using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise
{
    class Airplane
    {
        private string name;
        private string publisher;
        private string year;
        private string type;

        public Airplane()
        {
            name= string.Empty;
            publisher= string.Empty;
            year= string.Empty;
            type= string.Empty;
        }
       public Airplane(string name, string publisher, string year, string type, string full_Name, string date_of_birth, string phone_Number, string email, string position, string position_Description)
        {
            this.name = name;
            this.publisher = publisher;
            this.year = year;
            this.type = type;
        }

        public void Print() => Console.WriteLine("Airplane name - " + name + "\nPublisher - " + publisher + "\nYear - " + year + "\nType - " + type);
        public void Input()
        {
            Console.Write("Enter Airplane name: ");
            name = Console.ReadLine();
            Console.Write("Enter Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("Enter Year: ");
            year = Console.ReadLine();
            Console.Write("Enter Type: ");
            type = Console.ReadLine();
        }
       
        public override string ToString()
        {
            return "Airplane name - " + name + "\nPublisher - " + publisher + "\nYear - " + year + "\nType - " + type;
        }
        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
    }
}
