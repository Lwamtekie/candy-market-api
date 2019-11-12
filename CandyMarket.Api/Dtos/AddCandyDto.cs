namespace CandyMarket.Api.Dtos
{
    public class AddCandyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int CandyTypeId { get; set; }

        public string CandyFlavor { get; set; }


    }
}