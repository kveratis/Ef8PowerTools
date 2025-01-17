﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class Rndc14NdcMstrConfiguration : IEntityTypeConfiguration<Rndc14NdcMstr>
    {
        public void Configure(EntityTypeBuilder<Rndc14NdcMstr> entity)
        {
            entity.HasKey(e => e.Ndc);

            entity.ToTable("RNDC14_NDC_MSTR");

            entity.Property(e => e.Ndc)
                .HasMaxLength(11)
                .HasColumnName("NDC");
            entity.Property(e => e.Ad)
                .HasMaxLength(20)
                .HasColumnName("AD");
            entity.Property(e => e.Bbdc).HasColumnName("BBDC");
            entity.Property(e => e.Bn)
                .HasMaxLength(30)
                .HasColumnName("BN");
            entity.Property(e => e.Cl)
                .HasMaxLength(1)
                .HasColumnName("CL");
            entity.Property(e => e.Csp).HasColumnName("CSP");
            entity.Property(e => e.Daddnc).HasColumnName("DADDNC");
            entity.Property(e => e.Dea)
                .HasMaxLength(1)
                .HasColumnName("DEA");
            entity.Property(e => e.Des2dtec).HasColumnName("DES2DTEC");
            entity.Property(e => e.Desdtec).HasColumnName("DESDTEC");
            entity.Property(e => e.Desi)
                .HasMaxLength(1)
                .HasColumnName("DESI");
            entity.Property(e => e.Desi2)
                .HasMaxLength(1)
                .HasColumnName("DESI2");
            entity.Property(e => e.Df)
                .HasMaxLength(1)
                .HasColumnName("DF");
            entity.Property(e => e.Dupdc).HasColumnName("DUPDC");
            entity.Property(e => e.GcnSeqno).HasColumnName("GCN_SEQNO");
            entity.Property(e => e.Gmi)
                .HasMaxLength(1)
                .HasColumnName("GMI");
            entity.Property(e => e.Gni)
                .HasMaxLength(1)
                .HasColumnName("GNI");
            entity.Property(e => e.Gpi)
                .HasMaxLength(1)
                .HasColumnName("GPI");
            entity.Property(e => e.Gpidc).HasColumnName("GPIDC");
            entity.Property(e => e.Gsi)
                .HasMaxLength(1)
                .HasColumnName("GSI");
            entity.Property(e => e.Gti)
                .HasMaxLength(1)
                .HasColumnName("GTI");
            entity.Property(e => e.HcfaAppc).HasColumnName("HCFA_APPC");
            entity.Property(e => e.HcfaDc)
                .HasMaxLength(1)
                .HasColumnName("HCFA_DC");
            entity.Property(e => e.HcfaDesc1).HasColumnName("HCFA_DESC1");
            entity.Property(e => e.HcfaDesi1)
                .HasMaxLength(1)
                .HasColumnName("HCFA_DESI1");
            entity.Property(e => e.HcfaFda)
                .HasMaxLength(2)
                .HasColumnName("HCFA_FDA");
            entity.Property(e => e.HcfaMrkc).HasColumnName("HCFA_MRKC");
            entity.Property(e => e.HcfaPs).HasColumnName("HCFA_PS");
            entity.Property(e => e.HcfaTrmc).HasColumnName("HCFA_TRMC");
            entity.Property(e => e.HcfaTyp)
                .HasMaxLength(1)
                .HasColumnName("HCFA_TYP");
            entity.Property(e => e.HcfaUnit)
                .HasMaxLength(3)
                .HasColumnName("HCFA_UNIT");
            entity.Property(e => e.Home)
                .HasMaxLength(1)
                .HasColumnName("HOME");
            entity.Property(e => e.Hosp)
                .HasMaxLength(1)
                .HasColumnName("HOSP");
            entity.Property(e => e.Innov)
                .HasMaxLength(1)
                .HasColumnName("INNOV");
            entity.Property(e => e.Inpcki)
                .HasMaxLength(1)
                .HasColumnName("INPCKI");
            entity.Property(e => e.Ipi)
                .HasMaxLength(1)
                .HasColumnName("IPI");
            entity.Property(e => e.Lblrid)
                .HasMaxLength(6)
                .HasColumnName("LBLRID");
            entity.Property(e => e.Ln)
                .HasMaxLength(30)
                .HasColumnName("LN");
            entity.Property(e => e.Ln25)
                .HasMaxLength(25)
                .HasColumnName("LN25");
            entity.Property(e => e.Ln25i)
                .HasMaxLength(1)
                .HasColumnName("LN25I");
            entity.Property(e => e.Ln60)
                .HasMaxLength(60)
                .HasColumnName("LN60");
            entity.Property(e => e.Maint)
                .HasMaxLength(1)
                .HasColumnName("MAINT");
            entity.Property(e => e.Mini)
                .HasMaxLength(1)
                .HasColumnName("MINI");
            entity.Property(e => e.Ndcfi)
                .HasMaxLength(1)
                .HasColumnName("NDCFI");
            entity.Property(e => e.Ndcgi1)
                .HasMaxLength(1)
                .HasColumnName("NDCGI1");
            entity.Property(e => e.NdlGdge).HasColumnName("NDL_GDGE");
            entity.Property(e => e.NdlLngth).HasColumnName("NDL_LNGTH");
            entity.Property(e => e.Obc)
                .HasMaxLength(2)
                .HasColumnName("OBC");
            entity.Property(e => e.Obc3)
                .HasMaxLength(3)
                .HasColumnName("OBC3");
            entity.Property(e => e.ObcExp)
                .HasMaxLength(2)
                .HasColumnName("OBC_EXP");
            entity.Property(e => e.Obsdtec).HasColumnName("OBSDTEC");
            entity.Property(e => e.Outpcki)
                .HasMaxLength(1)
                .HasColumnName("OUTPCKI");
            entity.Property(e => e.Pd)
                .HasMaxLength(10)
                .HasColumnName("PD");
            entity.Property(e => e.Plblr)
                .HasMaxLength(1)
                .HasColumnName("PLBLR");
            entity.Property(e => e.Pndc)
                .HasMaxLength(11)
                .HasColumnName("PNDC");
            entity.Property(e => e.Ppi)
                .HasMaxLength(1)
                .HasColumnName("PPI");
            entity.Property(e => e.Ps).HasColumnName("PS");
            entity.Property(e => e.PsEquiv).HasColumnName("PS_EQUIV");
            entity.Property(e => e.Repack)
                .HasMaxLength(1)
                .HasColumnName("REPACK");
            entity.Property(e => e.Repndc)
                .HasMaxLength(11)
                .HasColumnName("REPNDC");
            entity.Property(e => e.Shipper).HasColumnName("SHIPPER");
            entity.Property(e => e.ShlfPck).HasColumnName("SHLF_PCK");
            entity.Property(e => e.Stpk)
                .HasMaxLength(1)
                .HasColumnName("STPK");
            entity.Property(e => e.SyrCpcty).HasColumnName("SYR_CPCTY");
            entity.Property(e => e.Top200)
                .HasMaxLength(3)
                .HasColumnName("TOP200");
            entity.Property(e => e.Top50gen)
                .HasMaxLength(2)
                .HasColumnName("TOP50GEN");
            entity.Property(e => e.Ud)
                .HasMaxLength(1)
                .HasColumnName("UD");
            entity.Property(e => e.Uu)
                .HasMaxLength(1)
                .HasColumnName("UU");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rndc14NdcMstr> entity);
    }
}
