namespace DemoEF.Models
{
    class Dependant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee Employee { get; set; }
    }
}
