using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WsCertcar.dao;
using WsCertcar.Models;

namespace WsCertcar.Controllers
{
    public class ClienteController : ApiController
    {


        string _placa= null;
        daoPlaca _model = new daoPlaca();

        // GET: Cliente
        //[System.Web.Http.AcceptVerbs("GET")]
        //[System.Web.Http.Route("getByPlaca/{ds_placa}")]
        //public IHttpActionResult getByPlaca(string ds_placa)
        //{
        //    dao.daoPlaca cliente = new dao.daoPlaca();

        //    var dados = getConsultaPlaca(ds_placa);

        //    return Ok(dados);

        //}
        public bool ValidaPlaca(string Placa)
        {
            Placa = Placa.Replace("-", "").ToUpper();
            Placa = Placa.Replace(" ", "").ToUpper();


            Regex _padraoAntigo = new Regex("^[a-zA-Z]{3}[0-9]{4}$");
            Regex _padraoMercosul = new Regex("^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");

            if (_padraoAntigo.IsMatch(Placa) || _padraoMercosul.IsMatch(Placa))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("getByDocumento/{nr_documento}")]
        public IHttpActionResult getByDocumento(string nr_documento)
        {
            CarSystem.Banco.BoaVista.BoaVista bv = new CarSystem.Banco.BoaVista.BoaVista("userFranquia", "2FACA908-D931-4DA8-BC99-497C7B515021", "principal", CarSystem.Tipos.Servidores.Fury);
            CarSystem.Banco.BoaVista.BoaVista.Consulta iConsulta = bv.efetuaConsultaWS(nr_documento, false);
            return Ok(iConsulta.statusConsulta);
            //if (iConsulta.numeroInscricaoEstadual == null)
            //{
            //    iConsulta.numeroInscricaoEstadual = "ISENTO";
            //}
            //if (iConsulta.nome != "erro" && iConsulta.nome != "")
            //{
            //    string retorno = iConsulta.statusConsulta.ToString();
            //    if (retorno == "Aprovado" || retorno == "Reprovado")
            //    {
            //    }
            //}
        }
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("getByPlaca/{ds_placa}")]
        public IHttpActionResult getByPlaca(string ds_placa)
        {
            int retorno = 0;
            bool _validaPlaca = false;
            _placa = ds_placa;
            _validaPlaca = ValidaPlaca(_placa);
            if (_validaPlaca)
            {
                DataTable dt = _model.getPlaca(ds_placa);
                if (dt.Rows.Count > 0)
                {
                    int dias = Convert.ToInt32(dt.Rows[0]["fl_liberaConsulta"].ToString());

                    if (dias == 1)
                    {
                        retorno = consultaPlaca(ds_placa);
                        dt = _model.getPlaca(ds_placa);
                        var Lista = Resultado(_model.getPlaca(ds_placa));
                        return Ok(Lista);
                    }
                    else
                    {
                        //dt = _model.getPlaca(ds_placa);
                        var Lista = Resultado(_model.getPlaca(ds_placa));
                        return Ok(Lista);
                    }
                }
                else
                {

                    retorno = consultaPlaca(ds_placa);
                     var Lista = Resultado(_model.getPlaca(ds_placa));
                    return Ok(Lista);
                }
            }
            else
            {
                return BadRequest("Placa no formato");
            }

        }
        public int consultaPlaca(string ds_placa)
        {
            Nortix ntx = new Nortix();
            try
            {
                if (ConfigurationManager.AppSettings[("fl_ValidaPlaca")] == "1")
                {
                    using (ValidaPlacaNortix.clsSicVinAgSoapClient ntxPlaca = new ValidaPlacaNortix.clsSicVinAgSoapClient("clsSicVinAgSoap"))
                    {
                        var placa = ntxPlaca.InputSicVinAgRst("carsystem", "carsystem", "ntx6480", ds_placa, "");

                        if (placa.Resposta.Placa != "")
                        {
                            using (ServicoNortix.clsLeilao2SoapClient svc = new ServicoNortix.clsLeilao2SoapClient("clsLeilao2Soap"))
                            {
                                var dados = svc.InputVsRst("carsystem", "carsystem", "ntx6480", ds_placa, "");
                                if (dados.Resposta.Length > 0)
                                {
                                    foreach (var item in dados.Resposta)
                                    {
                                        if (item.Sucateamento > ntx.id_sucateamento)
                                        {
                                            ntx.id_sucateamento = item.Sucateamento;
                                            ntx.modelo = item.Modelo;
                                            ntx.AnoFabricacao = item.AnoFabricacao;
                                            ntx.ds_fabricante = item.Marca;
                                            ntx.nr_motor = item.NrMotor;
                                            ntx.nr_renavan = item.Renavam;
                                            ntx.placaNortix = ds_placa;
                                            ntx.nr_chassi = item.Chassi;
                                            ntx.AnoModelo = item.AnoModelo;
                                        }
                                    }
                                    _model.set_PlacaNortix(ntx.AnoModelo, ds_placa, ntx.id_sucateamento, ntx.modelo, ntx.ds_fabricante, ntx.nr_chassi, ntx.nr_renavan, ntx.nr_motor, ntx.AnoModelo, ntx.AnoFabricacao);
                                    return 1;
                                }
                                else
                                {
                                    _model.set_PlacaNortix(Convert.ToInt32(placa.Resposta.AnoModelo), ds_placa, 0, placa.Resposta.Modelo, placa.Resposta.Fabricante, placa.Resposta.Chassi, "NE", placa.Resposta.Motor, Convert.ToInt32(placa.Resposta.AnoModelo), Convert.ToInt32(placa.Resposta.AnoFabricacao));
                                    return 2;
                                }
                            }

                        }
                        else
                        {
                            _model.set_PlacaNortix(0, ds_placa, 0, "NE", "NE", "NE", "NE", "NE", 0, 0);
                            return -1;

                        }


                    }
                }
                else
                {
                    using (ServicoNortix.clsLeilao2SoapClient svc = new ServicoNortix.clsLeilao2SoapClient("clsLeilao2Soap"))
                    {
                        var dados = svc.InputVsRst("carsystem", "carsystem", "ntx6480", ds_placa, "");
                        if (dados.Resposta.Length > 0)
                        {
                            foreach (var item in dados.Resposta)
                            {
                                if (item.Sucateamento > ntx.id_sucateamento)
                                {
                                    ntx.id_sucateamento = item.Sucateamento;
                                    ntx.modelo = item.Modelo;
                                    ntx.AnoFabricacao = item.AnoFabricacao;
                                    ntx.ds_fabricante = item.Marca;
                                    ntx.nr_motor = item.NrMotor;
                                    ntx.nr_renavan = item.Renavam;
                                    ntx.placaNortix = ds_placa;
                                    ntx.nr_chassi = item.Chassi;
                                    ntx.AnoModelo = item.AnoModelo;
                                }
                            }
                            _model.set_PlacaNortix(ntx.AnoModelo, ds_placa, ntx.id_sucateamento, ntx.modelo, ntx.ds_fabricante, ntx.nr_chassi, ntx.nr_renavan, ntx.nr_motor, ntx.AnoModelo, ntx.AnoFabricacao);
                            return 1;
                        }
                        else
                        {
                            _model.set_PlacaNortix(0, ds_placa, 0, "NL", "NL", "NL", "NE", "NL", 0, 0);
                            return 2;
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("getByPlacacentral/{ds_placa}")]
        public IHttpActionResult getByPlacacentral(string ds_placa)
        {
            int retorno = 0;
            int ret = -1;
            bool _validaPlaca = false;
            _placa = ds_placa;
            _validaPlaca = ValidaPlaca(_placa);
            if (_validaPlaca)
            {
                DataTable dt = _model.getPlaca(ds_placa);
                if (dt.Rows.Count > 0)
                {
                    int dias = Convert.ToInt32(dt.Rows[0]["fl_liberaConsulta"].ToString());

                    if (dias == 1)
                    {
                        retorno = consultaPlaca(ds_placa);
                        dt = _model.getPlaca(ds_placa);
                        var Lista = ResultadoCentral(_model.getPlaca(ds_placa));

                        return Ok(Lista[0].id_sucateamento);
                    }
                    else
                    {
                        //dt = _model.getPlaca(ds_placa);
                        var Lista = ResultadoCentral(_model.getPlaca(ds_placa));
                        return Ok(Lista[0].id_sucateamento);
                    }
                }
                else
                {

                    retorno = consultaPlaca(ds_placa);
                    var Lista = ResultadoCentral(_model.getPlaca(ds_placa));
                    return Ok(-1);
                }
            }
            else
            {
                return BadRequest("Placa no formato");
            }

        }


        public List<Models.v_Nortix> Resultado(DataTable dt)
        {

            var convertedList =
                (from rw in dt.AsEnumerable()
                 select new Models.v_Nortix()
                 {
                     id_consulta = rw["id_consulta"].ToString(),
                     id_modelo = rw["id_modelo"].ToString(),
                     nr_ano = rw["nr_ano"].ToString(),
                     ds_placa = rw["ds_placa"].ToString(),
                     vl_fipe = rw["vl_fipe"].ToString(),
                     id_sucateamento = rw["id_sucateamento"].ToString(),
                     fl_nortix = rw["fl_nortix"].ToString(),
                     dt_consulta = rw["dt_consulta"].ToString(),
                     ds_modelo = rw["ds_modelo"].ToString(),
                     ds_fabricante =  rw["ds_fabricante"].ToString(),
                     ds_chassi = rw["ds_chassi"].ToString(),
                     ds_renavan = rw["ds_renavan"].ToString(),
                     nr_motor = rw["nr_motor"].ToString(),
                     nr_anoModelo = rw["nr_anoModelo"].ToString(),
                     nr_anoFabricacao = rw["nr_anoFabricacao"].ToString(),
                     nr_lead = rw["nr_lead"].ToString(),
                     Dias = rw["Dias"].ToString(),
                     fl_liberaConsulta = rw["fl_liberaConsulta"].ToString(),

                 }).ToList();

            return convertedList;
        }
        public List<Models.v_NortixCentral> ResultadoCentral(DataTable dt)
        {

            var convertedList =
                (from rw in dt.AsEnumerable()
                 select new Models.v_NortixCentral()
                 {
                    
                     id_sucateamento = rw["id_sucateamento"].ToString(),
              

                 }).ToList();

            return convertedList;
        }
    }
}