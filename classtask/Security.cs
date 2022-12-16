
class Security:Person
{
    
    public Security() 
    {
        Name = "Royal";
        Surname="Mamedov";

        Console.WriteLine($"Salam men tehlukesizlik xidmmetinden: {Name} {Surname} ");
        Console.WriteLine("Clubumuza xos gelmisiniz!!!");
        Console.WriteLine("Evvelce onu deyim ki girish ucun yash minimumu 18-dir");
        Console.WriteLine("Zehemet olmasa shexsiyyet vesiqesini teqdim edin");
    }

    public void Ask(string question)
    {
   
         Console.WriteLine(question);
    }

}