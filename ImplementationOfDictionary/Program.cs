﻿namespace ImplementationOfDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary otusDictionary = new OtusDictionary();
            otusDictionary.Add(1, "one");
            otusDictionary.Add(2, "two");
            otusDictionary.Add(3, "three");
            otusDictionary.Add(1, "four");
            otusDictionary.Get(1);
            otusDictionary.Get(2);
        }
    }
}
