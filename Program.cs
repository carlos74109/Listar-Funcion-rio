using ExercicioLista1.Models;
using System;
using System.Collections.Generic;

namespace ExercicioLista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios vão ser registrados?");
            int registrado = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 0; i < registrado; i++)
            {
                Console.WriteLine("Id do funcionario: ");
                string id = Console.ReadLine();

                Console.WriteLine("Nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(nome, id, salario));
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Funcionarios cadastrados:");
           
            foreach(Funcionario funcionariU in list)
            {
                Console.WriteLine("Id: " + funcionariU.id);
                Console.WriteLine("Nome: " + funcionariU.nome);
                Console.WriteLine("Salario: " + funcionariU.salario);
                Console.WriteLine("--------------------");
            }


            Console.WriteLine("Digite o id do funcionario para aumentar o salario: ");
            string idDigitado = (Console.ReadLine());
            Funcionario funcionario = list.Find(x => x.id == idDigitado);

            if(idDigitado != null)
            {

                Console.WriteLine("Digite a porcetagem de aumento do salario de " + funcionario.nome + ": ");
                double porcentagem = double.Parse(Console.ReadLine());

                funcionario.aumentarSalario(porcentagem);
                Console.WriteLine("Salario atualizado: " + funcionario);

            }else
            {
                Console.WriteLine("Na proxima digite um Id valido!!!");
            }

            

           


        }
    }
}
