// See https://aka.ms/new-console-template for more information
using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc =  new Calculadora();
            System.Console.WriteLine(calc.Multiplicar(10, 3));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 9;

            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Idade = 40;
            // p2.Salario = 9;

            // p2.Apresentar();



            // // Valores  válids
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // // Valores  inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");



            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }


}