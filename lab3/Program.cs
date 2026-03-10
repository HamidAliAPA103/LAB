//Console.WriteLine("reqem daxil et : ");
//Console.WriteLine("1 : kvadrat ");
//Console.WriteLine("2 : duzbucaq ");
//Console.WriteLine("3 : ucbucaq ");
//Console.WriteLine("0 : bitti ");

//bool isExit = false;
//while (!isExit)
//{
//    int num = int.Parse(Console.ReadLine());
//    switch (num)
//    {
//        case 1:
//            Console.WriteLine("terefi daxil edin : ");
//            double a = Convert.ToDouble(Console.ReadLine());
//            double kvadratnsahesi = a * a;
//            Console.WriteLine("kvadrat sahe : " + kvadratnsahesi);
//            break;
//        case 2:

//            Console.WriteLine("uzunluqu daxil edin : ");
//            double uzunluq = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("en daxil edin : ");
//            double en = Convert.ToDouble(Console.ReadLine());
//            double duzbucaqi = uzunluq * en;
//            Console.WriteLine("duzbucaqli sahe : " + duzbucaqi);
//            break;
//        case 3:

//            Console.WriteLine("hundurluyu daxil edin : ");
//            double hundurluk = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("terefi daxil edin : ");
//            double teref = Convert.ToDouble(Console.ReadLine());
//            double ucbucaq = (hundurluk * teref) / 2;
//            Console.WriteLine(" ucbucaq sahe : " + ucbucaq);
//            break;
//        case 0:
//            isExit = true;

//            break;


//        default:
//            Console.WriteLine("Yanlış seçim etdiniz!");
//            break;

//    }

//}

//Console.WriteLine("eded daxil edin");
//int num = int.Parse(Console.ReadLine());
//int original = num;
//int reversed = 0;

//while (num > 0)
//{
//    int digit = num % 10;
//    reversed = reversed * 10 + digit;
//    num /= 10;
//}

//if (original == reversed)
//    Console.WriteLine("Palindrom ededdir");
//else
//    Console.WriteLine("Palindrom deyil");

