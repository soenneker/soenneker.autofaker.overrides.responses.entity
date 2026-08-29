using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;
using System;
using Soenneker.Responses.Entity;

namespace Soenneker.AutoFaker.Overrides.Responses.Entity;

/// <summary>
/// An AutoFaker (AutoBogus) override for the EntityResponse object
/// </summary>
public class EntityResponseOverride : AutoFakerOverride<EntityResponse>
{
    /// <summary>
    /// Executes the can override operation.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>A value indicating whether the operation succeeded.</returns>
    public override bool CanOverride(AutoFakerContext context)
    {
        return typeof(EntityResponse).IsAssignableFrom(context.GenerateType);
    }

    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as EntityResponse)!;

        target.Id = context.Faker.Random.Guid().ToString();

        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        target.CreatedAt = utcNow;
        target.ModifiedAt = utcNow;
    }
}
