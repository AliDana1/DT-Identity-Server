using Domain.Features.Identity.Applications;
using Domain.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Persistence.Configurations.Features.Identity.Applications;

internal sealed class ApplicationControllerConfiguration :
    object, IEntityTypeConfiguration<ApplicationController>
{
    public void Configure(EntityTypeBuilder<ApplicationController> builder)
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
            .Property(current => current.Name)
            .HasConversion(current => current.Value, value => new Name(value))
            ;

        builder
            .Property(current => current.Title)
            .HasConversion(current => current.Value, value => new Title(value))
            ;

        builder
            .Property(current => current.Path)
            .HasConversion(current => current.Value, value => new Path(value))
            ;

        builder
            .HasIndex(current => new { current.ApplicationId, current.Name })
            .IsUnique(unique: true)
            ;


        builder
            .HasMany(current => current.ApplicationActions)
            .WithOne(other => other.ApplicationController)
            .IsRequired(required: true)
            .HasForeignKey(other => other.ApplicationControllerId)
            .OnDelete(deleteBehavior: DeleteBehavior.NoAction)
            ;

    }
}
