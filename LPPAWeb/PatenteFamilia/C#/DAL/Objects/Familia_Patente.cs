using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : FamiliaElement
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[lenovo]	04/06/2013 01:53:03 a.m.
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Familia_Patente
	{
		/// <summary>
		    /// Selecciona todos los registros de la tabla FamiliaElement.
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
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_SelectAll");
			        return myDatabase.ExecuteDataSet(myCommand);
                }
                catch (Exception ex)
                {                       
                    SL.ExceptionLogging.HandleException(ex);
                    throw;
                }
		     }
            
		/// <summary>
		    /// Selecciona un registro desde la tabla FamiliaElement.
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
			        DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select");
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
		/// Suprime un registro de la tabla FamiliaElement por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Delete(Entity.FamiliaElement _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Delete");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla FamiliaElement.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Update(Entity.FamiliaElement _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Update");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla FamiliaElement.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[lenovo]	04/06/2013 01:53:03 a.m.
		/// </history>
		public static void Insert(Entity.FamiliaElement _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Insert");
			myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.ExecuteNonQuery(myCommand);
		}

        public static DataTable GetAccesos(System.String IdFamiliaElement)
        {
            try
            {
                Database myDatabase = DatabaseFactory.CreateDatabase();
                DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select");
                myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

                return myDatabase.ExecuteDataSet(myCommand).Tables[0];
            }
            catch (Exception ex)
            {
                SL.ExceptionLogging.HandleException(ex);
                throw;
            }
        }

        public static void DeleteAccesos(Entity.Familia _object)
        {
            Database myDatabase = DatabaseFactory.CreateDatabase();
            DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Delete");
            myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);

            myDatabase.ExecuteNonQuery(myCommand);
        }

	}
}
