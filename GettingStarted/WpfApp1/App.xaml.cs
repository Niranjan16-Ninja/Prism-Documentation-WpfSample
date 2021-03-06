﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.Register<Services.ICustomerStore, Services.DbCustomerStore>();
		}

		protected override Window CreateShell()
		{
			// explicit view model creation
			var w = Container.Resolve<MainWindow>();

			// or injected
			// var w Container.Resolve<Views.MainWindow>();
			return w;
		}
	}
}
