﻿using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using HelpToHelp.Business.ActionFilters;
using System.Web.Mvc;

namespace HelpToHelp.Business.Initializers
{
    [InitializableModule]
    public class FilterConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            GlobalFilters.Filters.Add(ServiceLocator.Current.GetInstance<PageContentActionFilters>());
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}