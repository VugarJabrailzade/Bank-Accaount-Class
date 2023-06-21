// See https://aka.ms/new-console-template for more information


using System;
using System.Security.Cryptography.X509Certificates;

class BankAccaount
{
    public string Fullname;
    public string Bankname;
    public ulong Code16;
    public int CodeCVV;
    public int Endtime;
    public decimal Balance;
}

public class Program
{
    public static void Main(string[] args)
    {

        BankAccaount bank = new BankAccaount();
        bank.Fullname = "Vugar Jabrailzade";
        bank.Bankname = "Unibank";
        bank.Code16 = 4525363514525263;
        bank.Endtime = 2023 ;
        bank.CodeCVV = 100;
        bank.Balance = 220.50m;

        Console.WriteLine($"Full Name: {bank.Fullname}");
        Console.WriteLine($"Bank Name: {bank.Bankname}");
        Console.WriteLine($"Code16: {bank.Code16}");
        Console.WriteLine($"Code CVV: {bank.CodeCVV}");
        Console.WriteLine($"Card end time: {bank.Endtime}" );
        Console.WriteLine($"Balance: {bank.Balance}");
        
    }
}
 