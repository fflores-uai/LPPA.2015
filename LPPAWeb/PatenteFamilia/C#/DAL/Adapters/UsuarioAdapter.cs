using System;
using System.Data;

namespace DAL.Adapters {
	public class UsuarioAdapter {

		private DataRow row;

		public UsuarioAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Usuario _object){
			_object.IdUsuario = (System.String)row["IdUsuario"];

			_object.Nombre = (System.String)row["Nombre"];

			DataTable relacionesFamilia = Usuario.GetFamilias(_object.IdUsuario);
			
            foreach (DataRow rowPermisos in relacionesFamilia.Rows)
            {
                Entity.FamiliaElement Permisos = DAL.FamiliaFacade.GetAdapted((System.String)rowPermisos["IdFamilia"]);
                _object.Permisos.Add(Permisos);
			}

            DataTable relacionesPatente = Usuario.GetPatentes(_object.IdUsuario);

            foreach (DataRow rowPermisos in relacionesPatente.Rows)
            {
                Entity.FamiliaElement Permisos = DAL.PatenteFacade.GetAdapted((System.String)rowPermisos["IdPatente"]);
                _object.Permisos.Add(Permisos);
            }

		}
	}
}
