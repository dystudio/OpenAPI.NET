﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.OpenApi.Any
{
    public class OpenApiPassword : OpenApiPrimitive<string>
    {
        public override PrimitiveType PrimitiveType { get; } = PrimitiveType.Password;

        public OpenApiPassword(string value)
            : base(value)
        { }
    }
}
