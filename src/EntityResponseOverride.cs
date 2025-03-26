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
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(EntityResponse));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as EntityResponse)!;

        target.Id = context.Faker.Random.Guid().ToString();
        target.CreatedAt = DateTime.UtcNow;
    }
}