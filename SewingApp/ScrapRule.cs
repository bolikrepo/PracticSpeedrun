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

    public partial class ScrapRule
    {
        public int Id { get; set; }
        [DisplayName("????????")]
        public string IdMaterial { get; set; }
        [DisplayName("???????")]
        public int IdUnit { get; set; }
        [DisplayName("????????")]
        public int Value { get; set; }

        [Browsable(false)] public virtual Fabric Fabric { get; set; }
    }
}
