using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Patente
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[lenovo]	04/06/2013 01:53:03 a.m.
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Patente
	{
		/// <summary>
		    /// Selecciona todos los registros de la tabla Patente.
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
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Patente_SelectAll");
			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		     }
            
		/// <summary>
		    /// Selecciona un registro desde la tabla Patente.
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
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Patente_Select");
                    myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, IdFamiliaElement);

			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		    }
            
		/// <summary>
		/// Suprime un registro de la tabla Patente por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Delete(Entity.Patente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Patente_Delete");
            myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Patente.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Update(Entity.Patente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Patente_Update");
            myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla Patente.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Insert(Entity.Patente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Patente_Insert");
			myDatabase.AddInParameter(myCommand, "@IdPatente", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
