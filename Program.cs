using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios

{

    class Program
    {
        static char ObterCaractere(string mensagem)
        {
            char caracter;
            while (true){
                Console.Write(mensagem);
                string caracterTexto = Console.ReadLine();
                if (char.TryParse(caracterTexto, out caracter) && char.IsLetter(caracter))
                    return caracter;
                Console.WriteLine("Caractere inválido, por favor tente novamente.");
            }
}
        static void Main (string[] args)
        {
            char caracter1 = ObterCaractere("Insira o primeiro caracter: ");
            char caracter2 = ObterCaractere("Insira o segundo caracter: ");
            int encodingChar1 = (int)caracter1;
            int encodingChar2 = (int)caracter2;

            if (caracter1 > caracter2 || caracter1 == caracter2){
                Console.WriteLine("Erro, por favor execute o programa novamente.");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey(true);
                return;
            }


            else {
                Console.WriteLine("Você inseriu os caracteres '" + caracter1 + "' e '" + caracter2 + "'.");
                int numCaracteres = (encodingChar2 - encodingChar1) - 1;
                
                Console.WriteLine("Logo, há " + numCaracteres + " caracteres entre eles, sendo os: ");
                encodingChar1++;

                while (encodingChar1 < encodingChar2) {
                    char caracter = (char)encodingChar1;
                    Console.WriteLine(caracter);
                    encodingChar1++;
                }
            }
            Console.Read();
            
        }
    }
}