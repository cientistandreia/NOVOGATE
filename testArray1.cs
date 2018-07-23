using System;
using System.IO;

static class Program
{
    static void Main()
    {

        int[] numeros = ParseNumberFile("agenda.txt");
    }

    static int[] ParseNumberFile(string filename)
    {
        string fileContent = File.ReadAllText(filename);

        string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int[] integers = new int[integerStrings.Length];

        for (int n = 0; n < integerStrings.Length; n++)
            integers[n] = int.Parse(integerStrings[n]);



        return integers;
    }

}