//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica2
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int id_producto { get; set; }
        public string producto1 { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public string estado { get; set; }
    
        public virtual categoria categoria { get; set; }
    }
}
