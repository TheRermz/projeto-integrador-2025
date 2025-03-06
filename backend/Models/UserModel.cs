using api_mrp.Models.Enums;

namespace api_mrp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string maquina { get; set; }
        public string cargo { get; set; }
        public string hierarquia { get; set; }
        public string setor {  get; set; }
        public UserStatus status { get; set; }
        public string senha { get; set; }

    }
}
