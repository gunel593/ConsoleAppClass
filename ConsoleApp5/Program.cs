// See https://aka.ms/new-console-template for more informati
Person person = new Person();
person.Name = "Emilia";
person.Age = 21;
person.Surname = "Ehmedzade";
Modify(person);
Mdf(out person);
    Mdfy(ref person);
Console.WriteLine(person.Name); 
Console.WriteLine(person.Age);  
Console.WriteLine(person.Surname);

static void Modify(Person person)
{  
    person= new Person();   
  
    person.Name= "Aytac";

}
static void Mdf(out Person person)
{
    person = new Person();
    person.Age = 20;
}
static void Mdfy(ref Person person)
{
    
    person.Surname = "Elizade";
}
class Person
{
    public string Name {  get; set; }
    public int Age { get; set; }
    public string Surname { get; set; }
}
