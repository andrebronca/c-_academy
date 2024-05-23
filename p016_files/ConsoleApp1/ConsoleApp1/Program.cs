using System;
using System.IO;

const string NOME_ARQUIVO = "fileText.txt";
string writeText = "Escrevendo em arquivo...";
File.WriteAllText(NOME_ARQUIVO, writeText);

string readText = File.ReadAllText(NOME_ARQUIVO);
Console.WriteLine(readText);