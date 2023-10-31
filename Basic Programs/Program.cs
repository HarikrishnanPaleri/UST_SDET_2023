// See https://aka.ms/new-console-template for more information
/*
/*Console.WriteLine("enter 2 numbers");
int num1, num2, ans;
num1 = Convert.ToInt32(Console.ReadLine());

num2 = Convert.ToInt32(Console.ReadLine());


ans = num1 + num2;






Console.WriteLine(ans);
*/

/*
string? s1 = "";
string? s2 = "";
string s3;

s1 = Console.ReadLine();
s2 = Console.ReadLine();

s3 = s1 + " " + s2;
Console.WriteLine(s3);

Console.WriteLine(s1.Equals(s2));

Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s2.Substring(3));

string[] s =s3.Split(' ');
for (int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);

*/
/*

double x = 5;
switch (x)
{
 case 7.1:
 Console.Writeline("1");
        break;
    case 7.2:
        Console.WriteLine("2");
        break;
    case 7.3:
        Console.WriteLine("3");
        break;
        default: Console.WriteLine("4");
        break;

}
*/

/*
//driver

using Basic_Programs;
using System.Runtime.InteropServices.Marshalling;

Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
double res = calculation.Add(num1,num2);
Console.WriteLine(res);
*/
/*
using Basic_Programs;

Electricity electricity1 = new  (12345,9000,9300,"xxx");
//double billamount = electricity.CalculateBill();
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.CalculateBill());
Electricity electricity2 = new(66345, 8900, 9300, "xx");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill());
*/

/*using Basic_Programs;

Employee employee = new Employee(111, "hari", "IT", 30000);
Console.WriteLine(
   "Emp Id : {0} \n" +
   "Name : {1} \n" + 
   "Dept : {2} \n" +
   "BasicPay : {3}",   
    employee.Eid,
    employee.Ename,
    employee.Dept,
    employee.Basicpay);
Console.WriteLine("Salary :" + employee.CalculateSalary());
*/
/*
using Basic_Programs;
using System.Reflection.Metadata;

 ArraysEx arraysEx = new ArraysEx();
//arraysEx.Onedim();
//arraysEx.Twodim();
arraysEx.Ja();
*/
using Basic_Programs;
using Basic_Programs.ExceptionMessages;

//StudentMarks marks = new StudentMarks(1000,"Hari","Kannur",90,95,100,0,0);
//marks.DisplayStudentDetails();
//Console.WriteLine("Total:" +marks.CalculateTotal());
//Console.WriteLine("Average:" +marks.CalculateAverage());
/*
StudentMarks marks = new StudentMarks();
marks.RollNo = 1000;
marks.StudentName = "Harikrishnan";
marks.City = "Kannur";
marks.Mark1 = 90;
marks.Mark2 = 96;
marks.Mark3 = 99;
marks.DisplayStudentDetails();
Console.WriteLine("Total:" + marks.CalculateTotal());
Console.WriteLine("Average:" + marks.CalculateAverage());

*/
/*
StudentGrade grade = new ();
grade.RollNo = 1000;
grade.StudentName = "Harikrishnan";
grade.City = "Kannur";
grade.Mark1 = 90;
grade.Mark2 = 96;
grade.Mark3 = 99;
grade.DisplayStudentDetails();
Console.WriteLine("Total:" + grade.CalculateTotal());
Console.WriteLine("Average:" + grade.CalculateAverage());
Console.WriteLine("Average:" + grade.CalculateGrade());
*/

/*
Console.WriteLine("1. Ts 2. NTS 3.Student");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.CollegeName = "SCMS";
        ts.CollegePlace = "KANNUR";
        ts.Staffid = 111;
        ts.Name = "Hari";
        ts.Dept = "EEE";
        ts.Specializations = "OS, DBMS,DS";
        ts.Sem = 8;
        ts.DisplayCollegeDetails();
        ts.DisplayStaffDetails();
        ts.DisplayTSStaffDetails();
        break;

        case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.CollegeName = "SCMS";
        nts.CollegePlace = "KANNUR";
        nts.Staffid = 101;
        nts.Name = "Krishnan";
        nts.Dept = "Admin";
        nts.Responsibilities = "Attendance";
        nts.Experience = 10;
        nts.DisplayCollegeDetails();
        nts.DisplayStaffDetails();
        nts.DisplayNTSStaffDetails();
        break;
        case 3:
        StudentDetails sts = new StudentDetails();
       
        sts.RollNo = 1;
        sts.StudentName = "ABHINAND";
        sts.City = "KANNUR";
        sts.CollegeName = "SCMS";
        sts.CollegePlace = "Kannur";
        sts.DisplayCollegeDetails();
        sts.DisplayStudentDetails();
        break;
      


}
*/
/*
EV ev = new EV();
ev.Vehnum = 1442;
ev.Brand = "XX"
    ;
ev.Model = "aa";
ev.Disp();

Console.WriteLine(ev.SetTypeForVeh());


PV pv = new PV();
pv.Vehnum = 0000;
pv.Brand = "YY";
pv.Model = "BB";
pv.Disp();
Console.WriteLine(pv.SetTypeForVeh());
*/

