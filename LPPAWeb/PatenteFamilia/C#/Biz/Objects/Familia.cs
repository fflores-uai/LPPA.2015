using System;
using System.Collections.Generic;

namespace Entity
{
    public class Familia : FamiliaElement
    {
        private List<FamiliaElement> _accesos = new List<FamiliaElement>();

        // Constructor
        
        public Familia()
        {

        }

        public override void Add(FamiliaElement d)
        {
            _accesos.Add(d);
        }

        public override void Remove(FamiliaElement d)
        {
            _accesos.Remove(d);
        }

        public List<FamiliaElement> Accesos
        {
            get
            {
                return _accesos;
            }
            set
            {
                _accesos = value;
            }
        }


        public override int ChildrenCount
        {
            get
            {
                return Accesos.Count;
            }
        }
    }
}
