using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Usuario {

		public static List<Entity.Usuario> GetAllAdapted(){
			try {
				return DAL.UsuarioFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Usuario GetAdapted(System.String IdUsuario){
			try {
				return DAL.UsuarioFacade.GetAdapted(IdUsuario);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Usuario _object){
			try {
				DAL.UsuarioFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Usuario _object){
			try {
				DAL.UsuarioFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Usuario _object){
			try {
				DAL.UsuarioFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdUsuario){
			try {
				return DAL.UsuarioFacade.Select(IdUsuario);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.UsuarioFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

        public static void DeleteFamilias(Entity.Usuario _object)
        {
			try {
				DAL.UsuarioFacade.DeleteFamilias(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

        public static void DeletePatentes(Entity.Usuario _object)
        {
            try
            {
                DAL.UsuarioFacade.DeletePatentes(_object);
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
            }
        }
	}
}
