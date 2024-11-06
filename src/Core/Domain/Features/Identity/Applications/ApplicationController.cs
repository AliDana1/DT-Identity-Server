using Domain.Features.Identity.Companies;
using Domain.Seedwork;
using Domain.SharedKernel;
using Dtat.Seedwork.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Features.Identity.Applications;

public class ApplicationController : AggregateRoot, IEntityHasIsActive
{
#pragma warning disable CS8618
    private ApplicationController() : base()
    {
    }
#pragma warning restore CS8618

    public ApplicationController(Guid applicationId, Name name, Title title, Path path) : base()
    {
        Name = name;
        Path = path;
        Title = title;
        ApplicationId = applicationId;
    }

    [Required]
    public Guid ApplicationId { get; private set; }

    public virtual Application? Application { get; private set; }

    public Name Name { get; private set; }

    public Title Title { get; private set; }

    public Path Path { get; private set; }

    public bool IsActive { get; private set; }

    public virtual IList<ApplicationAction> ApplicationActions { get; } = [];
}
