// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gestão de Alunos");
            int i;

            List<int> notas = new List<int>();
            notas.Add(10);
            notas.Add(15);
            notas.Add(10);
            notas.Add(20);
            notas.Add(-5); // valor inválido

            CalcularMedia(notas);
            CalcularMedia(notas);

            if (notas.Count > 0)
            {
                Console.WriteLine("Programa terminado.");
            }
        }

        static void CalcularMedia(List<int> notas)
        {
            int soma = 0;

            for (int i = 0; i < notas.Count; i++)
            {
                soma = soma + notas[i];
            }

            int media = soma / notas.Count;

            if (media >= 10)
            {
                Console.WriteLine("Aluno aprovado com média: " + media);
            }
            else
            {
                Console.WriteLine("Aluno reprovado com média: " + media);
            }

            if (media >= 18)
            {
                Console.WriteLine("Excelente aluno");
            }

            if (media >= 18)
            {
                Console.WriteLine("Excelente aluno");
            }
        }
    }
}
