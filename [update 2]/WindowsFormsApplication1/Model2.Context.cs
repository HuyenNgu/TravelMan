﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WindowsFormsApplication1
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class testEntities : DbContext
{
    public testEntities()
        : base("name=testEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<THONGTINKHACHHANG> THONGTINKHACHHANGs { get; set; }

    public virtual DbSet<ThongTinGiaTien> ThongTinGiaTiens { get; set; }

}

}

