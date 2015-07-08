using System;
using System.Collections.Generic;

namespace Entity {
	public class Usuario {
		private System.String _idUsuario;
		private System.String _nombre;
		private List<FamiliaElement> _permisos = new List<FamiliaElement>();

        public Usuario()
        {
            _idUsuario = Guid.NewGuid().ToString();
        }

		public System.String IdUsuario {
			get {
				return _idUsuario;
			}
			set {
				_idUsuario = value;
			}
		}

		public System.String Nombre {
			get {
				return _nombre;
			}
			set {
				_nombre = value;
			}
		}

		public List<FamiliaElement> Permisos {
			get {
				return _permisos;
			}
			set {
				_permisos = value;
			}
		}

	}
}
