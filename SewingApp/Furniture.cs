//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SewingApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Furniture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furniture()
        {
            this.FurnitureStock = new HashSet<FurnitureStock>();
            this.OrderItem = new HashSet<OrderItem>();
        }

        [DisplayName("�����")]
        public string Id { get; set; }
        [DisplayName("��������")]
        public string Name { get; set; }
        [DisplayName("���")]
        public string Type { get; set; }
        [DisplayName("���������� ����")]
        public Nullable<double> PurchasePrice { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurnitureStock> FurnitureStock { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
