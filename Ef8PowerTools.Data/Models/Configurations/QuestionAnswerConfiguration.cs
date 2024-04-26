﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Ef8PowerTools.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Ef8PowerTools.Data.Models.Configurations
{
    public partial class QuestionAnswerConfiguration : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.QuestionAnswers");

            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.FlowId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QuestionId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QuestionText).IsUnicode(false);
            entity.Property(e => e.RequestId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<QuestionAnswer> entity);
    }
}