using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace GolfWeb.Common
{
    public abstract class GolfWebViewPage<T> : WebViewPage<T>
    {
        /// <summary>
        /// page title
        /// </summary>
        public virtual string PageTitle
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultPageTitle"];
            }
        }

        /// <summary>
        /// Gets the page keywords.
        /// </summary>
        public string PageKeywords
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultKeywords"];
            }
        }

        /// <summary>
        /// Gets the page description.
        /// </summary>
        public string PageDescription
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultDescription"];
            }
        }
    }
}