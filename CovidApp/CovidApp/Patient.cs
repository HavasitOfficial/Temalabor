using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    public class Patient
    {
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public string Region { get; set; }
        public List<string> symptom { get; set; }
        public string SymptomsString { get;private set; }
        public Patient(string family, string firstname, string age, string email, string phone,string sex, string region, List<string> symptom)
        {
            this.FamilyName = family;
            this.FirstName = firstname;
            this.Age = age;
            this.Email = email;
            this.PhoneNumber = phone;
            this.Sex = sex;
            this.symptom = symptom;
            this.Region = region;
            SymptomsString = ListToString(this.symptom);
        }

        private string ListToString(List<string> symptom)
        {
            var sv = "";
            foreach (var item in symptom)
            {
                sv += item + " ";
            }
            return sv;
        }
    }
}
