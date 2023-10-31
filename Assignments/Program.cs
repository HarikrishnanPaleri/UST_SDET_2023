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
/*
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
}*/

//20-10-2023

using Assignments;
using Assignments.ExceptionHandling;
/*
Console.WriteLine("1. EP\n2. DP\n3. CP");
switch(Convert.ToInt32(Console.ReadLine()))
{
case 1:
ElectronicsProduct ep = new ElectronicsProduct("Iphone", 85000, 1, 1);
ep.DisplayProductDetails();
ep.DisplayWarranty();
break;

case 2:

DigitalProduct dp = new("Bose", 60000, 2, 5, "mp3");
dp.DisplayProductDetails();
dp.DisplayWarranty();
dp.DisplayDigitalProduct();
break;

case 3:
ClothingProduct cp = new("LV", 30000, 2, "large");
cp.DisplayProductDetails();
cp.DisplaySize();
break;
}
*/
/*
Employee emp = new(44, "Harikrishnan", "Paleri", 17);
emp.DisplayInfo();
*/
/*
Circle c = new Circle() { Radius = 4 };
c.Draw();
Rectangle r = new Rectangle()
{
    Length = 4,
    Width = 5

};

r.Draw();

*/
/*
InsurancePolicy inp = new InsurancePolicy("LIC",12345678,20000);
inp.RenewPolicy(25000);
inp.RenewPolicy();
*/
/*
LifeInsurance li = new LifeInsurance("LIC", 12456727, 20000, 59);
li.CalculatePremium();
Console.WriteLine("Your premium amount is : {0}", li.PremiumAmount);

CarInsurance ci = new CarInsurance("LIC", 12456727, 20000, 400000);
ci.CalculatePremium();
Console.WriteLine("Premium for your Car Insurance is : {0}",ci.PremiumAmount);
*/
/*
Customer cus1 = new(123, "aa", "1637838", 67);
Customer cus2 = new(456, "bb", "1636838", 97);
Customer cus3 = new(789, "cc", "1638838", 87);

Dictionary<int, Customer> cust = new Dictionary<int, Customer>
{
    {0, cus1},
    {1, cus2},
    {2, cus3},

};
SearchCustomer("1637838");
DisplayCustomer();
void SearchCustomer(string phoneno)
{
    foreach (var i in cust.Values)
    {
        if (phoneno == i.PhoneNumber)
        {
            Console.WriteLine("Customer found");
            Console.WriteLine(i.Name);
            Console.WriteLine(i.Balance);
            break;
        }
        else { Console.WriteLine("customer doesnt exist");
        }
    }
}
void DisplayCustomer()
{
    foreach (var i in cust.Values)
    {
        Console.WriteLine("Customer Id:{0}\tName:{1}\tPhoneNumber{2}\tBalance:{3}", i.CustomerId, i.Name, i.PhoneNumber, i.Balance);
    }
}
*/
/*
CallRecord clr1 = new(123,9447539005,33);
CallRecord clr2 = new(456,8848475311,44);
CallRecord clr3 = new(789,9020202022,55);

Dictionary<int, CallRecord> clr = new Dictionary<int, CallRecord>
{
    {0, clr1},
    {1, clr2},
    {2, clr3},

};
CallHistory(9447539005);
TotalCalls();
void CallHistory(double phoneno)
{
    foreach (var i in clr.Values)
    {
        if (phoneno == i.PhoneNumber)
        {
            Console.WriteLine("CallId:{0},PhoneNumber:{1}\t,CallTime:{2}",i.CallId,i.PhoneNumber,i.CallTime);
        }
       
    }
}
void TotalCalls()
{
    Dictionary<double, int> totalcall = new Dictionary<double, int>();
    foreach (var i in clr.Values)
    {
        if (totalcall.ContainsKey(i.PhoneNumber))
        {
            totalcall[i.PhoneNumber]++;
        }
        else
        {
            totalcall[i.PhoneNumber] = 1;
        }
    }
    foreach (var i in totalcall)
    {
        Console.WriteLine("PhoneNumber:{0}\t", i.Key, i.Value);
    }
}
*/
/*
Patient patie = new(1, "aaa", 145, "chickun gunia");
try
{
    patie.AddPatient(patie);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

*/
/*
MedicalRecord mdr = new(123, "Adi", 23, "Loose motion", 1234, -1);
try
{
    mdr.MedRecDetails(mdr);
}
catch(InvalidPatientDataException ipd)
{
   Console.WriteLine(ipd.Message);
}
catch(InvalidMedicalRecordException imd)
{
   Console.WriteLine(imd.Message);
}
*/

