namespace Advanced_03
{
    internal class Program
    {
        public static void Space()
        {
            Console.WriteLine();
        }
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

        public static void Leaderboard()
        {
            Space();
            Console.WriteLine("LEADERBOARD");
            Console.WriteLine("-----------------");
            SortedDictionary<int, string> leaderboard = new();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"Score: {entry.Key}, Name: {entry.Value}");
            }

            int firstKey = leaderboard.Keys.First();
            Console.WriteLine($"First key: {firstKey}");

            string firstValue = leaderboard.Values.First();
            Console.WriteLine($"First value: {firstValue}");

            Console.WriteLine($"Is 500 exists? {leaderboard.ContainsKey(500)}");

            if (leaderboard.TryGetValue(999, out string? name))
            {
                Console.WriteLine($"Name for score 999: {name}");
            }

            leaderboard.Remove(200);
            Console.WriteLine("Leaderboard after removing score 200:");
            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"Score: {entry.Key}, Name: {entry.Value}");
            }
        }

        public static void PhoneBook()
        {
            Space();
            Console.WriteLine("PHONE BOOK");
            Console.WriteLine("-----------------");

            var phoneBook = new Dictionary<string, string>
            {
                { "Maryam", "010167541" },
                { "Sara",  "010875463" },
                { "Ahmed",   "010865683" },
                { "Ali",  "011876456" }
            };

            phoneBook["Maryam"] = "011435893";
            phoneBook["Mona"] = "010876543";

            try
            {
                phoneBook.Add("Sara", "010876543");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sara's number already exists in the phone book.");
            }
            bool added = phoneBook.TryAdd("Sara", "010876543");
            Console.WriteLine($"Trying to add Sara succeeded or not?? {added}");

            if (phoneBook.TryGetValue("Khaled", out string? number))
                Console.WriteLine($"Khaled: {number}");
            else
                Console.WriteLine("Khaled was not found");

            string result = phoneBook.GetValueOrDefault("Khaled", "Not Found");
            Console.WriteLine($"Khaled: {result}");

            Console.WriteLine($"Keys: {string.Join(", ", phoneBook.Keys)}");
            Console.WriteLine($"Values: {string.Join(", ", phoneBook.Values)}");
        }

        static void Main(string[] args)
        {
            StudentGradeManager();

            Leaderboard();

            PhoneBook();
        }
    }
}
