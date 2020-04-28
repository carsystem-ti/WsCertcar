using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsCertcar.Models
{
    public class Cliente
    {
        public string nr_contrato { get; set; }

        public string ds_estipulante { get; set; }

        public string ds_corretor { get; set; }

        public string ds_segurado { get; set; }
        public string cpf { get; set; }

        public string ds_endereco { get; set; }
        public string ds_complemento { get; set; }
        public string ds_bairro { get; set; }
        public string ds_cidade { get; set; }
        public string ds_uf { get; set; }
        public string nr_cep { get; set; }

        public string ds_forma { get; set; }

        public string vl_servico { get; set; }
        public string nr_parcelas { get; set; }

        public string dt_emissao { get; set; }

        public string dt_iniVigencia { get; set; }
        public string dt_fimVigencia { get; set; }











    }
}