using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsCertcar.Models
{
    public class v_Nortix
    {

      
        public string id_consulta { get; set; }
        public string id_modelo { get; set; }
        public string nr_ano { get; set; }
        public string ds_placa { get; set; }
        public string vl_fipe { get; set; }
        public string id_sucateamento { get; set; }
        public string fl_nortix { get; set; }
        public string dt_consulta { get; set; }
        public string ds_modelo { get; set; }
        public string ds_fabricante { get; set; }
        public string ds_chassi { get; set; }
        public string ds_renavan { get; set; }
        public string nr_motor { get; set; }
        public string nr_anoModelo { get; set; }
        public string nr_anoFabricacao { get; set; }
        public string nr_lead { get; set; }
        public string Dias { get; set; }
        public string fl_liberaConsulta { get; set; }
    }
    public class v_NortixCentral
    {


     
        public string id_sucateamento { get; set; }
        
    }

}