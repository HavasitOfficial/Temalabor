using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CovidApp
{
    class Save
    {
        private Patient patient;
        public Save(Patient patient)
        {
            this.patient = patient;
        }

        public async void savePatient()
        {

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.CreateFileAsync("AddPatient.txt", CreationCollisionOption.OpenIfExists);
            await FileIO.AppendTextAsync(sampleFile, $"{patient.FamilyName} {patient.FirstName} {patient.Age} {patient.Email} {patient.PhoneNumber} {patient.Sex} {patient.Region} {patient.symptom[0]} {patient.symptom[1]} {patient.symptom[2]} {patient.symptom[3]}\n");
        }
    }
}
