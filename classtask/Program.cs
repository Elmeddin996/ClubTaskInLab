
Security Royal = new Security();
Customer Customer= new Customer();

Royal.Ask("Adiniz");
Customer.Name = Customer.Answer();
Royal.Ask("Soyadiniz");
Customer.Surname= Customer.Answer();
Royal.Ask("Yashiniz");
Customer.Age=int.Parse(Customer.Answer());
Club ClubRules= new Club(); 
if (Customer.Age < 18)
{
    Console.WriteLine("Get Topunnan Oyna Yashin Chatmir");

}
else
{
    Console.WriteLine($"Cluba daxil olmaq ucun odenis cutlukler ucun{ClubRules.CuplePrice} Tek giris {ClubRules.SinglePrice}");
}
