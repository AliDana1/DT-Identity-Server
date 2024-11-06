using Domain.Features.Identity.Applications;
using Domain.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Persistence.Configurations.Features.Identity.Applications;

internal sealed class ApplicationActionConfiguration :
    object, IEntityTypeConfiguration<ApplicationAction>
{
    public void Configure(EntityTypeBuilder<ApplicationAction> builder)
    {
        // **************************************************
        // **************************************************
        // **************************************************
        builder
            .HasKey(current => current.Id)
            .IsClustered(clustered: false)
            ;
        // **************************************************

        // **************************************************
        builder
            .Property<string>(propertyName: "Name")
            ;

        builder
            .Property(current => current.Title)
            .HasConversion(current => current.Value, value => new Title(value))
            ;

        builder
           .HasIndex(current => new { current.ApplicationControllerId, current.Name })
           .IsUnique(unique: true)
           ;

        builder
            .HasOne(current => current.ActionType)
            .WithMany()
            .HasForeignKey(current => current.ActionTypeId)
           ;
        builder
          .HasOne(current => current.ActionVerb)
          .WithMany()
          .HasForeignKey(current => current.ActionVerbId)
         ;

    }
}
