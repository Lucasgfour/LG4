using LG4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Model {
    public class UsuarioPermissao {

        public int grupo { get; set; }
        public string nome { get; set; } = "";
        public YesNo read { get; set; }
        public YesNo write { get; set; }
        public YesNo update { get; set; }
        public YesNo delete { get; set; }

    }
}
