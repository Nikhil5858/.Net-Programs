// Pro-1
//Console.WriteLine("Name : Nikhil Rathod");
//Console.WriteLine("Address : Abcxyz");
//Console.WriteLine("City : Jamnagar");

//Pro-2
//Console.WriteLine("Enter Num 1 : ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Num 2 : ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Number 1 : "+num+ "Number 2 : "+num2);

//Pro-3

//Console.WriteLine("Enter Name : ");
//String name = Console.ReadLine();
//Console.WriteLine("Enter Country : ");
//String contry = Console.ReadLine();
//Console.WriteLine("Hello "+name+"from country "+contry);

//Pro-4

//Console.WriteLine("Enter Height : ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Width : ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("area in square-feet : "+(num*num2));


//pro-5

//Square
//Console.WriteLine("Enter Height : ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Width : ");
//Console.WriteLine("Square : " + (num * num));

//Recetangel
//Console.WriteLine("Enter Height : ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Width : ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Recetangel: "+(num*num2));

//Circle

//Console.WriteLine("Enter Ratio : ");
//int r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Square : " + (3.14 * r * r));


//Pro-6

//Console.WriteLine("Temperature Converter");
//Console.WriteLine("1. Celsius to Fahrenheit");
//Console.WriteLine("2. Fahrenheit to Celsius");
//int choice = Convert.ToInt32(Console.ReadLine());

//if (choice == 1)
//{
//    Console.Write("Enter temperature in Celsius: ");
//    double celsius = Convert.ToDouble(Console.ReadLine());
//    double fahrenheit = (celsius * 9 / 5) + 32;
//    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
//}
//else if (choice == 2)
//{
//    Console.Write("Enter temperature in Fahrenheit: ");
//    double fahrenheit = Convert.ToDouble(Console.ReadLine());
//    double celsius = (fahrenheit - 32) * 5 / 9;
//    Console.WriteLine("Temperature in Celsius: " + celsius);
//}
//else
//{
//    Console.WriteLine("Invalid choice.");
//}



//Pro-7

//Console.WriteLine("Enter Amount : ");
//int p = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Interest : ");
//int r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Year : ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Simpel Interest" + ((p*r*n)/100));


//Pro-8

//Console.WriteLine("Enter Enter Number 1 : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Enter Number 2 : ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//while (true)
//{

//    Console.WriteLine("Enter 1 for Addition \n Enter 2 for Substraction \n Enter 3 for Multiplication \n Enter 4 for Divison ");
//    Console.WriteLine("Enter Choice : ");
//    int ch = Convert.ToInt32(Console.ReadLine());

//    if (ch == 1)
//    {
//        int ans = num1 + num2;
//        Console.WriteLine("Addition is : " + ans);
//    }
//    else if (ch == 2)
//    {
//        int ans = num1 - num2;
//        Console.WriteLine("Substraction is : " + ans);
//    }
//    else if (ch == 3)
//    {
//        int ans = num1 * num2;
//        Console.WriteLine("Multiplication is : " + ans);
//    }
//    else if (ch == 4)
//    {
//        int ans = num1 / num2;
//        Console.WriteLine("Division is : " + ans);
//    }
//    else
//    {
//        Console.WriteLine("Invalid Choice!");
//    }

//}


//Pro-9

//int a = 10;
//int b = 20;
//a = a + b;
//b = a - b;
//a = a - b;

//Console.WriteLine("Num1 : "+a);
//Console.WriteLine("Num2 : "+b);


//Pro-10

//Console.WriteLine("Enter Num 1 : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Num 2 : ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Num 3 : ");
//int num3 = Convert.ToInt32(Console.ReadLine());

//int largest = (num1 > num2)
//                ? (num1 > num3 ? num1 : num3)
//                : (num2 > num3 ? num2 : num3);
//Console.WriteLine("Large : "+largest);


//Rev number

//int num = 1023;
//int rev = 0;

//while (num != 0)
//{
//    int temp = num % 10;
//    rev = rev * 10 + temp;
//    num /= 10;
//}
//Console.WriteLine(rev);




