using System;

namespace w3s
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            string txt_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string txt_lower = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(txt_upper);
            Console.WriteLine(txt_upper.Length);
            Console.WriteLine(txt_upper.ToLower());
            Console.WriteLine(txt_upper.ToUpper());
            //concat
            Console.WriteLine(txt_upper + txt_lower);
            Console.WriteLine(string.Concat(txt_upper," ", txt_lower));
            Console.WriteLine();
            //string interpolação, alternativa à concatenação
            string firstName = "André";
            string lastName = "Bronca";
            string msgFullName = $"Full name is: {firstName} {lastName}";
            Console.WriteLine(msgFullName);
            //acessando caracteres da string
            //primeiro caracter
            Console.WriteLine(firstName +", primeiro caracter: "+firstName[0]);
            //último caracter
            Console.WriteLine(firstName +", último caracter: "+firstName[firstName.Length - 1]);
            //saber a posição específica
            Console.WriteLine(firstName +", posição específica do caracter: "+ firstName.IndexOf("n"));
            //substring
            string fullName = firstName + " " + lastName;
            int charPosSpace = fullName.IndexOf(" ");
            string sobreNome = fullName.Substring(charPosSpace + 1);
            Console.WriteLine($"Sobrenome: {sobreNome}, tamanho: {sobreNome.Length}");
        }
    }
}