using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Usuario
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[lenovo]	04/06/2013 01:53:03 a.m.
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Usuario
	{
		/// <summary>
		    /// Selecciona todos los registros de la tabla Usuario.
		    /// </summary>
		    /// <returns>DataSet</returns>
		    /// <remarks>
		    /// </remarks>
		    /// <history>
		    /// 	[lenovo]	04/06/2013 01:53:03 a.m.
		    /// </history>
		    public static DataSet SelectAll()
		    {
                try
                {
			        Database myDatabase = DatabaseFactory.CreateDatabase();
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_SelectAll");
			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {           
                    SL.ExceptionLogging.HandleException(ex);                    
                    throw;
                }
		     }
            
		/// <summary>
		    /// Selecciona un registro desde la tabla Usuario.
		    /// </summary>
		    /// <returns>DataSet</returns>
		    /// <remarks>
		    /// </remarks>
		    /// <history>
		    /// 	[lenovo]	04/06/2013 01:53:03 a.m.
		    /// </history>
		    public static DataSet Select(System.String IdUsuario) 
		    {
			    try 
                {
                    Database myDatabase = DatabaseFactory.CreateDatabase();
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Select");
                    myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario);

			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		    }
            
		/// <summary>
		/// Suprime un registro de la tabla Usuario por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Delete(Entity.Usuario _object)
		{
            if (_object.Permisos != null)
            {
                DeleteFamilias(_object);
                DeletePatentes(_object);
            }

			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Delete");
			myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Usuario.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Update(Entity.Usuario _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Update");
			myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);

			if (_object.Permisos != null){
				DeleteFamilias(_object);
                DeletePatentes(_object);

                foreach (Entity.FamiliaElement _tipo in _object.Permisos)
                {
                    if (_tipo.GetType().Name == "Familia")
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Familia_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
                    else
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Patente_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
                }

			}
		}

		/// <summary>
		/// Inserta registros en la tabla Usuario.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Insert(Entity.Usuario _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Insert");
			myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);

            if (_object.Permisos != null)
            {
                DeleteFamilias(_object);
                DeletePatentes(_object);

                foreach (Entity.FamiliaElement _tipo in _object.Permisos)
                {
                    if (_tipo.GetType().Name == "Familia")
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Familia_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
                    else
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Usuario_Patente_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdUsuario", DbType.String, _object.IdUsuario);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
                }

            }
		}

		/// <summary>
		/// Selecciona las dependencias de Permisos.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static DataTable GetFamilias(System.String IdUsuario) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Familia_SelectParticular");
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario);

			return myDatabase.ExecuteDataSet(myCommand).Tables[0];
		}

		/// <summary>
		/// Elimina las dependencias de Permisos.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void DeleteFamilias(Entity.Usuario _object) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Familia_DeleteParticular");
			myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario);

			myDatabase.ExecuteNonQuery(myCommand);
		}

        /// <summary>
        /// Selecciona las dependencias de Permisos.
        /// </summary>
        /// <returns>DataSet</returns>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
        /// </history>
        public static DataTable GetPatentes(System.String IdUsuario)
        {
            Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Patente_SelectParticular");
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, IdUsuario);

            return myDatabase.ExecuteDataSet(myCommand).Tables[0];
        }

        /// <summary>
        /// Elimina las dependencias de Permisos.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
        /// </history>
        public static void DeletePatentes(Entity.Usuario _object)
        {
            Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Usuario_Patente_DeleteParticular");
            myDatabase.AddInParameter(myCommand, "@IdUsuario", DbType.String, _object.IdUsuario);

            myDatabase.ExecuteNonQuery(myCommand);
        }

	}
}
