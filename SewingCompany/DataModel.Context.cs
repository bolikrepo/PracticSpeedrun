﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SewingCompany
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class user42Entities : DbContext
{
    public user42Entities()
        : base("name=user42Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Fabric> Fabric { get; set; }

    public virtual DbSet<FabricStock> FabricStock { get; set; }

    public virtual DbSet<Furniture> Furniture { get; set; }

    public virtual DbSet<FurnitureStock> FurnitureStock { get; set; }

    public virtual DbSet<Order> Order { get; set; }

    public virtual DbSet<OrderItem> OrderItem { get; set; }

    public virtual DbSet<OrderState> OrderState { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<Role> Role { get; set; }

    public virtual DbSet<ScrapRule> ScrapRule { get; set; }

    public virtual DbSet<Unit> Unit { get; set; }

    public virtual DbSet<UnitConvert> UnitConvert { get; set; }

    public virtual DbSet<User> User { get; set; }

}

}

