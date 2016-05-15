﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindow.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for LoginView.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Diagnostics.CodeAnalysis;
using Microsoft.Practices.Prism.Mvvm;

namespace $safeprojectname$.Views
{
    /// <summary>
    ///     Interaction logic for LoginView.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class LoginWindow : IView, ILoginWindow
    {
        /// <summary>Initializes a new instance of the <see cref="LoginWindow"/> class.</summary>
        public LoginWindow()
        {
            this.InitializeComponent();
        }
    }
}