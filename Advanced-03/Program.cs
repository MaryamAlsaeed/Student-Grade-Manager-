namespace Advanced_03
{
    internal class Program
    {
        public static void StudentGradeManager()
        {
            #region Student grade manager

            Console.WriteLine("STUDENT GRADE MANAGER");
            Console.WriteLine("---------------------");

            List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First grade: {grades[0]}");
            Console.WriteLine($"Last grade: {grades[^1]}");

            grades.Sort();
            Console.WriteLine($"Sorted grades: {string.Join(", ", grades)}");

            int greaterthan90 = grades.Find(g => g > 90);
            Console.WriteLine($"First grade greater than 90: {greaterthan90}");

            List<int> below75 = grades.FindAll(g => g < 75);
            Console.WriteLine($"First grade below 75: {string.Join(", ", below75)}");


            int removeBelow75 = grades.RemoveAll(g => g < 75);
            Console.WriteLine($"Grades removed below 75: {removeBelow75}");

            Console.WriteLine($"Is this 100? {grades.Contains(100)}");

            List<string> stringGrades = grades.ConvertAll(g => g.ToString());
            Console.WriteLine($"String grades: {string.Join(", ", stringGrades)}");
            #endregion
        }


        static void Main(string[] args)
        {
            StudentGradeManager();
        }
    }
}
