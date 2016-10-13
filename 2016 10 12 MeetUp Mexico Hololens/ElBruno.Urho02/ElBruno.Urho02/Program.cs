﻿using System;
using Windows.ApplicationModel.Core;
using Urho.HoloLens;

namespace ElBruno.Urho02
{
    /// <summary>
    /// Windows Holographic application using SharpDX.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [MTAThread]
        private static void Main()
        {
            var exclusiveViewApplicationSource = new AppViewSource();
            CoreApplication.Run(exclusiveViewApplicationSource);
        }
	}

	// The entry point for the app.
	internal class AppViewSource : IFrameworkViewSource
	{
		public IFrameworkView CreateView()
		{
			return UrhoAppView.Create<PositionTextSample>(null); // null means only CoreData
		}
	}
}