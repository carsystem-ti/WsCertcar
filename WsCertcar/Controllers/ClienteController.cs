using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WsCertcar.Controllers
{
    public class ClienteController : ApiController
    {
        // GET: Cliente
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("getCliente/{tp}/{nr_doc}")]
        public IHttpActionResult getCliente(int tp,string nr_doc)
        {
            dao.daoCliente cliente = new dao.daoCliente();

            var dados = clientes(cliente.getCliente(tp, nr_doc));

            return Ok(dados);

        }

       
        public List<Models.Cliente> clientes(DataTable dt)
        {

            var convertedList =
                (from rw in dt.AsEnumerable()
                 select new Models.Cliente()
                 {
                     nr_contrato = rw["nr_contrato"].ToString(),
                     ds_estipulante = rw["ds_estipulante"].ToString(),
                     ds_corretor = rw["ds_corretor"].ToString(),
                     ds_segurado = rw["ds_segurado"].ToString(),
                     cpf = rw["nr_cpf"].ToString(),
                     ds_endereco = rw["ds_endereco"].ToString(),
                     ds_complemento = rw["ds_complemento"].ToString(),
                     ds_cidade = rw["ds_cidade"].ToString(),
                     ds_uf = rw["ds_uf"].ToString(),
                     nr_cep =  rw["nr_cep"].ToString(),
                     ds_forma = rw["ds_forma"].ToString(),
                     vl_servico = rw["vl_servico"].ToString(),
                     nr_parcelas = rw["nr_parcelas"].ToString(),
                     dt_emissao = rw["dt_emissao"].ToString(),
                     dt_iniVigencia = rw["dt_iniVigencia"].ToString(),
                     dt_fimVigencia = rw["dt_fimVigencia"].ToString(),
                 }).ToList();

            return convertedList;
        }
    }
}