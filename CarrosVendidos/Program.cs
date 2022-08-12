using System;
using System.Globalization;

namespace CarrosVendidos;

public class Program
{
    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        double salario, comissao, carros, valor, venda, venda2, SalarioFinal, bonus;

        Console.Write("Digite por favor a quantidade de carros vendidos neste mês: ");
        carros = double.Parse(Console.ReadLine());
        Console.Write("Digite por favor o valor total das vendas deste mês: ");
        valor = double.Parse(Console.ReadLine());

        salario = 2000.00;
        comissao = 1000.00;
        bonus = 0.05;

        venda = carros * comissao;
        venda2 = venda * bonus;

        SalarioFinal = salario + venda2 + venda;

        Console.WriteLine();
        Console.Write("O salario do vendedor é de = " + SalarioFinal.ToString("F2", CI));
    }
}