using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    public class AverageAge
    {
        private List<Patient> patients;
        private int firstColumn;
        private int secondColumn;
        private int thirdColumn;
        private int fourthColumn;
        private List<int> intAge = new List<int>();
        public AverageAge(List<Patient> patients)
        {
            this.patients = patients;
            convertStringToInt();
            countAge();
        }
        public void convertStringToInt()
        {
            for (int i = 0; i < patients.Count; i++)
            {
                try
                {
                    int numVal = Int32.Parse(patients[i].Age);
                    intAge.Add(numVal);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void countAge()
        {

            this.firstColumn = (from n in intAge
                                where n < 20
                                select n).Count();

            this.secondColumn = (from n in intAge
                                 where n >= 20 && n <= 39
                                 select n).Count();

            this.thirdColumn = (from n in intAge
                                where n > 40 && n <= 64
                                select n).Count();

            this.fourthColumn = (from n in intAge
                                 where n > 65
                                 select n).Count();
        }
        public int getFirstColumn()
        {
            return this.firstColumn;
        }
        public int getSecondColumn()
        {
            return this.secondColumn;
        }
        public int getThirdColumn()
        {
            return this.thirdColumn;
        }
        public int getFourthColumn()
        {
            return this.fourthColumn;
        }
    }
}
