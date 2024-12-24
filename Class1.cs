using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buildinglib
{
    //Класс адрес
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}";
        }
    }

    // Класс для представления квартиры
    public class Apartment
    {
        public int Number { get; set; }
        public string Owner { get; set; }

        // Метод для отображения информации о квартире
        public void Show()
        {
            Console.WriteLine($"Номер квартиры: {Number}, Владелец: {Owner}");
        }
    }

    // Класс для представления здания
    public class Building
    {
        public Address Address { get; set; }
        public string Description { get; set; }
        public List<Apartment> Apartments { get; set; }

        public Building()
        {
            Apartments = new List<Apartment>();
        }

        // Метод для отображения всех квартир
        public void ShowAll()
        {
            Console.WriteLine($"Описание: {Description}, Адрес: {Address}");
            foreach (var apartment in Apartments)
            {
                apartment.Show();
            }
        }
    }
}
