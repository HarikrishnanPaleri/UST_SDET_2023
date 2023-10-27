using Assignments.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
        public MedicalRecord(int patientId, string? name, int age, string? diagnosis,int recordId,double treatmentCost) : base(patientId, name, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
        }

        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }

     public   List<MedicalRecord> medrc = new List<MedicalRecord>();
        public   void MedRecDetails(MedicalRecord medicalRecord)
        {
                if ((medicalRecord.Name =="" || medicalRecord.Diagnosis==""))
                {
                    throw new InvalidPatientDataException(Exceptio.exceptionmsg[0]);
                }
                else if (medicalRecord.TreatmentCost < 0 )
                {
                    throw new InvalidMedicalRecordException(Exceptio.exceptionmsg[1]);
                }
                else
                {
                    medrc.Add(medicalRecord);
                    Console.WriteLine("Record Details Added");
                }
            }
         
        }
    }
