using System;

namespace Domain.SharedKernel.Enumerations;

/// <summary>
/// Action Verb HTTP Protocol Like POST
/// </summary>
public enum ActionVerbEnum : byte
{
    GET = 0,
    POST = 1,
    PUT = 2,
    DELETE = 3,
}
