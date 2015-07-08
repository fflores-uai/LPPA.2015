using System;
using System.Data;

namespace DAL.Adapters {
	public class PatenteAdapter {

		private DataRow row;

		public PatenteAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Patente _object){
            _object.IdFamiliaElement = (System.String)row["IdPatente"];

			_object.Nombre = (System.String)row["Nombre"];

		}
	}
}
