using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class FamiliaFacade {

		public static List<Entity.Familia> GetAllAdapted(){
			try {
				DAL.Adapters.FamiliaCollectionAdapter adapter = new DAL.Adapters.FamiliaCollectionAdapter(SelectAll());
				List<Entity.Familia> collection = new List<Entity.Familia>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Familia GetAdapted(System.String IdFamiliaElement){
			try {
				DAL.Adapters.FamiliaAdapter adapter = new DAL.Adapters.FamiliaAdapter(Select(IdFamiliaElement));
				Entity.Familia _object = new Entity.Familia();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Familia _object){
			try {
				DAL.Familia.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Familia _object){
			try {
				DAL.Familia.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Familia _object){
			try {
				DAL.Familia.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement){
			try {
				return DAL.Familia.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Familia.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void DeleteAccesos(Entity.Familia _object){
			try {
				DAL.Familia.DeleteAccesos(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
