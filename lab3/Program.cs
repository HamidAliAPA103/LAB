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


//Console.WriteLine("eded daxil edin");
//int i = int.Parse(Console.ReadLine());
//if (i > 1 && i < 100)
//{
//    Console.WriteLine("1 100 araliqindadir");
//}
//else
//{
//    Console.WriteLine("1 100 araliqinda deil");

//}
//Console.WriteLine("ededin kubu :" + i*i*i);




//Console.WriteLine("ad daxil edin : ");
//string ad = Console.ReadLine();
//Console.WriteLine("soyad daxil edin : ");
//string soyad = Console.ReadLine();
//Console.WriteLine("Welcome " + ad  +  soyad);



//Console.WriteLine("soz daxil edin");
//string soz = Console.ReadLine();
//int uzunluq = soz.Length;
//Console.WriteLine("sozun uzunluqu : " + uzunluq);


//for (int i = 1; i < 100; i++)
//{
//    if (i % 7 == 0 || i % 10 == 7)
//    {
//        Console.WriteLine("diz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}



//int[] reqem = { 10, 12, 22, 10,32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15 };

//for (int i = 0; i < reqem.Length; i++)
//{
//    for (int j = i + 1; j < reqem.Length; j++)
//    {
//        if (reqem[i] == reqem[j])
//        {

//        }
//    }
//}

//Console.WriteLine(reqem.Length-s);


//int[,] matris = new int[3, 3]
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9},

//};
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(matris[i,j] + " ");
//    }
//    Console.WriteLine();
//}


