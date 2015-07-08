using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class PatenteFacade {

		public static List<Entity.Patente> GetAllAdapted(){
			try {
				DAL.Adapters.PatenteCollectionAdapter adapter = new DAL.Adapters.PatenteCollectionAdapter(SelectAll());
				List<Entity.Patente> collection = new List<Entity.Patente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Patente GetAdapted(System.String IdFamiliaElement){
			try {
                DataRow dr = Select(IdFamiliaElement);

				DAL.Adapters.PatenteAdapter adapter = new DAL.Adapters.PatenteAdapter(dr);

                //Instancio un objeto patente
				Entity.Patente _object = new Entity.Patente();

				adapter.Fill(_object);

				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Patente _object){
			try {
				DAL.Patente.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Patente _object){
			try {
				DAL.Patente.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Patente _object){
			try {
				DAL.Patente.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement){
			try {
				return DAL.Patente.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Patente.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
