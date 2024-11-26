using System;

namespace Secao4Aula40ClassesObjetosAtributos01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            person1.FirstName = Console.ReadLine();
            Console.Write("Idade: ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            person2.FirstName = Console.ReadLine();
            Console.Write("Idade: ");
            person2.Age = int.Parse(Console.ReadLine());

            if (person1.Age > person2.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + person1.FirstName);
            }
            else
            {
                Console.WriteLine("Person mais velha: " + person2.FirstName);
            }
        }
    }
}
