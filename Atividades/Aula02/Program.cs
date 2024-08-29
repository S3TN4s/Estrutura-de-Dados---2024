using System.Reflection.Metadata.Ecma335;
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1
    = new Person("Gilmar Junior", 19);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Renato Garcia";
person2.Age = 32;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{
     Name = "Bolsonaro",
     Age = 70

};

Console.WriteLine(person3.Name);