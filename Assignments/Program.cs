//18-10-2023
/*
using Assignments;

Student student1 = new Student("hahah",90,80,70);
Console.WriteLine(student1.name);
Console.WriteLine(student1.CalculateAverage());
Console.WriteLine(student1.CalculateTotalMark());
*/

/*
using Assignments;

Product product1 = new Product("Cola", 40,2);
Product product2 = new Product("Pepsi", 35, 1);
Product product3 = new Product("Red Bull", 90, 3);


Product[] products = {product1, product2, product3};

product1.SetPrice(50);

foreach (Product product in products)
{
    product.DisplayProductDetails();
    
}
foreach (Product product in products)
{
    Console.WriteLine("Total value of " + product.ProductName + ":" + product.ProductValue());
}
*/

using Assignments;

Student[] student = new Student[3];
student[0] = new Student("Hari", "A", new int[] { 99, 86, 78 });
student[1] = new Student("Krishnan", "B", new int[] { 85, 66, 82 });
student[2] = new Student("Paleri", "B", new int[] { 99, 86, 78 });
foreach(Student s in student)
{
    s.DisplayStudents();
    s.CalculateAverage();
    s.GetMarksSummary();
    Console.WriteLine();
}