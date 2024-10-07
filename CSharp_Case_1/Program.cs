using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Case_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WritingCommands

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("******** Food categories ********");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Main Courses");
            //Console.WriteLine("3-Appetizers");
            //Console.WriteLine("4-Salads");
            //Console.WriteLine("5-Deserts");
            //Console.WriteLine("6-Drinks");
            //Console.WriteLine();
            //Console.WriteLine("******** Food categories ********");

            #endregion

            #region StringVariables

            //string name;
            //name = "Skip";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone  = "+90 500 00 00 00";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("**** Reservation Card ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------");

            //Console.WriteLine();

            //customerName = "Veli";
            //customerSurname = "Semih";
            //customerPhone = "+90 600 00 00 00";
            //customerEmail = "olay@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";

            //Console.WriteLine("**** Reservation Card ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------");

            #endregion

            #region IntVariables

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("******* Menu Prices ********");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Hamburger: " + hamburgerPrice + "TL");
            //Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            //Console.WriteLine("kola: " + cokePrice + "TL");
            //Console.WriteLine("limonata: " + lemonadePrice + "TL");
            //Console.WriteLine("Kızartma: " + friesPrice + "TL");
            //Console.WriteLine("Su: " + waterPrice + "TL");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("******* Menu Prices ********");

            //Console.WriteLine();

            //int hamburgerCount = 3, cokeCount = 3, waterCount = 3, friesCount = 1, pizzaCount = 0,  lemonadeCount = 0;
            //int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFriesPrice, totalPizzaPrice, totalLemonadePrice;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Hamburger Cost: " + totalHamburgerPrice + "TL");
            //Console.WriteLine("Pizza Cost: " + totalPizzaPrice + "TL");
            //Console.WriteLine("kola Cost: " + totalCokePrice + "TL");
            //Console.WriteLine("limonata Cost: " + totalLemonadePrice + "TL");
            //Console.WriteLine("Kızartma Cost: " + totalFriesPrice + "TL");
            //Console.WriteLine("Su Cost: " + totalWaterPrice + "TL");
            //Console.WriteLine("----------------------------");

            //int totalPrice=totalCokePrice + totalWaterPrice+totalFriesPrice+totalLemonadePrice+totalPizzaPrice+totalHamburgerPrice;

            //Console.WriteLine("Total Cost : " + totalPrice + "TL");

            #endregion

            #region DoubleVariables

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("******* Menu Prices ********");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Elma price: " + applePrice + "TL");
            //Console.WriteLine("Portakal Price: " + orangePrice + "TL");
            //Console.WriteLine("Strawberry Price: " + strawberryPrice + "TL");
            //Console.WriteLine("Potato price: " + potatoPrice + "TL");
            //Console.WriteLine("Tomato Price: " + tomatoPrice + "TL");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("******* Menu Prices ********");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalprice = appleGram * applePrice;
            //double orangeTotalprice = orangeGram * orangePrice;
            //double strawberryTotalprice = strawberryGram * strawberryPrice;
            //double potatoTotalprice = potatoGram * potatoPrice;
            //double tomatoTotalprice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Product: Elma - " + "Unit price: " + applePrice + " - Grammage : " + appleGram + " - Total Amount : "+ appleTotalprice);
            //Console.WriteLine("Product: Orange - " + "Unit price: " + orangePrice + " - Grammage : " + orangeGram + " - Total Amount : "+ orangeTotalprice);
            //Console.WriteLine("Product: Strawberry - " + "Unit price: " + strawberryPrice + " - Grammage : " + strawberryGram + " - Total Amount : "+ strawberryTotalprice);
            //Console.WriteLine("Product: Potato - " + "Unit price: " + potatoPrice + " - Grammage : " + potatoGram + " - Total Amount : "+ potatoTotalprice);
            //Console.WriteLine("Product: Tomato - " + "Unit price: " + tomatoPrice + " - Grammage : " + tomatoGram + " - Total Amount : "+ tomatoTotalprice);

            //double shoppingTotalPrice = appleTotalprice+orangeTotalprice+strawberryTotalprice+potatoTotalprice+tomatoTotalprice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Total Shopping Cost: " + shoppingTotalPrice + "TL");


            #endregion

            #region CharVariables

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region String Data Variables from Keyboard

            //Console.WriteLine("******* Passenger Info ********");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("----------------------------");
            //Console.Write("Passenger name: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Passenger surname: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Passenger district: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Passenger city: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Passenger age: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Passenger identity no: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(" Passenger ID No: "+ passengerIdentityNumber + "- Passenger Name Surname : "+ passengerName+" "+passengerSurname+ " "+ passengerDistrict+ " / "+passengerCity+" "+passengerAge);



            #endregion

            #region Int data entrance from Keyboard

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter shoes quantity: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter computer quantity: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter chair quantity: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter tv quantity: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine(" total payable amount : " + totalPrice);


            #endregion

            #region Decimals from keyboard

            //double exam1, exam2, exam3, result;

            //Console.Write(" Enter 1st Exam Grade : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write(" Enter 2nd Exam Grade : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write(" Enter 3rd Exam Grade : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Exams Average is :" + result);

            #endregion

            #region Enter char from Keyboard

            //char gender;
            //Console.Write("Please choose gender: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine(" Chosen gender is " + gender);


            #endregion


            Console.Read();
        }
    }
}




//Yazdırma Komutları