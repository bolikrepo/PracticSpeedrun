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

    public partial class OrderItem
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string IdProduct { get; set; }
        public string IdFabric { get; set; }
        public string IdFurniture { get; set; }
        public string IdBorder { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int IdUnitWidth { get; set; }
        public int IdUnitHeight { get; set; }
        public double Price { get; set; }
        public int RotationAngle { get; set; }
        public int Amount { get; set; }
    
        public virtual Fabric Fabric { get; set; }
        public virtual Furniture Furniture { get; set; }
        public virtual Order Order { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual Product Product { get; set; }
    }
}
