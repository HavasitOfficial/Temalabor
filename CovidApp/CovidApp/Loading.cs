using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{

    class Loading
    {
        private string path;
        private List<string> users;
        private List<string> password;

        private List<Patient> patients;

        public Loading(string path)
        {
            this.path = path;
        }

        public void UsernameAndPasswordLoading()
        {
            this.users = new List<string>();
            this.password = new List<string>();
            var sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(parts[0]);
                password.Add(parts[1]);
                new Windows.UI.Popups.MessageDialog($"{parts[0]}        !{parts[1]}!").ShowAsync();
            }
        }

        public void loadingPatient()
        {
            this.patients = new List<Patient>();
            var sr = new StreamReader(this.path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var partsPatient = new List<string>();
                for (int i = 7; i < parts.Length; i++)
                {
                    partsPatient.Add(parts[i]);
                }
                var patient = new Patient(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5],parts[6], partsPatient);
                patients.Add(patient);

            }
        }

        public List<string> getUsers()
        {
            return this.users;
        }
        public List<string> getPasswords()
        {
            return this.password;
        }
        public List<Patient> getPatients()
        {
            return this.patients;
        }
    }
}
