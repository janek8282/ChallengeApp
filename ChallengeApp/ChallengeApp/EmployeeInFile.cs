using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        /*//(1)moje - 
        public List<float> grades = new List<float>();*/

        public const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        { }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                }
                else
                {
                    throw new Exception("Invalid grade -> out of range");
                }
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not a float");
            }
        }
        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }
        }
        /*//(1)moje -
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        float number = float.Parse(line);
                        grades.Add(number);
                    }
                }
            }
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }
            statistics.Avg /= this.grades.Count;

            switch (statistics.Avg)
            {
                case var temp when temp >= 80:
                    statistics.AvgLetter = 'A';
                    break;
                case var temp when temp >= 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var temp when temp >= 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var temp when temp >= 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    throw new Exception($"Average below the lower limit : < 20" +
                        $" \nOcena pracownika : 'N'" +
                        $"\nWartość min : {statistics.Min}" +
                        $"\nWartość max : {statistics.Max}" +
                        $"\nWartość avg : {statistics.Avg}");
            }
            return statistics;
        }*/


        //(2 -Adam)
        //metoda GetStatistics() została rozbita na dwie metody prywatne:
        //-ReadGradesFromFile() --> stworzona jako metoda typu lista, odczytuje dane z pliku, zapisuje je w postaci lisy tymczasowej i zwraca listę
        //-CountStatistics(gradesFromFile) --> stworzona jako metoda typu Satistics, oblicza jak poprzednio statystyki i je zwraca, posiada argument-listę

        public override Statistics GetStatistics()
        {
            var gradesFromFile = ReadGradesFromFile();
            var countStatistics = CountStatistics(gradesFromFile);
            return countStatistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        float number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }
            statistics.Avg /= grades.Count;

            switch (statistics.Avg)
            {
                case var temp when temp >= 80:
                    statistics.AvgLetter = 'A';
                    break;
                case var temp when temp >= 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var temp when temp >= 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var temp when temp >= 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    throw new Exception($"Average below the lower limit : < 20" +
                        $" \nOcena pracownika : 'N'" +
                        $"\nWartość min : {statistics.Min}" +
                        $"\nWartość max : {statistics.Max}" +
                        $"\nWartość avg : {statistics.Avg}");
            }
            return statistics;
        }
    }
}
