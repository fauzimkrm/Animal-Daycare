//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daycare
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet_Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet_Types()
        {
            this.Pets = new HashSet<Pets>();
        }
    
        public int pet_type_id { get; set; }
        public string pet_type_name { get; set; }
        public Nullable<long> pet_type_cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pets> Pets { get; set; }
    }
}