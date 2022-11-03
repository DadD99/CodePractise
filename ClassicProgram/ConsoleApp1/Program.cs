using FunctionLibrary;
using FunctionLibrary._1_10;
using FunctionLibrary.Extention_Method;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Tinh tuoi
            //Console.Write("Nhap vao nam sinh: ");
            //int a = YearOldCalculate.TinhTuoi(Console.ReadLine());
            //ExtentionMethods.PrintToConsole($"Tuoi cua ban la: {a}");

            //Tinh tien taxi
            //Console.Write("Nhap so km: ");
            //decimal a = Taxi.CostCalculate(Console.ReadLine());
            //ExtentionMethods.PrintToConsole($"So tien la {a}", ConsoleColor.DarkRed);

            Console.Write("Nhap vao mot so nguyen: ");
            int a = Sum.TinhTongCacChuSo(Console.ReadLine());
            ExtentionMethods.PrintToConsole($"Tong cac chu so la {a}", ConsoleColor.DarkRed);
        }
    }
}