using Domain.Seedwork;
using Domain.SharedKernel.Enumerations;
using Domain.SharedKernel;
using Dtat.Seedwork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Features.Identity.Applications
{
    public class ActionType : AggregateRoot, IEntityHasIsActive
    {
#pragma warning disable CS8618
        private ActionType() : base()
        {
        }
#pragma warning restore CS8618

        public ActionType(Name name) : base()
        {
            Name = name;
        }
        public Name Name { get; set; }

        public byte ActionVerbId { get; set; }

        public ActionTypeEnum actionTypeEnum { get; set; }
        public bool IsActive { get; private set; }
    }
}

