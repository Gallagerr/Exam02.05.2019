using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
  public class DataInitiailizer : CreateDatabaseIfNotExists<CitiesContext>
  {
    public class Menu
    {
      public void Choices()
      {
        Console.WriteLine("1) Страна\n" + "2) Город\n" + "3) Улица\n");
        int result = int.Parse(Console.ReadLine());
        if (result == 1)
        {
          Land();
        }
        else if (result == 2)
        {
          City();
        }
        else if (result == 3)
        {
          Row();
        }
      }

      public void Land() //страна
      {
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine("1) Добавить страну\n" + "2) Изменить страну\n" + "3) Удалить страну\n" + "4) Вывести все страны");
        if (result == 1)
        {
       
        }
        else if (result == 2)
        {

        }
        else if (result == 3)
        {

        }
        else if (result == 4)
        {

        }
      }

      public void City() //город
      {
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine("1) Добавить город\n" + "2) Изменить город\n" + "3) Удалить город\n" + "4) Вывести все города");
        if (result == 1)
        {

        }
        else if (result == 2)
        {

        }
        else if (result == 3)
        {

        }
        else if (result == 4)
        {

        }
      }
      public void Row() //улица
      {
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine("1) Добавить город\n" + "2) Изменить город\n" + "3) Удалить город\n" + "4) Вывести все города");
        if (result == 1)
        {

        }
        else if (result == 2)
        {

        }
        else if (result == 3)
        {

        }
        else if (result == 4)
        {

        }      
      }
    }
  }
}

