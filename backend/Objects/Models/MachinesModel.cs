using api_mrp.Objects.Dto;

namespace api_mrp.Objects.Models
{
    public class MachinesModel
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public MachinesStatus status { get; set; }
        public UserModel idMachine { get; set; }
        public string serialNumber { get; set; }
        public string CPH { get; set; }
    }
}
