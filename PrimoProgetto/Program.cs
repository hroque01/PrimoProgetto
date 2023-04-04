// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modifica");

//variables
var eta = 15;

//condition if your age is above +18

    //posso scrivere questo blocco senza graffe se ho solo 1 comando
if(eta>=18)
    Console.WriteLine("sei +18"); 

    //qui ho bisogno delle graffe perche ho piu funzioni
else
{   
    Console.WriteLine("sei minorenne");
    var rimanente = 18 - eta;
    //Console.WriteLine("ti mancano ancora " + rimanente + "anni");
    Console.WriteLine($"ti mancano ancora {rimanente} anni");
}


string[] mesi = { "gennaio", "febbraio", "marzo" };
mesi = new string[] { "aprile", "maggio"};