// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.Framework.FileSystemGlobbing
{
    public class PatternMatchingResult
    {
        public PatternMatchingResult(IEnumerable<string> files)
        {
            Files = files;
        }

        public IEnumerable<string> Files { get; set; }
    }
}