﻿using System;
using System.Collections.Generic;

namespace MvcSiteMapProvider.Core.SiteMap.Builder
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IXmlSiteMapBuilderFactory
    {
        ISiteMapBuilder Create(
            string xmlSiteMapFilePath,
            IEnumerable<string> attributesToIgnore);
    }
}
