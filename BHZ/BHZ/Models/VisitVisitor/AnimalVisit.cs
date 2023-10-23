namespace BHZ.Models.VisitVisitor
{
    public class AnimalVisit
    {
        public int AnimalId { get; set; }
        public int VisitID { get; set; }
        public Animal Animal { get; set; }
        public Visit Visit { get; set; }
    }
}
