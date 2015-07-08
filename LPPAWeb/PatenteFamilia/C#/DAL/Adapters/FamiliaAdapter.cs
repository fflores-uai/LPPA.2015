using System;
using System.Data;

namespace DAL.Adapters {
	public class FamiliaAdapter {

		private DataRow row;

		public FamiliaAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Familia _object){
			_object.IdFamiliaElement = (System.String)row["IdFamilia"];

			_object.Nombre = (System.String)row["Nombre"];

            //Traigo accesos de familia
			DataTable relacionesFamilia = Familia.GetAccesos(_object.IdFamiliaElement);
			            
			foreach (DataRow rowAccesos in relacionesFamilia.Rows) {
                _object.Add(DAL.FamiliaFacade.GetAdapted((System.String)rowAccesos["IdFamiliaHijo"]));
			}

            //Traigo accesos de patentes
            DataTable relacionesPatentes = Familia_Patente.GetAccesos(_object.IdFamiliaElement);
			            
			foreach (DataRow rowAccesos in relacionesPatentes.Rows) {                
				_object.Add(DAL.PatenteFacade.GetAdapted((System.String)rowAccesos["IdPatente"]));
			}

		}
	}
}
