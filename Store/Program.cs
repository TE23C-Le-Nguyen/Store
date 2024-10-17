

//int ageNum = 0;
//bool success = false;
//{


//while (success == false)z
//{   
   // Console.WriteLine("Hur gammal är du");
    //string age = Console.ReadLine();
   // Console.WriteLine("Du måste skriva en siffa, dumhuvve");
   // success = int.TryParse(age, out ageNum);
//}//
//}
//if (ageNum < 18)
//{
 // Console.WriteLine("Nä du är för ung");
//}
//else
//{
  //Console.WriteLine("Okej, välkomman");
//}

//Console.ReadLine();


int playerMoney = 100;

while (playerMoney > 0)
{
  Console.WriteLine($"Du har {playerMoney} kronor kvar");

  Console.WriteLine("Vad vill du köpa?");
  Console.WriteLine("1. Snickers (10kr)");
  Console.WriteLine("2. Redbull (20kr)");
  Console.WriteLine("3. 1L äpplejuice(30kr)");
  Console.WriteLine("4. korv med bröd (40kr)");

  string Itemtobuy = "";
  int Itemsprice = 0;
  while (Itemtobuy != "1" && Itemtobuy != "2" && Itemtobuy != "3" && Itemtobuy != "4")
  {
    Itemtobuy = Console.ReadLine();
  }

  if (Itemtobuy == "1")
  {
    Itemsprice = 10;
  }
  else if (Itemtobuy == "2")
  {
    Itemsprice = 20;
  }
  else if (Itemtobuy == "3")
  {
    Itemsprice = 30;
  }
  else if (Itemtobuy == "4")
  {
    Itemsprice = 40;
  }

  Console.WriteLine("Hur många vill du köpa?");
  int Numby = 0;
  bool success = false;
  while (success == false)
  {
    string num = Console.ReadLine();
    success = int.TryParse(num, out Numby);
    if (success == false)
    {
      Console.WriteLine("DU MÅSTE SKRIVA EN SIFFRA!!!");
    }
  }

  int Totalprice = Itemsprice * Numby;

  if (Totalprice <= playerMoney)
  {
    Console.WriteLine("yessir");
    playerMoney -= Totalprice;
  }
  else
  {
    Console.WriteLine("din pengar är inte räcker");
  }
}

Console.WriteLine($"Du är slut på pengar");
Console.ReadLine();



