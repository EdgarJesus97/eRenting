using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRenting.Models.ViewModels
{

    public class ViewEmpresa
    {
        public Empresa Empresa { get; set; }
        public List<Funcionario> Funcionario { get; set; }

        public ViewEmpresa()
        {
            this.Empresa = Empresa;
            this.Funcionario = new List<Funcionario>();
        }
    }
}