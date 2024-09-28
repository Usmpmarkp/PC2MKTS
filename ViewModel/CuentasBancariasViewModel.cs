using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PC2MKTS.Models;

namespace PC2MKTS.ViewModel
{
    public class CuentasBancariasViewModel
    {
        public Bancos? FormCuentasBancarias{ get; set; }
        public List<Bancos>? ListarCuentasBancarias { get; set; }
    }
}