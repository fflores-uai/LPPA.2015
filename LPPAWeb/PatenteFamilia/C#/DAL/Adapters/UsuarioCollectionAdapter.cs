using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class UsuarioCollectionAdapter {

		private DataTable datosDT;

		public UsuarioCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Usuario> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Usuario _object = new Entity.Usuario();
				UsuarioAdapter adapter = new UsuarioAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
