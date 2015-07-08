using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Patente {

		public static List<Entity.Patente> GetAllAdapted(){
			try {
				return DAL.PatenteFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Patente GetAdapted(System.String IdFamiliaElement){
			try {
				return DAL.PatenteFacade.GetAdapted(IdFamiliaElement);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Patente _object){
			try {
				DAL.PatenteFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Patente _object){
			try {
				DAL.PatenteFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Patente _object){
			try {
				DAL.PatenteFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement){
			try {
				return DAL.PatenteFacade.Select(IdFamiliaElement);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.PatenteFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
