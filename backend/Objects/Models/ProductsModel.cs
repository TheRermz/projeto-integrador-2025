using System.ComponentModel.DataAnnotations.Schema;

namespace api_mrp.Objects.Models;

public class ProductsModel
{
    public int id { get; set; }
    public string nome { get; set; }
    public string tipo { get; set; }
    public string codigo { get; set; }
    public int id_Maquina { get; set; }

    [ForeignKey("id_Maquina")]
    public MachinesModel? machinesID { get; set; }
    public int id_Funcionario { get; set; }

    [ForeignKey("id_Funcionario")]
    public UserModel? userID { get; set; }
    public int qntd { get; set; }
    public decimal custo { get; set; }
}