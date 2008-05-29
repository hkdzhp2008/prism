//===============================================================================
// Microsoft patterns & practices
// Composite WPF (PRISM)
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================


namespace UIComposition.Modules.Employee
{
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl, IEmployeesView
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        public void SetHeader(IEmployeesListView employeesListView)
        {
            this.HeaderPanel.Content = employeesListView;
        }


        public Prism.Interfaces.IRegionManager RegionManager
        {
            get { return Prism.Regions.RegionManager.GetRegionManager(this); }
        }
    }
}