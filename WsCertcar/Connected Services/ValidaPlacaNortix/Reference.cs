﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WsCertcar.ValidaPlacaNortix {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://webservices.nortix.com.br/webservices/", ConfigurationName="ValidaPlacaNortix.clsSicVinAgSoap")]
    public interface clsSicVinAgSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservices.nortix.com.br/webservices/InputSicVinAgRst", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WsCertcar.ValidaPlacaNortix.struct_RespostaRst InputSicVinAgRst(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservices.nortix.com.br/webservices/InputSicVinAgRst", ReplyAction="*")]
        System.Threading.Tasks.Task<WsCertcar.ValidaPlacaNortix.struct_RespostaRst> InputSicVinAgRstAsync(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservices.nortix.com.br/webservices/InputSicVinAgDst", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WsCertcar.ValidaPlacaNortix.struct_RespostaDst InputSicVinAgDst(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservices.nortix.com.br/webservices/InputSicVinAgDst", ReplyAction="*")]
        System.Threading.Tasks.Task<WsCertcar.ValidaPlacaNortix.struct_RespostaDst> InputSicVinAgDstAsync(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public partial class struct_RespostaRst : object, System.ComponentModel.INotifyPropertyChanged {
        
        private struct_Identificacao identificacaoField;
        
        private struct_Controle controleField;
        
        private struct_RespostaFormatada respostaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public struct_Identificacao Identificacao {
            get {
                return this.identificacaoField;
            }
            set {
                this.identificacaoField = value;
                this.RaisePropertyChanged("Identificacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public struct_Controle Controle {
            get {
                return this.controleField;
            }
            set {
                this.controleField = value;
                this.RaisePropertyChanged("Controle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public struct_RespostaFormatada Resposta {
            get {
                return this.respostaField;
            }
            set {
                this.respostaField = value;
                this.RaisePropertyChanged("Resposta");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public partial class struct_Identificacao : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nomeDaTransacaoField;
        
        private string descricaoDaTransacaoField;
        
        private string versaoDaTransacaoField;
        
        private System.DateTime dataDaPublicacaoField;
        
        private string autorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NomeDaTransacao {
            get {
                return this.nomeDaTransacaoField;
            }
            set {
                this.nomeDaTransacaoField = value;
                this.RaisePropertyChanged("NomeDaTransacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DescricaoDaTransacao {
            get {
                return this.descricaoDaTransacaoField;
            }
            set {
                this.descricaoDaTransacaoField = value;
                this.RaisePropertyChanged("DescricaoDaTransacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string VersaoDaTransacao {
            get {
                return this.versaoDaTransacaoField;
            }
            set {
                this.versaoDaTransacaoField = value;
                this.RaisePropertyChanged("VersaoDaTransacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime DataDaPublicacao {
            get {
                return this.dataDaPublicacaoField;
            }
            set {
                this.dataDaPublicacaoField = value;
                this.RaisePropertyChanged("DataDaPublicacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Autor {
            get {
                return this.autorField;
            }
            set {
                this.autorField = value;
                this.RaisePropertyChanged("Autor");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public partial class struct_RespostaDst : object, System.ComponentModel.INotifyPropertyChanged {
        
        private struct_Identificacao identificacaoField;
        
        private struct_Controle controleField;
        
        private System.Data.DataSet respostaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public struct_Identificacao Identificacao {
            get {
                return this.identificacaoField;
            }
            set {
                this.identificacaoField = value;
                this.RaisePropertyChanged("Identificacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public struct_Controle Controle {
            get {
                return this.controleField;
            }
            set {
                this.controleField = value;
                this.RaisePropertyChanged("Controle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.Data.DataSet Resposta {
            get {
                return this.respostaField;
            }
            set {
                this.respostaField = value;
                this.RaisePropertyChanged("Resposta");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public partial class struct_Controle : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string clienteField;
        
        private string loginField;
        
        private string placaDeEntradaField;
        
        private string chassiDeEntradaField;
        
        private string iPdoComputadorConsumidorField;
        
        private string nomeDoComputadorProvedorField;
        
        private int codigoDeControleField;
        
        private e_Severidade severidadeField;
        
        private string descricaoField;
        
        private e_Acao acaoAdotadaField;
        
        private e_ResultadoDaPesquisa resultadoDaPesquisaField;
        
        private e_GravacaoDeLog gravacaoDoLogField;
        
        private System.DateTime dataExecucaoField;
        
        private long nrTransacaoField;
        
        private string observacaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
                this.RaisePropertyChanged("Cliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("Login");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PlacaDeEntrada {
            get {
                return this.placaDeEntradaField;
            }
            set {
                this.placaDeEntradaField = value;
                this.RaisePropertyChanged("PlacaDeEntrada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ChassiDeEntrada {
            get {
                return this.chassiDeEntradaField;
            }
            set {
                this.chassiDeEntradaField = value;
                this.RaisePropertyChanged("ChassiDeEntrada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string IPdoComputadorConsumidor {
            get {
                return this.iPdoComputadorConsumidorField;
            }
            set {
                this.iPdoComputadorConsumidorField = value;
                this.RaisePropertyChanged("IPdoComputadorConsumidor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string NomeDoComputadorProvedor {
            get {
                return this.nomeDoComputadorProvedorField;
            }
            set {
                this.nomeDoComputadorProvedorField = value;
                this.RaisePropertyChanged("NomeDoComputadorProvedor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int CodigoDeControle {
            get {
                return this.codigoDeControleField;
            }
            set {
                this.codigoDeControleField = value;
                this.RaisePropertyChanged("CodigoDeControle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public e_Severidade Severidade {
            get {
                return this.severidadeField;
            }
            set {
                this.severidadeField = value;
                this.RaisePropertyChanged("Severidade");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
                this.RaisePropertyChanged("Descricao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public e_Acao AcaoAdotada {
            get {
                return this.acaoAdotadaField;
            }
            set {
                this.acaoAdotadaField = value;
                this.RaisePropertyChanged("AcaoAdotada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public e_ResultadoDaPesquisa ResultadoDaPesquisa {
            get {
                return this.resultadoDaPesquisaField;
            }
            set {
                this.resultadoDaPesquisaField = value;
                this.RaisePropertyChanged("ResultadoDaPesquisa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public e_GravacaoDeLog GravacaoDoLog {
            get {
                return this.gravacaoDoLogField;
            }
            set {
                this.gravacaoDoLogField = value;
                this.RaisePropertyChanged("GravacaoDoLog");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public System.DateTime DataExecucao {
            get {
                return this.dataExecucaoField;
            }
            set {
                this.dataExecucaoField = value;
                this.RaisePropertyChanged("DataExecucao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public long NrTransacao {
            get {
                return this.nrTransacaoField;
            }
            set {
                this.nrTransacaoField = value;
                this.RaisePropertyChanged("NrTransacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Observacao {
            get {
                return this.observacaoField;
            }
            set {
                this.observacaoField = value;
                this.RaisePropertyChanged("Observacao");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public enum e_Severidade {
        
        /// <remarks/>
        e0_NumeradorNaoInicializado,
        
        /// <remarks/>
        e1_MensagemDeInformacaoSimples,
        
        /// <remarks/>
        e2_MensagemDeAdvertencia,
        
        /// <remarks/>
        e3_MensagemDeErro,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public enum e_Acao {
        
        /// <remarks/>
        e0_NumeradorNaoInicializado,
        
        /// <remarks/>
        e1_TrasacaoFoiExecutada,
        
        /// <remarks/>
        e2_TransacaoNaoFoiExecutada,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public enum e_ResultadoDaPesquisa {
        
        /// <remarks/>
        e0_NumeradorNaoInicializado,
        
        /// <remarks/>
        e1_RegistrosForamLocalizados,
        
        /// <remarks/>
        e2_RegistrosNaoForamLocalizados,
        
        /// <remarks/>
        e3_RegistrosNemForamPesquisados,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public enum e_GravacaoDeLog {
        
        /// <remarks/>
        e0_NumeradorNaoInicializado,
        
        /// <remarks/>
        e1_TransacaoFoiLogada,
        
        /// <remarks/>
        e2_TransacaoNaoFoiLogada,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservices.nortix.com.br/webservices/")]
    public partial class struct_RespostaFormatada : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string chassiField;
        
        private string fabricanteField;
        
        private string anoFabricacaoField;
        
        private string anoModeloField;
        
        private string combustivelField;
        
        private string quantidadeDeEixosField;
        
        private string tipoDaCarroceriaField;
        
        private string regiaoGeograficaField;
        
        private string paisField;
        
        private string localDaFabricaField;
        
        private string marcaField;
        
        private string modeloField;
        
        private string veiculoField;
        
        private string versaoField;
        
        private string motorField;
        
        private string tipoDoMotorField;
        
        private string tracaoField;
        
        private string transmissaoField;
        
        private string portasField;
        
        private string classificacaoField;
        
        private string comprimentoField;
        
        private string mesDeProducaoField;
        
        private string pesoBrutoField;
        
        private string tipoDeFreioField;
        
        private string digitoVerificadorField;
        
        private string verificacaoDoSerialField;
        
        private string distanciaEntreEixosField;
        
        private string codigoFipeField;
        
        private string conclusaoField;
        
        private string quantidadeIrregularidadesField;
        
        private string codigoIrregularidadeField;
        
        private string placaField;
        
        private string corField;
        
        private string advertenciaDenatranField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Chassi {
            get {
                return this.chassiField;
            }
            set {
                this.chassiField = value;
                this.RaisePropertyChanged("Chassi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Fabricante {
            get {
                return this.fabricanteField;
            }
            set {
                this.fabricanteField = value;
                this.RaisePropertyChanged("Fabricante");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AnoFabricacao {
            get {
                return this.anoFabricacaoField;
            }
            set {
                this.anoFabricacaoField = value;
                this.RaisePropertyChanged("AnoFabricacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AnoModelo {
            get {
                return this.anoModeloField;
            }
            set {
                this.anoModeloField = value;
                this.RaisePropertyChanged("AnoModelo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Combustivel {
            get {
                return this.combustivelField;
            }
            set {
                this.combustivelField = value;
                this.RaisePropertyChanged("Combustivel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string QuantidadeDeEixos {
            get {
                return this.quantidadeDeEixosField;
            }
            set {
                this.quantidadeDeEixosField = value;
                this.RaisePropertyChanged("QuantidadeDeEixos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string TipoDaCarroceria {
            get {
                return this.tipoDaCarroceriaField;
            }
            set {
                this.tipoDaCarroceriaField = value;
                this.RaisePropertyChanged("TipoDaCarroceria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string RegiaoGeografica {
            get {
                return this.regiaoGeograficaField;
            }
            set {
                this.regiaoGeograficaField = value;
                this.RaisePropertyChanged("RegiaoGeografica");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Pais {
            get {
                return this.paisField;
            }
            set {
                this.paisField = value;
                this.RaisePropertyChanged("Pais");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string LocalDaFabrica {
            get {
                return this.localDaFabricaField;
            }
            set {
                this.localDaFabricaField = value;
                this.RaisePropertyChanged("LocalDaFabrica");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Marca {
            get {
                return this.marcaField;
            }
            set {
                this.marcaField = value;
                this.RaisePropertyChanged("Marca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Modelo {
            get {
                return this.modeloField;
            }
            set {
                this.modeloField = value;
                this.RaisePropertyChanged("Modelo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string Veiculo {
            get {
                return this.veiculoField;
            }
            set {
                this.veiculoField = value;
                this.RaisePropertyChanged("Veiculo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string Versao {
            get {
                return this.versaoField;
            }
            set {
                this.versaoField = value;
                this.RaisePropertyChanged("Versao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Motor {
            get {
                return this.motorField;
            }
            set {
                this.motorField = value;
                this.RaisePropertyChanged("Motor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string TipoDoMotor {
            get {
                return this.tipoDoMotorField;
            }
            set {
                this.tipoDoMotorField = value;
                this.RaisePropertyChanged("TipoDoMotor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string Tracao {
            get {
                return this.tracaoField;
            }
            set {
                this.tracaoField = value;
                this.RaisePropertyChanged("Tracao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string Transmissao {
            get {
                return this.transmissaoField;
            }
            set {
                this.transmissaoField = value;
                this.RaisePropertyChanged("Transmissao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string Portas {
            get {
                return this.portasField;
            }
            set {
                this.portasField = value;
                this.RaisePropertyChanged("Portas");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string Classificacao {
            get {
                return this.classificacaoField;
            }
            set {
                this.classificacaoField = value;
                this.RaisePropertyChanged("Classificacao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string Comprimento {
            get {
                return this.comprimentoField;
            }
            set {
                this.comprimentoField = value;
                this.RaisePropertyChanged("Comprimento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string MesDeProducao {
            get {
                return this.mesDeProducaoField;
            }
            set {
                this.mesDeProducaoField = value;
                this.RaisePropertyChanged("MesDeProducao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string PesoBruto {
            get {
                return this.pesoBrutoField;
            }
            set {
                this.pesoBrutoField = value;
                this.RaisePropertyChanged("PesoBruto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string TipoDeFreio {
            get {
                return this.tipoDeFreioField;
            }
            set {
                this.tipoDeFreioField = value;
                this.RaisePropertyChanged("TipoDeFreio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string DigitoVerificador {
            get {
                return this.digitoVerificadorField;
            }
            set {
                this.digitoVerificadorField = value;
                this.RaisePropertyChanged("DigitoVerificador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string VerificacaoDoSerial {
            get {
                return this.verificacaoDoSerialField;
            }
            set {
                this.verificacaoDoSerialField = value;
                this.RaisePropertyChanged("VerificacaoDoSerial");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string DistanciaEntreEixos {
            get {
                return this.distanciaEntreEixosField;
            }
            set {
                this.distanciaEntreEixosField = value;
                this.RaisePropertyChanged("DistanciaEntreEixos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string CodigoFipe {
            get {
                return this.codigoFipeField;
            }
            set {
                this.codigoFipeField = value;
                this.RaisePropertyChanged("CodigoFipe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public string Conclusao {
            get {
                return this.conclusaoField;
            }
            set {
                this.conclusaoField = value;
                this.RaisePropertyChanged("Conclusao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public string QuantidadeIrregularidades {
            get {
                return this.quantidadeIrregularidadesField;
            }
            set {
                this.quantidadeIrregularidadesField = value;
                this.RaisePropertyChanged("QuantidadeIrregularidades");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public string CodigoIrregularidade {
            get {
                return this.codigoIrregularidadeField;
            }
            set {
                this.codigoIrregularidadeField = value;
                this.RaisePropertyChanged("CodigoIrregularidade");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public string Placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
                this.RaisePropertyChanged("Placa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public string Cor {
            get {
                return this.corField;
            }
            set {
                this.corField = value;
                this.RaisePropertyChanged("Cor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public string AdvertenciaDenatran {
            get {
                return this.advertenciaDenatranField;
            }
            set {
                this.advertenciaDenatranField = value;
                this.RaisePropertyChanged("AdvertenciaDenatran");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface clsSicVinAgSoapChannel : WsCertcar.ValidaPlacaNortix.clsSicVinAgSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class clsSicVinAgSoapClient : System.ServiceModel.ClientBase<WsCertcar.ValidaPlacaNortix.clsSicVinAgSoap>, WsCertcar.ValidaPlacaNortix.clsSicVinAgSoap {
        
        public clsSicVinAgSoapClient() {
        }
        
        public clsSicVinAgSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public clsSicVinAgSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public clsSicVinAgSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public clsSicVinAgSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WsCertcar.ValidaPlacaNortix.struct_RespostaRst InputSicVinAgRst(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi) {
            return base.Channel.InputSicVinAgRst(pstrCliente, pstrLogin, pstrSenha, pstrPlaca, pstrChassi);
        }
        
        public System.Threading.Tasks.Task<WsCertcar.ValidaPlacaNortix.struct_RespostaRst> InputSicVinAgRstAsync(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi) {
            return base.Channel.InputSicVinAgRstAsync(pstrCliente, pstrLogin, pstrSenha, pstrPlaca, pstrChassi);
        }
        
        public WsCertcar.ValidaPlacaNortix.struct_RespostaDst InputSicVinAgDst(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi) {
            return base.Channel.InputSicVinAgDst(pstrCliente, pstrLogin, pstrSenha, pstrPlaca, pstrChassi);
        }
        
        public System.Threading.Tasks.Task<WsCertcar.ValidaPlacaNortix.struct_RespostaDst> InputSicVinAgDstAsync(string pstrCliente, string pstrLogin, string pstrSenha, string pstrPlaca, string pstrChassi) {
            return base.Channel.InputSicVinAgDstAsync(pstrCliente, pstrLogin, pstrSenha, pstrPlaca, pstrChassi);
        }
    }
}
