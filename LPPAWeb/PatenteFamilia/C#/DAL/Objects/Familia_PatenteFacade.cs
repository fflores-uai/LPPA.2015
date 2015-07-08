using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class FamiliaPatenteFacade {

		public static DataRow Select(System.String IdFamiliaElement){
			try {
				return DAL.Familia_Patente.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
