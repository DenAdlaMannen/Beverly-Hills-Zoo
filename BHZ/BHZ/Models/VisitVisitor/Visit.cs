namespace BHZ.Models.VisitVisitor
{
    public class Visit
    {
        public int Id { get; set; }
        public Visitor Visitor { get; set; }
        public string VisitTime { get; set; }
        public DateTime DateToVisit { get; set; }
        public int CompanyCount { get; set; } // Hur många den enskilde visitor tar med sig i sitt besök
        public List<Animal> Animals { get; set; }
    }
}
