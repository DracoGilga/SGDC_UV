﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConstanciaUnion1", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class ConstanciaUnion1 : object
    {
        
        private ServiceReference1.Constancia constanciaField;
        
        private ServiceReference1.Profesor profesorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia constancia
        {
            get
            {
                return this.constanciaField;
            }
            set
            {
                this.constanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Profesor profesor
        {
            get
            {
                return this.profesorField;
            }
            set
            {
                this.profesorField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Constancia", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class Constancia : object
    {
        
        private ServiceReference1.ConstanciaImparticion[] ConstanciaImparticionsField;
        
        private ServiceReference1.ConstanciaJurado[] ConstanciaJuradosField;
        
        private ServiceReference1.ConstanciaPLADEA[] ConstanciaPLADEAsField;
        
        private ServiceReference1.ConstanciaProyecto[] ConstanciaProyectosField;
        
        private int FK_Id_FirmaField;
        
        private int FK_id_ProfesorField;
        
        private ServiceReference1.FirmaElectronica FirmaElectronicaField;
        
        private int Id_ConstanciaField;
        
        private ServiceReference1.Profesor ProfesorField;
        
        private System.DateTime fechaCreacionConstanciaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ConstanciaImparticion[] ConstanciaImparticions
        {
            get
            {
                return this.ConstanciaImparticionsField;
            }
            set
            {
                this.ConstanciaImparticionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ConstanciaJurado[] ConstanciaJurados
        {
            get
            {
                return this.ConstanciaJuradosField;
            }
            set
            {
                this.ConstanciaJuradosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ConstanciaPLADEA[] ConstanciaPLADEAs
        {
            get
            {
                return this.ConstanciaPLADEAsField;
            }
            set
            {
                this.ConstanciaPLADEAsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ConstanciaProyecto[] ConstanciaProyectos
        {
            get
            {
                return this.ConstanciaProyectosField;
            }
            set
            {
                this.ConstanciaProyectosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_Id_Firma
        {
            get
            {
                return this.FK_Id_FirmaField;
            }
            set
            {
                this.FK_Id_FirmaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_id_Profesor
        {
            get
            {
                return this.FK_id_ProfesorField;
            }
            set
            {
                this.FK_id_ProfesorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.FirmaElectronica FirmaElectronica
        {
            get
            {
                return this.FirmaElectronicaField;
            }
            set
            {
                this.FirmaElectronicaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Constancia
        {
            get
            {
                return this.Id_ConstanciaField;
            }
            set
            {
                this.Id_ConstanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Profesor Profesor
        {
            get
            {
                return this.ProfesorField;
            }
            set
            {
                this.ProfesorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaCreacionConstancia
        {
            get
            {
                return this.fechaCreacionConstanciaField;
            }
            set
            {
                this.fechaCreacionConstanciaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Profesor", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class Profesor : object
    {
        
        private ServiceReference1.Constancia[] ConstanciasField;
        
        private int Id_profesorField;
        
        private string nombreCompletoField;
        
        private string numeroPersonalField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia[] Constancias
        {
            get
            {
                return this.ConstanciasField;
            }
            set
            {
                this.ConstanciasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_profesor
        {
            get
            {
                return this.Id_profesorField;
            }
            set
            {
                this.Id_profesorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreCompleto
        {
            get
            {
                return this.nombreCompletoField;
            }
            set
            {
                this.nombreCompletoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numeroPersonal
        {
            get
            {
                return this.numeroPersonalField;
            }
            set
            {
                this.numeroPersonalField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FirmaElectronica", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class FirmaElectronica : object
    {
        
        private ServiceReference1.Constancia[] ConstanciasField;
        
        private int Id_firmaField;
        
        private string claveField;
        
        private System.DateTime fechaCreacionField;
        
        private System.DateTime fechaExpiracionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia[] Constancias
        {
            get
            {
                return this.ConstanciasField;
            }
            set
            {
                this.ConstanciasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_firma
        {
            get
            {
                return this.Id_firmaField;
            }
            set
            {
                this.Id_firmaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string clave
        {
            get
            {
                return this.claveField;
            }
            set
            {
                this.claveField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaCreacion
        {
            get
            {
                return this.fechaCreacionField;
            }
            set
            {
                this.fechaCreacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaExpiracion
        {
            get
            {
                return this.fechaExpiracionField;
            }
            set
            {
                this.fechaExpiracionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConstanciaImparticion", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class ConstanciaImparticion : object
    {
        
        private ServiceReference1.Constancia ConstanciaField;
        
        private int FK_Id_constanciaField;
        
        private int Id_constanciaImparticionField;
        
        private string bloqueField;
        
        private string creditoField;
        
        private string esperienciaEducativaField;
        
        private System.TimeSpan horaField;
        
        private System.DateTime mesField;
        
        private string prograamaEducativoField;
        
        private string seccionField;
        
        private string semanaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia Constancia
        {
            get
            {
                return this.ConstanciaField;
            }
            set
            {
                this.ConstanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_Id_constancia
        {
            get
            {
                return this.FK_Id_constanciaField;
            }
            set
            {
                this.FK_Id_constanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_constanciaImparticion
        {
            get
            {
                return this.Id_constanciaImparticionField;
            }
            set
            {
                this.Id_constanciaImparticionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bloque
        {
            get
            {
                return this.bloqueField;
            }
            set
            {
                this.bloqueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string credito
        {
            get
            {
                return this.creditoField;
            }
            set
            {
                this.creditoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string esperienciaEducativa
        {
            get
            {
                return this.esperienciaEducativaField;
            }
            set
            {
                this.esperienciaEducativaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan hora
        {
            get
            {
                return this.horaField;
            }
            set
            {
                this.horaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime mes
        {
            get
            {
                return this.mesField;
            }
            set
            {
                this.mesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prograamaEducativo
        {
            get
            {
                return this.prograamaEducativoField;
            }
            set
            {
                this.prograamaEducativoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string seccion
        {
            get
            {
                return this.seccionField;
            }
            set
            {
                this.seccionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string semana
        {
            get
            {
                return this.semanaField;
            }
            set
            {
                this.semanaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConstanciaJurado", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class ConstanciaJurado : object
    {
        
        private string CargoField;
        
        private ServiceReference1.Constancia ConstanciaField;
        
        private int FK_Id_constanciaField;
        
        private int Id_constanciaJuradoField;
        
        private string LicenciaturaField;
        
        private System.DateTime fechaPresentacionField;
        
        private string modalidadField;
        
        private string nombreAlumnoField;
        
        private string nombreProyectoField;
        
        private string resultadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cargo
        {
            get
            {
                return this.CargoField;
            }
            set
            {
                this.CargoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia Constancia
        {
            get
            {
                return this.ConstanciaField;
            }
            set
            {
                this.ConstanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_Id_constancia
        {
            get
            {
                return this.FK_Id_constanciaField;
            }
            set
            {
                this.FK_Id_constanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_constanciaJurado
        {
            get
            {
                return this.Id_constanciaJuradoField;
            }
            set
            {
                this.Id_constanciaJuradoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Licenciatura
        {
            get
            {
                return this.LicenciaturaField;
            }
            set
            {
                this.LicenciaturaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaPresentacion
        {
            get
            {
                return this.fechaPresentacionField;
            }
            set
            {
                this.fechaPresentacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string modalidad
        {
            get
            {
                return this.modalidadField;
            }
            set
            {
                this.modalidadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreAlumno
        {
            get
            {
                return this.nombreAlumnoField;
            }
            set
            {
                this.nombreAlumnoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreProyecto
        {
            get
            {
                return this.nombreProyectoField;
            }
            set
            {
                this.nombreProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string resultado
        {
            get
            {
                return this.resultadoField;
            }
            set
            {
                this.resultadoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConstanciaPLADEA", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class ConstanciaPLADEA : object
    {
        
        private ServiceReference1.Constancia ConstanciaField;
        
        private int FK_Id_constanciaField;
        
        private int Id_constanciaPLADEAField;
        
        private string accionesField;
        
        private string ejeEstrategicoField;
        
        private string metasField;
        
        private string objetivosGeneralesField;
        
        private string programaEstrategicoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia Constancia
        {
            get
            {
                return this.ConstanciaField;
            }
            set
            {
                this.ConstanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_Id_constancia
        {
            get
            {
                return this.FK_Id_constanciaField;
            }
            set
            {
                this.FK_Id_constanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_constanciaPLADEA
        {
            get
            {
                return this.Id_constanciaPLADEAField;
            }
            set
            {
                this.Id_constanciaPLADEAField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string acciones
        {
            get
            {
                return this.accionesField;
            }
            set
            {
                this.accionesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ejeEstrategico
        {
            get
            {
                return this.ejeEstrategicoField;
            }
            set
            {
                this.ejeEstrategicoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string metas
        {
            get
            {
                return this.metasField;
            }
            set
            {
                this.metasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string objetivosGenerales
        {
            get
            {
                return this.objetivosGeneralesField;
            }
            set
            {
                this.objetivosGeneralesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string programaEstrategico
        {
            get
            {
                return this.programaEstrategicoField;
            }
            set
            {
                this.programaEstrategicoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConstanciaProyecto", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class ConstanciaProyecto : object
    {
        
        private ServiceReference1.Constancia ConstanciaField;
        
        private int FK_Id_constanciaField;
        
        private int Id_constanciaProyectoField;
        
        private string duracionField;
        
        private string impactoObtenidoField;
        
        private string lugarDesarrolloField;
        
        private string nombreAlumnoField;
        
        private string proyectoRealizadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Constancia Constancia
        {
            get
            {
                return this.ConstanciaField;
            }
            set
            {
                this.ConstanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FK_Id_constancia
        {
            get
            {
                return this.FK_Id_constanciaField;
            }
            set
            {
                this.FK_Id_constanciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_constanciaProyecto
        {
            get
            {
                return this.Id_constanciaProyectoField;
            }
            set
            {
                this.Id_constanciaProyectoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string duracion
        {
            get
            {
                return this.duracionField;
            }
            set
            {
                this.duracionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string impactoObtenido
        {
            get
            {
                return this.impactoObtenidoField;
            }
            set
            {
                this.impactoObtenidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lugarDesarrollo
        {
            get
            {
                return this.lugarDesarrolloField;
            }
            set
            {
                this.lugarDesarrolloField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreAlumno
        {
            get
            {
                return this.nombreAlumnoField;
            }
            set
            {
                this.nombreAlumnoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string proyectoRealizado
        {
            get
            {
                return this.proyectoRealizadoField;
            }
            set
            {
                this.proyectoRealizadoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonalAdministrativo", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Model")]
    public partial class PersonalAdministrativo : object
    {
        
        private int Id_personalAdministrativoField;
        
        private string nombreCompletoField;
        
        private string passwordField;
        
        private string usuarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_personalAdministrativo
        {
            get
            {
                return this.Id_personalAdministrativoField;
            }
            set
            {
                this.Id_personalAdministrativoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreCompleto
        {
            get
            {
                return this.nombreCompletoField;
            }
            set
            {
                this.nombreCompletoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarConstancia", ReplyAction="http://tempuri.org/IService1/ListarConstanciaResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ConstanciaUnion1[]> ListarConstanciaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<ServiceReference1.PersonalAdministrativo> LoginAsync(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModificarProfesor", ReplyAction="http://tempuri.org/IService1/ModificarProfesorResponse")]
        System.Threading.Tasks.Task<bool> ModificarProfesorAsync(ServiceReference1.Profesor profesor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerNumerosPersonales", ReplyAction="http://tempuri.org/IService1/ObtenerNumerosPersonalesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Profesor[]> ObtenerNumerosPersonalesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login2", ReplyAction="http://tempuri.org/IService1/login2Response")]
        System.Threading.Tasks.Task<bool> login2Async(ServiceReference1.PersonalAdministrativo personalAdministrativo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AgregarProfesor", ReplyAction="http://tempuri.org/IService1/AgregarProfesorResponse")]
        System.Threading.Tasks.Task<bool> AgregarProfesorAsync(ServiceReference1.Profesor profesor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ConstanciaUnion1[]> ListarConstanciaAsync()
        {
            return base.Channel.ListarConstanciaAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.PersonalAdministrativo> LoginAsync(string usuario, string password)
        {
            return base.Channel.LoginAsync(usuario, password);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarProfesorAsync(ServiceReference1.Profesor profesor)
        {
            return base.Channel.ModificarProfesorAsync(profesor);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Profesor[]> ObtenerNumerosPersonalesAsync()
        {
            return base.Channel.ObtenerNumerosPersonalesAsync();
        }
        
        public System.Threading.Tasks.Task<bool> login2Async(ServiceReference1.PersonalAdministrativo personalAdministrativo)
        {
            return base.Channel.login2Async(personalAdministrativo);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarProfesorAsync(ServiceReference1.Profesor profesor)
        {
            return base.Channel.AgregarProfesorAsync(profesor);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:63828/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
