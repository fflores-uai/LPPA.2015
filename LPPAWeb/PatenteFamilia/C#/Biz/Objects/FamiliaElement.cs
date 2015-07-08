using System;
using System.Collections.Generic;

namespace Entity {

    public abstract class FamiliaElement
    {
        public FamiliaElement()
        {
            IdFamiliaElement = Guid.NewGuid().ToString();
        }

        public abstract void Add(FamiliaElement d);

        public abstract void Remove(FamiliaElement d);

        public abstract int ChildrenCount { get; }

        public string Nombre { get; set; }

        public string IdFamiliaElement { get; set; }
        
    }

}