/*Doctor doc = new Doctor();
doc.AddNewDoctor(11,"cc");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(987,"bb");
doc.DisplayDoctorDetails();
doc.BookApp(123 , "NEW");
doc.DelApp("hh");
*/
//BankDetails bd1 = new(1234, 15272772L, "BB","inactive");
//BankDetails bd2 = new();
/*
BankDetailsNew bd2 = new(1234, 15272772L, "BB", "inactive");
bd2.WelcomeMessage();



//bd2.WelcomeMessage("HARi");

Console.WriteLine("1. Custid 2. AccNo 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        Console.WriteLine("Custid :");
      //  bd.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
       // bd1.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        bd2.GetAccDetails(Convert.ToInt32(Console.ReadLine())); 
        break;
        case 2:
        Console.WriteLine("AccNo:");
       // bd.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
      //  bd1.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        bd2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Name:");
      //  bd.GetAccDetails(Console.ReadLine());
       // bd1.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        bd2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
  default:Console.WriteLine("Enter 1,2 or 3");
        break;


}
*/
/*
NGC ngc = new NGC();
//ngc.ArrayListHandling();
//ngc.Queuehandling();
//ngc.HThandling();
ngc.SLHandling();
*/
/*
Basic_Programs.GC gc = new Basic_Programs.GC();
//gc.ListHandling();
//gc.Stackhandking();
gc.Dicthandling();
*/
//ExcepHandling excep = new ExcepHandling(10, 2);
//try
//{
//    excep.Divide();
//}
//catch (ArithmeticException ex)
//{/*
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.StackTrace);
//                Console.WriteLine(ex.Source);*/

//    Console.WriteLine(MyExceptions.exmesslist[0]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.exmesslist[1]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyExceptions.exmesslist[2]);
//}
//finally
//{
//    Console.WriteLine("done");
//}
/*try
{
    excep.NumCheck();
   
}
catch (ArgumentException) 
{
  //  Console.WriteLine(MyExceptions.exmesslist[3]);


}*/

/*
try
{
    excep.NumCheck();
}
catch(MyExceptions.Number1Exception exce)
{
    Console.WriteLine(exce.Message);
}

try
{
    excep.NumCheck2();
}
catch (MyExceptions.Number2Exception exce)
{
    Console.WriteLine(exce.Message);
}
*/
/*

FileOperations fo = new FileOperations();
//fo.CreateFile();
//fo.WriteData();
//fo.ReadData();
//fo.CopyMoveFile();
//fo.DeleteData();
fo.FileProperties();


*/

/*
GenEx<int> g1 = new GenEx<int>(10,20);
Console.WriteLine(g1.Val1+" "+ g1.Val2);

GenEx<double> g2 = new GenEx<double>(10.98, 20.345);
Console.WriteLine(g2.Val1 + " " + g2.Val2);

GenEx<string> g3 = new GenEx<string>("Hi", "Hello");
Console.WriteLine(g3.Val1 + " " + g3.Val2);


GenEx<bool> g4 = new GenEx<bool>(true, false);
Console.WriteLine(g4.Val1 + " " + g4.Val2);
*/

//GenEx<int> ga1 = new GenEx<int>(new int[3] { 10, 20,30 });
//GenEx<int> ga = new GenEx<int>(new int[3]);
//ga1.Disp();
/*
static void Swap<T>(ref T num1, ref T num2)
{
    T temp;
    temp = num1;
    num1 = num2;
    num2 = temp;

}

int n1 = 10, n2 = 20;
char c1 = 'A', c2 = 'B';
Swap<int>(ref n1, ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("a = {0},b = {1}", n1, n2);
Console.WriteLine("c = {0},d = {1}", c1, c2);
*/

public delegate void Del1();//declare the delegate
public delegate void Del2(string msg);
public delegate void Del3(int n1, int n2);
public delegate int Del4(int n1, int n2);

class Program
{
    public static void delcall()
    {
        Del1 dobj1 = DelEx.MethodA;
        dobj1.Invoke();

        Del2 dobj2 = DelEx.MethodB;
        dobj2.Invoke("hi");
    }
    public static void Main(string[] args)
    {
        /*
        Del1 dobj1 = DelEx.MethodA;
        dobj1.Invoke();

        Del2 dobj2 = DelEx.MethodB;
        dobj2.Invoke("hi");
        */

        delcall();

        DelEx delEx = new();
        Del3 dobj3 = delEx.Add;
        Del3 dobj5 = delEx.sub;

        Del3 dforall = dobj3 + dobj5;

       dforall(10, 20);

        
        DelEx delEx1 = new();
        Del4 dobj4 = delEx1.Add1;
        Console.WriteLine(dobj4(10, 4));
    }
    

}