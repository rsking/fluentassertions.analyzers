﻿using Microsoft.CodeAnalysis;

namespace FluentAssertions.Analyzers
{
    public abstract class NumericAnalyzer : FluentAssertionsAnalyzer
    {
        protected override bool ShouldAnalyzeVariableType(TypeInfo typeInfo)
        {
            return true;
        }
    }
}
