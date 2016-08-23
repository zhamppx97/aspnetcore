﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Rewrite.Internal
{
    public abstract class PreAction
    {
        public abstract void ApplyAction(HttpContext context, MatchResults ruleMatch, MatchResults condMatch);
    }
}
