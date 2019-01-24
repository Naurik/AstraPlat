using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bool repeat = true;
            int numberBus;
            Console.WriteLine("Выберите тип: ");
            Console.WriteLine("1) Дети ");
            Console.WriteLine("2) Студенты ");
            Console.WriteLine("3) Взрослые ");
            Console.WriteLine("4) Люди с ограниченной возможностью ");
            int type = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int pay; 
            int busPay;
            switch (type)
            {
                case 1:
                    
                    Console.WriteLine("Choice number bus: ");
                        numberBus = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Child");
                    while (repeat)
                    {
                        if (numberBus > 0 && numberBus < 100)
                        {
                            busPay = 40;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.CityBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 100 && numberBus < 200)
                        {
                            busPay = 80;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 200 && numberBus < 300)
                        {
                            busPay = 120;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Такого автобуса нет. Введите заново!");
                            numberBus = int.Parse(Console.ReadLine());
                        }
                    }
                    
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Choice number bus: ");
                    numberBus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Student");
                    while (repeat)
                    {
                        if (numberBus > 0 && numberBus < 100)
                        {
                            busPay = 60;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.CityBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 100 && numberBus < 200)
                        {
                            busPay = 100;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 200 && numberBus < 300)
                        {
                            busPay = 160;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Такого автобуса нет. Введите заново!");
                            numberBus = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Choice number bus: ");
                    numberBus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Adult");
                    while (repeat)
                    {
                        if (numberBus > 0 && numberBus < 100)
                        {
                            busPay = 80;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.CityBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 100 && numberBus < 200)
                        {
                            busPay = 120;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 200 && numberBus < 300)
                        {
                            busPay = 180;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Такого автобуса нет. Введите заново!");
                            numberBus = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Choice number bus: ");
                    numberBus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pensionery");
                    while (repeat)
                    {
                        if (numberBus > 0 && numberBus < 100)
                        {
                            busPay = 0;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.CityBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 100 && numberBus < 200)
                        {
                            busPay = 0;
                            pay = rand.Next(500, 3000);
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + pay);
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + (pay - busPay));
                            repeat = false;
                        }
                        else if (numberBus >= 200 && numberBus < 300)
                        {
                            busPay = 0;
                            Console.WriteLine(bus.ExpressBus);
                            Console.WriteLine("На счету = " + "Лимит не определен");
                            Console.WriteLine("Проезд стоит = " + busPay);
                            Console.WriteLine("После списания = " + "Лимит не определен");
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Такого автобуса нет. Введите заново!");
                            numberBus = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.ReadLine();
                    break;
            }

            
          
           
          
        }
    }
}
