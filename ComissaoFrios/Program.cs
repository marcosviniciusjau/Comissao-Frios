using System;
using System.Globalization;
namespace ComissaoFrios
{
    class Program
    {
        static void Main(string[] args)

        {
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

            double comissaototal, quilomussarela, quilomortadela, quilopresunto, quilopeitoperu,salariototal;

            Console.WriteLine("Digite o valor do quilo da mussarela:");
            quilomussarela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do quilo da mortadela");
            quilomortadela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do quilo do presunto");
            quilopresunto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do quilo do peito de peru");
            quilopeitoperu = Convert.ToDouble(Console.ReadLine());

            double comissaomussarela = 22.60 * 00.5;
            double comissaomortadela = 89.90 * 00.65;
            double comissaopresunto = 310.30 * 00.449;
            double comissaopeitoperu = 589.00 * 00.25;

            Console.Clear();

            Console.WriteLine(
                "Você vendeu 10,0 kg de Mussarela no valor de de R$ 226,00 sua comissão é R$ 11,30 " +
                " Você vendeu 10,0 kg de Mortadela no valor de de R$ 89,80 sua comissão é R$ 5,84" +
                " Você vendeu 10,0 kg de Presunto no valor de R$ 310,30 sua comissão é R$ 13,96" +
                " Você vendeu 10,0 kg de Peito de Peru no valor de de R$ 589,90 sua comissão é R$ 14,73"
                );


                comissaototal = comissaomortadela + comissaomussarela + comissaopeitoperu + comissaopresunto;

            Console.WriteLine("Sua comissão Total é R$ 45,83");

            salariototal = quilomussarela + quilomortadela + quilopeitoperu + quilopresunto;

            Console.WriteLine("Salário total de R$ 1.245,83");




            Console.ReadKey();
        }
    }
};