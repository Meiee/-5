using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2

{
    //    class Reg
    //    {

    //        static void Main()
    //        {
    //            var Lines = File.ReadAllLines("Text.txt");
    //            var Words = new List<String>();


    //            foreach (var Line in Lines)
    //            {
    //                var String = rg.Match(Line);
    //                Words.Add(String.Groups[1].ToString());
    //                Console.WriteLine(String);
    //            }

    //        }

    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //-------------- 3 ------------------------------------------------------------------------

            //var Lines = File.ReadAllLines("Text.txt");
            //var Words = new List<String>();
            //string _email = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            //Regex rg = new Regex(_email);

            //foreach (var Line in Lines)
            //{
            //    var String = rg.Match(Line);
            //    Words.Add(String.Groups[1].ToString());
            //    Console.WriteLine(String);
            //}

            //-------------- 2 ------------------------------------------------------------------------
            {


                Regex rg = new Regex( @"^(\w{5}|\d{5})"); // ровно 5 букв или цифр в любом порядке
                
                
                    Console.Write("Введите строку состоящую из букв и цифр :\r\n    ");
                    var str = Console.ReadLine();

                    if (rg.IsMatch(str)) //  rg. проверяет на соответствие шаблону 

                    {
                        Console.WriteLine(str);
                    }
                    else
                    {
                        Console.Write("Ошибка ввода");
                        
                    }
                
            }

            //-------------- 1 ----------------------------------------------------------------------

            //{
            //    var Lines = File.ReadAllLines("Text.txt");
            //    var Words = new List<String>();
            //    //    Regex rg = new Regex(@"(^(aaaaaa)+\b|^(a aa a)+\b)|(\b[a]\b)");
            //    Regex rg = new Regex(@"^(aaaaaa)$|^(a aa a)$|^(а)$");
            //    foreach (var Line in Lines)
            //    {
            //        var String = rg.Match(Line);
            //        Words.Add(String.Groups[1].ToString());
            //        Console.WriteLine(String);
            //    }

            //}
            //-------------- 4 ----------------------------------------------------------------------


            //var Lines = File.ReadAllLines("City.txt");
            //var Words = new List<String>();
            ////Regex rg = new Regex(@"((^[(А-я)]\w+))[\S]((:)|([(А-я)]\w+))[\S](([(А-я)]\w+)|(:))([\S]|[^:])(\s)(\b(широт[а-я])|\b\d+)([,]|\s+|\d+)(\b\d+|[,]|[.]|\s)(\b(долгот[а-я])|[,]|[.]|\s)(\b(долгот[а-я])|\b\d+|\b\d+[.]\d+|[,]|[.]|\s)([,]|[.]|\s)");   (\d{1,3}.{1}\d{1,4})
            ////Regex rg = new Regex(@"((^[(А-я)]\w+))[\S]((:)|([(А-я)]\w+))[\S](([(А-я)]\w+)|(:))([\S]|[^:])(\s)(\b(широт[а-я])|\b\d+)([,]|\s+|\d+)");
            //Regex rg = new Regex(@"((г\. )?[А-Я][а-я]{2,})((:)|([-\.])?)([А-Яа-я]{2,})?([-\.])?([А-Яа-я]{2,})?(:)?(\s)(\b(широта)?)(\s|[\d]{1,2})(([\d]{1,2})([.,])([\d]{0,4}))([,]?)(\s)(\b(долгота)?)(\s)?([\d]{1,3})?(([.])[\d]{0,4})|([.]?)")
            //{

            //};
            //foreach (var Line in Lines)
            //{
            //    var String = rg.Match(Line);
            //    Words.Add(String.ToString());
            //    Console.WriteLine(String);
            //}
            //Console.WriteLine("Остальные города не найдены");



            //-------------- 5 ----------------------------------------------------------------------


            var Lines = File.ReadAllLines("testData.xml");
            var Words = new List<String>();

            //1 a.	найдите все значения, попадающие под ваш вариант задания из пункта 4; 
            //Regex rg = new Regex(@"((г\. )?[А-Я][а-я]{2,})((:)|([-\.])?)([А-Яа-я]{2,})?([-\.])?([А-Яа-я]{2,})?(:)?(\s)(\b(широта)?)(\s|[\d]{1,2})(([\d]{1,2})([.,])([\d]{0,4}))([,]?)(\s)(\b(долгота)?)(\s)?([\d]{1,3})?(([.])[\d]{0,4})|([.]?)");
            var regex = new Regex(@"[\d]+|[\w]+|[\s]+");


            foreach (var Line in Lines)
            {
                var String = regex.Match(Line);
                Words.Add(String.ToString());
                Console.WriteLine(Regex.Replace(String.ToString(), @"^(\d{1,2}.|[\d{1,2}.])", ""));
            }
            Console.WriteLine("Остальные города не найдены");

        }
    }
}



