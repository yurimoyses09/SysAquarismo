//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDeGerenciamentoDePeixes.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USUARIO()
        {
            this.TB_PEIXES = new HashSet<TB_PEIXES>();
        }
    
        public int id_usuario { get; set; }
        public string nm_usuario { get; set; }
        public int vl_idade { get; set; }
        public string ds_telefone { get; set; }
        public string nm_nome_usuario { get; set; }
        public string ds_senha { get; set; }
        public string ds_sexo { get; set; }
        public string ds_Pais { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEIXES> TB_PEIXES { get; set; }
    }
}
