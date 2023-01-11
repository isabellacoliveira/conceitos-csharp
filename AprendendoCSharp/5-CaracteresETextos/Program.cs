using System;
class Progama
{
    static void Main(string[] args)
    {
        //usaremos char para armazenar um caracter 
        //precisamos colocar aspas simples para funcionar 
        char letra = 'a';
        Console.WriteLine("a letra é " + letra);

        letra = (char)65;
        Console.WriteLine(letra);
        // de acordo com a tabela ASCII o 65 representa o A maiúsculo  
        //podemos quebrar linhas com o @ 
        string primeiraFrase = @"Me tornando 
                                full-stack";
        Console.WriteLine(primeiraFrase + "LEGALLLLLL");
        
        //podemos ter uma string vazia mas não um char 
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}