using Domain.Seedwork;
using Domain.SharedKernel;
using Domain.SharedKernel.Enumerations;
using Dtat.Seedwork.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Features.Identity.Applications;

public class ApplicationAction : AggregateRoot, IEntityHasIsActive
{
#pragma warning disable CS8618
    private ApplicationAction() : base()
    {
    }
#pragma warning restore CS8618
    //Name Not Required???
    public ApplicationAction(Guid applicationControllerId, Title title, ActionVerb actionVerb,
        ActionType actionType) : base()
    {
        ApplicationControllerId = applicationControllerId;
        Title = title;
        ActionVerb = actionVerb;
        ActionType = actionType;
    }

    [Required]
    public Guid ApplicationControllerId { get; private set; }

    public virtual ApplicationController? ApplicationController { get; private set; }

    public byte ActionVerbId { get; private set; }

    public virtual ActionVerb ActionVerb { get; private set; }

    public byte ActionTypeId { get; private set; }

    public virtual ActionType ActionType { get; private set; }

    public string? Name { get; private set; }

    public Title Title { get; private set; }
    
    public bool IsActive { get; private set; }
}
