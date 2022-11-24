/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/



int Number, Remain, Sum = 0, Newnum;
      
        Console.WriteLine("Введите пятизначное число: ");
        Number = Convert.ToInt32(Console.ReadLine());
        Newnum = Number;       
    
        while (Number>0)
        {
            Remain = Number % 10; 
            Number = Number / 10; 
            Sum = Sum * 10 + Remain; 
        }
        
        if (Newnum == Sum) 
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не палиндром");
        }
        Console.ReadLine();
