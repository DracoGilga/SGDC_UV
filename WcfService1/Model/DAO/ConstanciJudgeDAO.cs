﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Model.DAO
{
    public class ConstanciJudgeDAO
    {
        public static bool CrearConstanciaJudge(Constancia constancia, ConstanciaJurado constanciaJurado)
        {
            try
            {
                constanciaJurado.FK_Id_constancia = ConstanciaDAO.RegistrarConstancia(constancia);
                DataClasses1ConstanciasDataContext DBConexion = GetConexion();
                DBConexion.Constancias.InsertOnSubmit(constancia);
                DBConexion.ConstanciaJurados.InsertOnSubmit(constanciaJurado);
                DBConexion.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static DataClasses1ConstanciasDataContext GetConexion()
        {
            return new DataClasses1ConstanciasDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["DBConstanciasConnectionDracoGilga"].ConnectionString);//cambiar el string de acuerdo a la base de datos
        }
    }
}