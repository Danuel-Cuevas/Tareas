// See https://aka.ms/new-console-template for more information
using pract1csharp.Entities;

Teacher profe = new Teacher("Juan Pérez", "juan@correo.com", "8091234567", new DateTime(1985, 5, 15), "Mathematics", "Algebra", "Calculus I");
Console.WriteLine(profe.Got_information());