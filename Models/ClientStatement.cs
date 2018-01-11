
namespace InformationSystem.Models
{
    public class ClientStatement
    {
        public int idClientStatement { get; set; }
        public int idClient { get; set; }
        public int idAdmin { get; set; }
        public bool stateOfClientStatement { get; set; }
        public int price { get; set; }

    }
}
