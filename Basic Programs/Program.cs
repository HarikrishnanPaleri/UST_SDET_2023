// See https://aka.ms/new-console-template for more information

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







