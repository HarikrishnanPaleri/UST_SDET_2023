using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patientId, string? name, int age, string? diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
        List<Patient> patientDetails = new List<Patient>();
        public void AddPatient(Patient patient)
        {
            if ((patient.Age < 0 || patient.Age > 120))
            {
                throw new ArgumentException("age should be between 0 and 120");
            }
            else if (patient.Name == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("patient name and diagnosis shouldnot be null");
            }
            else
            {
                patientDetails.Add(patient);
                Console.WriteLine("patient added");
            }
        }
        public void CreateFile()
        {
           FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\Patient.txt", FileMode.Create, FileAccess.Write);
            //fs.Close();
        }
        public void PatientDetails(Patient patient)
        {
            FileInfo fi = new FileInfo("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\Patient.txt");
            if (!fi.Exists)
                CreateFile();
            else
            {
                patientDetails.Add(patient);
                Console.WriteLine("patient added");
                FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\Patient.txt", FileMode.Append, FileAccess.Write);
               
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(patient.PatientId + "\t");
                sw.Write(patient.Name + "\t");
                sw.Write(patient.Age + "\t");
                sw.Write(patient.Diagnosis + "\t");
                sw.Flush();
                sw.Close();
                fs.Close();

            }
        }
            public static void ViewPatientData()
            {
                FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\Patient.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string? str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

            }
        }
    }


