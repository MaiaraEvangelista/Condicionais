using System;

namespace Projetonovo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Para participar do time o aluno deve ter a nota maior ou igual a 80
            //E faltas menor ou igual a 10% dos dias letivos.
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Bem Vindo a seletiva para time de Counter-Strike");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Vocẽ gostaria de participar? Sim ou Não");
            string resposta = Console.ReadLine();
                 if(resposta == "Sim"){
                     Console.WriteLine("Que legal! Agora vamos analisar seu currículo");
                     Console.WriteLine("Insira sua média escolar");
                     int media = int.Parse(Console.ReadLine());
                     Console.WriteLine("Digite a sua quantidade de faltas");
                     int faltas = int.Parse(Console.ReadLine());
                     if(media>=50 && faltas <= 10){
                         Console.WriteLine("Parabéns seja Bem Vindo");
                     }else{
                         Console.WriteLine("Que pena, você precisa melhorar suas notas e faltas");
                    }

            }else{
                Console.WriteLine("Blz, Passar bem!");
            }//Fim if








        }
    }
}
