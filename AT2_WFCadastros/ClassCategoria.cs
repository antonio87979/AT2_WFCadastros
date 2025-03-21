using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public enum EStatus
    {
        Ativo = 1,
        Inativo = 2,
    }

    public class Categoria
    {
        public Categoria(string? nome, int codigo, string? dataCadastro, EStatus status, string? observacao)
        {
            Nome = nome;
            Codigo = codigo;
            DataCadastro = dataCadastro;
            Status = status;
            Observacao = observacao;
        }
        public Categoria() { }

        public static List<Categoria> ListaCategorias = new List<Categoria>();

        public string? Nome { get; set; }
        public int Codigo { get; set; }
        public string? DataCadastro { get; set; }
        public EStatus Status { get; set; }     
        public string? Observacao { get; set; }
        
    }
}
