using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public int RecordId { get; set; }
        public int PatientId {  get; set; }
        public string? Description { get; set;}
        public string? Date { get; set; }

        public static List<MedicalHistory>mh =new List<MedicalHistory>();

        public MedicalHistory(int recordId, int patientId, string? description, string? date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public static void AddMedHistory(MedicalHistory medh)
        {
            mh.Add(medh);
            Console.WriteLine("Medical History has been added");

        }
        public static void CreateFiles()
        { FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\medhisdata.txt", FileMode.Create, FileAccess.Write); }
        public static void AddMedHisFile(MedicalHistory medh)
        {
            FileInfo fi = new FileInfo("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\medhisdata.txt");
            if (!fi.Exists )
            
                CreateFiles();
                else
                {
                FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\medhisdata.txt", FileMode.Append, FileAccess.Write);
                mh.Add(medh);
                Console.WriteLine("Medical History Added");
                StreamWriter stw = new StreamWriter(fs);
                stw.Write(medh.PatientId + "\t");
                stw.Write(medh.RecordId + "\t");
                stw.Write(medh.Description + "\t");
                stw.Write(medh.Date + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
                fs.Close();

            }
            }

        public static void ViewMedHisData()
        {

            FileStream fs = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\PatientInfo\\medhisdata.txt", FileMode.Open, FileAccess.Read);
            StreamReader stw = new StreamReader(fs);
            stw.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = stw.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = stw.ReadLine();
            }
            stw.Close();
            fs.Close();
        }
        }

    }

