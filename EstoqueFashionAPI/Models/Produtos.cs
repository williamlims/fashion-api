using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueFashionAPI.Models
{
    public class Produtos
    {
        //id não deve ser acessado diretamente
        private int Id { get; set; }
        public int Status { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }     
        public int Quantidade { get; set; }
        public double Custo { get; set; }
        public string Imagem { get; set; }        
    }     

}
