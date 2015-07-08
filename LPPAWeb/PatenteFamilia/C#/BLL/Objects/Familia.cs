using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Familia {
        
		public static List<Entity.Familia> GetAllAdapted(){
			try {
				return DAL.FamiliaFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Familia GetAdapted(System.String IdFamiliaElement){
			try {
				return DAL.FamiliaFacade.GetAdapted(IdFamiliaElement);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Familia _object){
			try {
				DAL.FamiliaFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Familia _object){
			try {
				DAL.FamiliaFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Familia _object){
			try {
				DAL.FamiliaFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement){
			try {
				return DAL.FamiliaFacade.Select(IdFamiliaElement);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.FamiliaFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void DeleteAccesos(Entity.Familia _object){
			try {
				DAL.FamiliaFacade.DeleteAccesos(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
