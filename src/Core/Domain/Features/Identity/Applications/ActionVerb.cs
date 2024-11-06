using Domain.Seedwork;
using Domain.SharedKernel;
using Domain.SharedKernel.Enumerations;
using Dtat.Seedwork.Abstractions;
using System;


namespace Domain.Features.Identity.Applications;

public class ActionVerb : AggregateRoot, IEntityHasIsActive
{
#pragma warning disable CS8618
    private ActionVerb() : base()
    {
    }
#pragma warning restore CS8618

    public ActionVerb(Name name) : base()
    {
        Name = name;
    }
    public Name Name { get; set; }

    public byte ActionVerbId { get; set; }

    public ActionVerbEnum actionVerbEnum { get; set; }
    public bool IsActive { get; private set; }
}
