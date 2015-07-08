using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class FamiliaCollectionAdapter {

		private DataTable datosDT;

		public FamiliaCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Familia> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Familia _object = new Entity.Familia();
				FamiliaAdapter adapter = new FamiliaAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
