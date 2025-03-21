using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public class Pessoas
    {
        public static List<Pessoas> ListaPessoas = new List<Pessoas>();

        public Pessoas(int codigo, string? nomeCompleto, string? cpf, string? email, string? ddd, string? celular, ETipoTelefone tipoTelefone, bool possuiFilhos)
        {
            Codigo = codigo;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Email = email;
            Ddd = ddd;
            Celular = celular;
            TipoTelefone = tipoTelefone;
            PossuiFilhos = possuiFilhos;
        }
        public Pessoas () { }

        public int Codigo { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Ddd { get; set; }
        public string? Celular { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public bool PossuiFilhos { get; set; }
    }
}
