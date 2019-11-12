using System;

namespace CandyMarket.Api.DataModels
{
    public class Candy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CandyTypeId { get; set; }

        public string CandyFlavor { get; set; }


    }
}
