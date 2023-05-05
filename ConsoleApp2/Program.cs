using ConsoleApp2;

mesele mesel = new mesele();
mesel.name = "Emil";
mesel.surname = "Hwseynov";
mesel.age = 23;
mesel.ad();
Console.WriteLine(mesel.yas());
Console.WriteLine("--------------------------");
Class1 klas = new Class1();
klas.ad = "Emil";
klas.soyad = "H";
klas.yas = 23;
klas.fullname();
Console.WriteLine(klas.age());



class mesele
{
    public string name;
    public string surname;
    public int age;
    
    public void ad()
    {
        Console.WriteLine($"{name} {surname} registered");

    }

    public int yas()
    {
        return age;
    }

}
