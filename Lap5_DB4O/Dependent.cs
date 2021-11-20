namespace Lap5_DB4O
{
    public class Dependent
    {
        // attributes
        public string Name { get; set; }
        public char Gender { get; set; }
        public string BirthDate { get; set; }
        public string Relationship { get; set; }

        // relationships
        public Employee DependentOf { get; set; }

    }
}