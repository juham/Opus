﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opus.Services.UI
{
    /// <summary>
    /// Provides service for linking schemes (identifiers for easy navigation), 
    /// Prism regions and views together.
    /// </summary>
    public interface INavigationAssist
    {
        /// <summary>
        /// Associate schemes with a region and a view.
        /// </summary>
        /// <typeparam name="T">Type of the view</typeparam>
        /// <param name="regionName">Name of the Prism region</param>
        /// <param name="schemeNames">Schemes to associate the region and view with</param>
        public void Add<T>(string regionName, params string[] schemeNames);
    }
}
