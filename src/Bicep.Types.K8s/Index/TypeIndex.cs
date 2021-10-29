// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System.Collections.Generic;

namespace Azure.Bicep.Types.K8s.Index
{
    public class TypeIndex
    {
        public TypeIndex(IReadOnlyDictionary<string, TypeLocation> types)
        {
            Types = types;
        }

        public IReadOnlyDictionary<string, TypeLocation> Types { get; }
    }
}