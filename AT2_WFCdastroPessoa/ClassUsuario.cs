using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public class Usuarios
    {
        public Usuarios(int codigo, string? usuario, string? senha)
        {
            Codigo = codigo;
            Login = usuario;
            Senha = senha;
           
        }
        public Usuarios () { }
       
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }      

        public static List<Usuarios> ListaUsuarios = new List<Usuarios>();


    }
}
