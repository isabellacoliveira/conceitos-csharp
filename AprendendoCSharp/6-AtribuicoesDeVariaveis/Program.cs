using System;
class Progama
{
    static void Main(string[] args)
    {
        int idadeJoao = 16;
        int acompanhante = 0; 

        if(idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!"); 
        } 
        else
        {
            if(acompanhante == 0)
            {
                Console.WriteLine("Está sem acompanhante"); 
            }
            Console.WriteLine("Não pode entrar!"); 
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}