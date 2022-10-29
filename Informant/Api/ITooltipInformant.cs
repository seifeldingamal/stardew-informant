﻿using System.Collections.Generic;

namespace Slothsoft.Informant.Api; 

/// <summary>
/// A general informant that allows hooking new providers for a specific type into.
/// </summary>
public interface ITooltipInformant<TInput> {

    /// <summary>
    /// Returns the generators this informant has.
    /// </summary>
    IEnumerable<ITooltipGenerator<TInput>> Generators { get; }

    /// <summary>
    /// Add a generator that provides information for a specific type.
    /// </summary>
    /// <param name="generator">the generator to add.</param>
    void Add(ITooltipGenerator<TInput> generator);
    
    /// <summary>
    /// Removes a generator that provides information for a specific type.
    /// </summary>
    /// <param name="generatorId">the generator's ID to remove.</param>
    void Remove(string generatorId);
}