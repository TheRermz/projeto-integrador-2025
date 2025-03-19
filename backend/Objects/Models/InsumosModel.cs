using System.ComponentModel.DataAnnotations.Schema;

namespace api_mrp.Objects.Models
{
    public class InsumosModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public int qntd { get; set; }
        public float custo { get; set; }
        public int id_fornecedor { get; set; }
    }
}


