[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.responses.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.responses.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.responses.entity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.responses.entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.responses.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.responses.entity/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Responses.Entity

An AutoFaker override that creates coherent identity and audit fields for `EntityResponse` fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Responses.Entity
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Responses.Entity;
using Soenneker.Responses.Entity;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new EntityResponseOverride()];

EntityResponse response = autoFaker.Generate<EntityResponse>();
```

The override applies to `EntityResponse` and derived types. It sets `Id` to a GUID string and assigns the same current UTC value to `CreatedAt` and `ModifiedAt`. Adjust `ModifiedAt` afterward when a test needs a distinct update time or `null`.
