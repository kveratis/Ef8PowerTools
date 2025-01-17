﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class OrderProductFormConfiguration : IEntityTypeConfiguration<OrderProductForm>
    {
        public void Configure(EntityTypeBuilder<OrderProductForm> entity)
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("OrderProductForm");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AddressId)
                .HasMaxLength(50)
                .HasColumnName("AddressID");
            entity.Property(e => e.BillToAddress1).HasMaxLength(100);
            entity.Property(e => e.BillToAddress2).HasMaxLength(100);
            entity.Property(e => e.BillToCity).HasMaxLength(100);
            entity.Property(e => e.BillToName).HasMaxLength(50);
            entity.Property(e => e.BillToPracticeName).HasMaxLength(50);
            entity.Property(e => e.BillToState).HasMaxLength(100);
            entity.Property(e => e.BillToZip).HasMaxLength(50);
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Eligibility340b).HasMaxLength(10);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(50);
            entity.Property(e => e.Gpoaffiliation)
                .HasMaxLength(100)
                .HasColumnName("GPOAffiliation");
            entity.Property(e => e.IsUseShipToInfoForBillTo).HasColumnName("isUseShipToInfoForBillTo");
            entity.Property(e => e.LocationType).HasMaxLength(100);
            entity.Property(e => e.OfficeContact).HasMaxLength(100);
            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            entity.Property(e => e.Pdf).HasColumnName("PDF");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhysicianId)
                .HasMaxLength(50)
                .HasColumnName("PhysicianID");
            entity.Property(e => e.PhysicianName).HasMaxLength(100);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.Price10000).HasMaxLength(100);
            entity.Property(e => e.Price2500).HasMaxLength(100);
            entity.Property(e => e.Price5000).HasMaxLength(100);
            entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            entity.Property(e => e.ServiceRequestId).HasColumnName("ServiceRequestID");
            entity.Property(e => e.ShipToAddress1).HasMaxLength(100);
            entity.Property(e => e.ShipToAddress2).HasMaxLength(100);
            entity.Property(e => e.ShipToCity).HasMaxLength(100);
            entity.Property(e => e.ShipToName).HasMaxLength(50);
            entity.Property(e => e.ShipToPracticeName).HasMaxLength(50);
            entity.Property(e => e.ShipToState).HasMaxLength(100);
            entity.Property(e => e.ShipToZip).HasMaxLength(50);
            entity.Property(e => e.ShippingPreference).HasMaxLength(200);
            entity.Property(e => e.StateLicenseNumber).HasMaxLength(100);
            entity.Property(e => e.TaxId)
                .HasMaxLength(100)
                .HasColumnName("TaxID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrderProductForm> entity);
    }
}
