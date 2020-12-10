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
    
    public partial class Daycares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Daycares()
        {
            this.Pickups = new HashSet<Pickups>();
        }
    
        public int daycare_id { get; set; }
        public Nullable<int> pet_id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<System.DateTime> daycare_date { get; set; }
        public Nullable<System.DateTime> daycare_pickup_date { get; set; }
        public Nullable<long> daycare_cost { get; set; }
        public Nullable<int> dayare_status { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Pets Pets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pickups> Pickups { get; set; }
    }
}
