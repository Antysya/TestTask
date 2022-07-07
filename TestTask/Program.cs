using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;

/*Данное задание выполнялось в рамках вакансии "Программист C#/Разработчик ПО" компании "Стройформ". Это первое
задание выполненное не в рамках учебного процесса. С моими учебными поектами Вы можете ознакомиться по ссылке:
https://github.com/Antysya */

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Добрый день, уважаемый работодатель!\nСпасибо, что обратили внимание на мое резюме!\nЯ понимаю, что соответствую только " +
                "частично данной вакансии, Но с нетерпением жду от Вас обратную связь.\nС уважением, Анна Ерошина.\n"); 

            while (true)
            {
                WriteLine("Вы хотите проверить число на четность/нечетность?\n Если ДА, то нажмите 1, " +
                    "для выхода - любой символ:\n ");

                int posnum = Convert.ToInt32(ReadLine());

                switch (posnum)
                {
                    case 1:
                        {
                            WriteLine("Справочник:\nЧётное число — целое число, которое делится на 2 без остатка " +
                                "(отличительная черта - число оканчивается на 0, 2, 4, 6, 8).\n" +
                                "Нечётное число — целое число, которое не делится на 2 без остатка " +
                                "(отличительная черта - число оканчивается на 1, 3, 5, 7, 9).\n");
                            string numPattern = @"^-?\d*$";
                            WriteLine("Введите число для проверки:");
                            string num = ReadLine();
                            Regex reg = new Regex(numPattern);
                            if (reg.IsMatch(num)){
                                if (Convert.ToInt32(num) % 2 == 0)
                                    WriteLine($"{num} - четное");
                                else
                                    WriteLine($"{num} - нечетное");
                            } 
                            else
                                WriteLine($"{num} - не является целым числом!");
                        }
                        break;

                    default:
                        {
                            WriteLine("Всего Вам наилучшего!");
                            return;
                        }
                }
            }
        }
    }
}
     
