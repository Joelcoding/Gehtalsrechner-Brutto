// Gehaltsrechner coded by Viper:)

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" Geben sie ihren StundenLohn an:");
float StundenlohnBrutto = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Stunden im Monat:");
float StundenProMonat = Int32.Parse(Console.ReadLine());



//Tageslohn ist die variable es enthält = Den StundenLohn der mal 8 genommen wird
//dann hat man den Tageslohn
float TageslohnBrutto = StundenlohnBrutto * 8;


//Monatslohn ist die variable es enthält = Den StundenLohn der mal die Stunden von dem Monat genommen wird
//dann hat man den Monatslohn
float Monatslohn = StundenlohnBrutto * StundenProMonat;


//Jahreslohn ist die variable es enthält = Den Monatslohn der mal 12 genommen wird
//dann hat man den Jahres Lohn weil ein Jahr 12Monate hat
float JahresLohn = Monatslohn * 12;  // Der Monatslohn mal 12 = Jahreslohn

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("      LÖHNE IN BRUTTO BEI GEARBEITETEN 8H");
Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("    Der StundenLohn beträgt:" + StundenlohnBrutto + " EURO ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("     Der TagesLohn beträgt:" + TageslohnBrutto + " EURO ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("    Der MonatsLohn beträgt:" + Monatslohn + " EURO ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("    Der Jahreslohn beträgt:" + JahresLohn + " EURO ");
Console.WriteLine("--------------------------------------------------");
Console.ReadKey();




