using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class PatenteCollectionAdapter {

		private DataTable datosDT;

		public PatenteCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Patente> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Patente _object = new Entity.Patente();
				PatenteAdapter adapter = new PatenteAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
