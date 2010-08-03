//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
using System;
using MVVM.Infrastructure.ViewModels;

namespace MVVM.ViewModels
{
    public abstract class QuestionViewModel : ViewModel
    {
        protected QuestionViewModel()
        {
        }

        public event EventHandler<EventArgs> ResponseChanged;

        public abstract bool HasChanges { get; }

        public abstract bool ResponseComplete { get; }

        protected void OnResponseChanged()
        {
            var handler = this.ResponseChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}