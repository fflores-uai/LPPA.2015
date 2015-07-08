using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class UsuarioFacade {
        
		public static List<Entity.Usuario> GetAllAdapted(){
			try {
				DAL.Adapters.UsuarioCollectionAdapter adapter = new DAL.Adapters.UsuarioCollectionAdapter(SelectAll());
				List<Entity.Usuario> collection = new List<Entity.Usuario>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Usuario GetAdapted(System.String IdUsuario){
			try {
				DAL.Adapters.UsuarioAdapter adapter = new DAL.Adapters.UsuarioAdapter(Select(IdUsuario));
				Entity.Usuario _object = new Entity.Usuario();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Usuario _object){
			try {
				DAL.Usuario.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
        /// <summary>
        /// Este metodo lo utilizo....
        /// </summary>
        /// <param name="_object">Este p</param>
		public static void Update(Entity.Usuario _object){
			try {
				DAL.Usuario.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Usuario _object){
			try {
				DAL.Usuario.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.String IdUsuario){
			try {
				return DAL.Usuario.Select(IdUsuario).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Usuario.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

        public static void DeleteFamilias(Entity.Usuario _object)
        {
			try {
				DAL.Usuario.DeleteFamilias(_object);
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
                DAL.Usuario.DeletePatentes(_object);
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
            }
        }
	}
}
