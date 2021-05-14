using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;

namespace CovidApp
{
    public class SaveAndLoadIn
    {
        private StorageFolder strorageFolder = ApplicationData.Current.LocalFolder;
        private StorageFile patientsFile;
        private string patientsFileName = "Patients.txt";
        private List<Patient> patients= new List<Patient>();

        public SaveAndLoadIn()
        {
            Task.Run(() => loadFile(this.patientsFile, patientsFileName));
            Thread.Sleep(500);
        }

        private async Task loadFile(StorageFile file, string fileName)
        {
            try
            {
                patientsFile = await strorageFolder.GetFileAsync(patientsFileName);
            }
            catch(Exception e)
            {
                patientsFile = await strorageFolder.CreateFileAsync(patientsFileName);
            }
            finally
            {
                await loadData();
            }
        }

        public async Task loadData()
        {
            var text = await FileIO.ReadLinesAsync(patientsFile);
            
            string[] parts;
            if (text.Count > 0)
            {
                
                for (int i = 0; i < text.Count; i++)
                {
                    
                    if (text[i] == "") continue;
                    parts = text[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var partsPatient = new List<string>();
                    for (int j = 7; j < parts.Length; j++)
                    {
                        partsPatient.Add(parts[j]);
                    }
                    this.patients.Add(new Patient(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], partsPatient));
                    parts = null;
                }
            }
        }
        
        public async Task savePatient(Patient patient)
        {
            await FileIO.AppendTextAsync(patientsFile, $"{patient.FamilyName} {patient.FirstName} {patient.Age} {patient.Email} {patient.PhoneNumber} {patient.Sex} {patient.Region} {patient.SymptomsString}\n");
        }

        public List<Patient> getPatients()
        {
            return this.patients;
        }
    }

}
