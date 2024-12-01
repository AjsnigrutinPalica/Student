 public class Student
{
    public string ime;
    public string prezime;

    public Student(string ime = "Ivan", string prezime= "Ragac")
    {
        this.ime = ime;
        this.prezime = prezime;
        Console.WriteLine($"{ime}{prezime} je stvoren/a");
    }
    public void IspisPodataka()
    {
        Console.WriteLine(ime, prezime);
    }


}