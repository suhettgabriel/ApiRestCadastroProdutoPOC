using ARCP.Domain.Util.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARCP.Domain
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [MaxLength(150, ErrorMessage = " O campo {0 deve ter no máximo {1} caracteres}")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public byte Midia { get; set; }
        public int Valor { get; set; }
        public int ValorPromocao { get; set; }
        public string Tag { get; set; }
        public List<Categoria> Categoria { get; set; }
        public IEnumerable<CategoriaEnum> listTipoCategoria { get; set; }
        public List<StatusProdutoEnum> StatusProduto { get; set; }
        public IEnumerable<StatusProdutoEnum> ListStatusProduto { get; set; }
        public List<TipoProdutoEnum> TipoProduto { get; set; }
        public IEnumerable<TipoProdutoEnum> ListTipoProduto { get; set; }
          


        public Produtos()
        {
            this.Categoria = new List<Categoria>();
            this.listTipoCategoria = (IEnumerable<CategoriaEnum>)Enum.GetValues(typeof(CategoriaEnum));
                        
            this.ListStatusProduto = (IEnumerable<StatusProdutoEnum>)Enum.GetValues(typeof(StatusProdutoEnum));
             
            this.ListTipoProduto = (IEnumerable<TipoProdutoEnum>)Enum.GetValues(typeof(TipoProdutoEnum));

        }

    }
}
