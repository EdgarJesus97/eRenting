using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRenting.Models.ViewModels
{
    public class CreateFuncionario
    {
        public IEnumerable<Empresa> ListEmpresa { get; set; }    
        public Funcionario Funcionario { get; set; }
       
    }
}