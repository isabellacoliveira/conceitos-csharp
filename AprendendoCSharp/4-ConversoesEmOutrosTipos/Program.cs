using System;
class Progama
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.29;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine("O salário inteiro é " + salarioInteiro); 
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}