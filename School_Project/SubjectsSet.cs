//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubjectsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectsSet()
        {
            this.MarksSet = new HashSet<MarksSet>();
        }
    
        public int ID { get; set; }
        public string Subject { get; set; }
        public int id_Teacher { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarksSet> MarksSet { get; set; }
        public virtual TeachersSet TeachersSet { get; set; }
    }
}