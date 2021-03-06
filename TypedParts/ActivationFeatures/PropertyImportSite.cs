﻿// -----------------------------------------------------------------------
// Copyright © Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------

using System.Reflection;

namespace System.Composition.TypedParts.ActivationFeatures
{
    /// <summary>
    /// Represents a part property that is configured as an import.
    /// </summary>
    class PropertyImportSite
    {
        readonly PropertyInfo _pi;

        public PropertyImportSite(PropertyInfo pi)
        {
            _pi = pi;
        }

        public PropertyInfo Property { get { return _pi; } }

        public override string ToString()
        {
            return _pi.Name;
        }
    }
}