/*
repeat:
Console.WriteLine("Select from options");
Console.WriteLine("1.Add Patient\n2.View Patient\n3.Exit");
string? choose = Console.ReadLine();
if (choose == "1")
{
    Console.WriteLine("Enter id:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter name:");
    string? name = Console.ReadLine();
    Console.WriteLine("enter age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter diagnosis:");
    string? diagnosis = Console.ReadLine();
    Patient patient = new(id, name, age, diagnosis);
    //patient.CreateFile();
    patient.PatientDetails(patient);
  
}
else if(choose == "2")
{
    Patient.ViewPatientData();
}
Console.WriteLine("Do you want to continue? (Y/N)");
string? title =Console.ReadLine();
if(title=="y")
{
    goto repeat;
}


MedicalHistory mhy1 = new MedicalHistory(1,10,"cold","10/03/2023");
MedicalHistory mhy2 = new MedicalHistory(2, 10, "old", "11/03/2023");
MedicalHistory mhy3 = new MedicalHistory(3, 11, "ld", "12/03/2023");
MedicalHistory.mh.Add(mhy1);
MedicalHistory.mh.Add(mhy2);
MedicalHistory.mh.Add(mhy3);

repeat:
Console.WriteLine("1.Add Medical History 2.View Medical History 3.Exit");
string? choose = Console.ReadLine();
if (choose == "1")
{
    MedicalHistory.AddMedHisFile(mhy1);
    MedicalHistory.AddMedHisFile(mhy2);
    MedicalHistory.AddMedHisFile(mhy3);
}
else if (choose == "2")
{
    MedicalHistory.ViewMedHisData();
}
Console.WriteLine("Do you want to continue? (Y/N)");
string? title = Console.ReadLine();
if (title == "y")
{
    goto repeat;
}
*/
/*
var RoomType1 = "single";
var RoomType2 = 3;

RoomReservation<string>.BookRoom(444, ref RoomType1);
//RoomReservation<int>.BookRoom(666, ref RoomType2);
RoomReservation<string>.CancelRoom(444);
*/
/*
var typ1 = "Iphone";
var typ2 = 20;
var typ3 = "onida";
Product<string>.AddProduct(1, ref typ1, 5, 1);
Product<int>.AddProduct(2, ref typ2, 7, 4);
Product<string>.UpdateProduct(1, typ3);
Product<string>.DeleteProduct(2);
Product<string>.SearchProduct(1);
*/

public delegate double Empo(double pr);
class Program
{
    public static void Main(string[] args)
    {
        repeat:
        Console.WriteLine("Enter id:");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter name:");
        string? nm = Console.ReadLine();
       Employee1 employee1 = new Employee1();
        employee1.EmployeeId = Id;
        employee1.Name = nm;
        Console.WriteLine("Select bonus calculation method");
        Console.WriteLine("1.Performance Rating\n2.Criteria");
        string? choose = Console.ReadLine();
        if(choose =="1")
        {
            Empo eo = Employee1.CalculateBonus;
            Console.WriteLine("Enter performance threshold:");
            Console.WriteLine(eo.Invoke(Convert.ToDouble(Console.ReadLine())));
        }
        else if(choose =="2") 
        {
            Empo eo = Employee1.CalculateBonus1;
            Console.WriteLine("Enter performance threshold:");
            Console.WriteLine(eo.Invoke(Convert.ToDouble(Console.ReadLine())));

        }
        Console.WriteLine("Do you want to continue? (Y/N)");
        string? title = Console.ReadLine();
        if (title =="y")
        {
            goto repeat;
        }


    }
}