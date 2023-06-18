/*
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
#region 
int InputNumber(string message)
{
  Console.Write(message);
  int number = int.Parse(Console.ReadLine()!);
    return number;
}

void TwoNumber(int number)
{
   int num = number;
  
   if ( 99 < num && num < 1000)
   {
    Console.WriteLine($" Вторая цифра числа:  {num = num / 10 % 10}");
   }
   else
   {
     Console.WriteLine(" Неверный ввод ");
   }
}

int threeDigitNumber = InputNumber(" Введите трехзначное число: ");
TwoNumber(threeDigitNumber);
#endregion
/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
#region 
int InNumber(string message)
{
  Console.Write(message);
  int number = int.Parse(Console.ReadLine()!);
    return number;
}

void ThirdNumber(int number)
{
 if (number < 99)
  {
    Console.WriteLine(" Третьей цифры нет ");
  }
   else if(number < 1000) 
  {
    Console.WriteLine($" Третя цифра числа: {number = number % 10 % 10}");
  }
  else if(number < 10000)
  {
    Console.WriteLine($" Третя цифра числа: {number=number / 10 % 10}");
  }
  else if(number < 100000)
  {
    Console.WriteLine($" Третя цифра числа: {number = number / 100 % 10}");
  }
  
}

int integer = InNumber(" Введите трехзначное число: ");
ThirdNumber(threeDigitNumber);
#endregion
/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
#region 
int EnteNumberOfTheDayOfTheWeek(string message)
{
    System.Console.Write(message);
    int numberDay = int.Parse(Console.ReadLine()!);
        return numberDay;
}
void WeeKDay(int numberDay)
{
  switch(numberDay)
 {
    case 1:
    {
        Console.WriteLine(" Понедельник рабочий день ");
        break;
    }
    case 2:
    {
        Console.WriteLine(" Вторник рабочий день ");
        break;
    }
    case 3:
    {
        Console.WriteLine(" Среда рабочий день ");
        break;
    }
    case 4:
    {
        Console.WriteLine(" Четверг рабочий день ");
        break;
    }
    case 5:
    {
        Console.WriteLine(" Пятница кароткий рабочий день ");
        break;
    }
    case 6:
    {
        Console.WriteLine(" Суббота выходной день ");
        break;
    }
    case 7:
    {
        Console.WriteLine(" Воскресеннье выходной день ");
        break;
    }
    default:
    {
        Console.WriteLine(" Неверный ввод  ");
        break;
    }
  }

}

int dayNum = EnteNumberOfTheDayOfTheWeek(" Введите число дня недели: ");
WeeKDay(dayNum);
#endregion