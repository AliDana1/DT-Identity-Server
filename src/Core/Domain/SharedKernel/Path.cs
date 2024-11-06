using Dtat;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.SharedKernel;

[ComplexType]
public record Path : object
{
    public const int MaxLength = 500;

    public Path(string? value)
    {
        SetValue(value);
    }

    [Column(name: nameof(Path))]
    [Required(AllowEmptyStrings = false)]
    public string? Value { get; private set; }

    public void SetValue(string? value)
    {
        value =
            value.Fix();

        if (value is null)
        {
            var errorMessage = string.Format(
                Resources.ValidationErrorMessages.Required,
                Resources.DataDictionary.Name
                );

            throw new Exception(message: errorMessage);
        }

        if (value.Length > MaxLength)
        {
            var errorMessage = string.Format(
                Resources.ValidationErrorMessages.MaxLength,
                Resources.DataDictionary.Name,
                MaxLength
                );

            throw new Exception(message: errorMessage);
        }

        if ((value.StartsWith("/") && value.EndsWith("/")) == false)
        {
            var errorMessage = string.Format(
              Resources.ValidationErrorMessages.PathPattern,
              Resources.DataDictionary.Path
              );

            throw new Exception(message: errorMessage);
        }

        // TODO: Check Regular Expression!

        if (Value != value)
        {
            Value = value;
        }
    }
}
