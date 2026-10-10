namespace Advanced_03
{
    internal class Program
    {
        public void StudentGradeManager()
        {
            #region Student grade manager
            List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };
            Console.WriteLine("Grades: " + string.Join(", ", grades));
            #endregion
        }


        static void Main(string[] args)
        {

        }
    }
}
