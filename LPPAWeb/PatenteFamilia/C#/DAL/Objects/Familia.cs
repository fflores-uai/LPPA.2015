using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Familia
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[lenovo]	04/06/2013 01:53:03 a.m.
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Familia
	{
		/// <summary>
		    /// Selecciona todos los registros de la tabla Familia.
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
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_SelectAll");
			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		     }
            
		/// <summary>
		    /// Selecciona un registro desde la tabla Familia.
		    /// </summary>
		    /// <returns>DataSet</returns>
		    /// <remarks>
		    /// </remarks>
		    /// <history>
		    /// 	[lenovo]	04/06/2013 01:53:03 a.m.
		    /// </history>
		    public static DataSet Select(System.String IdFamiliaElement) 
		    {
			    try 
                {
                    Database myDatabase = DatabaseFactory.CreateDatabase();
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Select");
                    myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		    }
            
		/// <summary>
		/// Suprime un registro de la tabla Familia por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Delete(Entity.Familia _object)
		{
			if (_object.Accesos != null)
				DeleteAccesos(_object);

			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Delete");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Familia.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Update(Entity.Familia _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Update");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);

			if (_object.Accesos != null){
				DeleteAccesos(_object);
                Familia_Patente.DeleteAccesos(_object);
				foreach (Entity.FamiliaElement _tipo in _object.Accesos) {
                   if (_tipo.GetType().Name == "Familia")
                   {
                       DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert");
                       myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
                       myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement);
                       myDatabase.ExecuteNonQuery(myCommandAccesos);
                   }
                   else
                   {
                       DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Patente_Insert");
                       myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
                       myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement);
                       myDatabase.ExecuteNonQuery(myCommandAccesos);
                   }

				}
			}
		}

		/// <summary>
		/// Inserta registros en la tabla Familia.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Insert(Entity.Familia _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Insert");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);

			if (_object.Accesos != null){
				DeleteAccesos(_object);
                Familia_Patente.DeleteAccesos(_object);
				foreach (Entity.FamiliaElement _tipo in _object.Accesos) {
                    if (_tipo.GetType().Name == "Familia")
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
                    else
                    {
                        DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Patente_Insert");
                        myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
                        myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement);
                        myDatabase.ExecuteNonQuery(myCommandAccesos);
                    }
				}
			}
		}

		/// <summary>
		/// Selecciona las dependencias de Accesos.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static DataTable GetAccesos(System.String IdFamiliaElement) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Familia_SelectParticular");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

			return myDatabase.ExecuteDataSet(myCommand).Tables[0];
		}

		/// <summary>
		/// Elimina las dependencias de Accesos.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void DeleteAccesos(Entity.Familia _object) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Familia_DeleteParticular");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);

			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
