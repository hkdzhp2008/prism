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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcceptanceTestLibrary.Common;
using UIComposition.Tests.AcceptanceTest.TestInfrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcceptanceTestLibrary.Common.Desktop;
using UIComposition.Tests.AcceptanceTest.TestEntities.Page;
using AcceptanceTestLibrary.ApplicationHelper;
using System.Windows.Automation;
using System.Drawing;
using System.Threading;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Text;
using AcceptanceTestLibrary.UIAWrapper;

namespace UIComposition.Tests.AcceptanceTest.TestEntities.Assertion
{
    public static class UICompositionAssertion<TApp>
        where TApp : AppLauncherBase, new()
    {
        #region Desktop Assertion
        private static AutomationElementCollection empDetailsTab;
        //
        public static void AssertEmployeeSelection()
        {
            //select first row (employee)

            AutomationElementCollection employeeList = UICompositionPage<WpfAppLauncher>.EmployeesList;
            // UICompositionPage<WpfAppLauncher>.EmployeesList[1].Click();
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeeList[1].Current.BoundingRectangle.X + employeeList[1].Current.BoundingRectangle.X / 4), (int)Math.Floor(employeeList[1].Current.BoundingRectangle.Y + 5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(1000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(7000);
            //validate details view
            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;

           
            Assert.IsNotNull(empDetailsTab, TestDataInfrastructure.GetTestInputData("EmpDetailsTabNotFound"));

            //validate tab has three tab items, and their names are "General", "Location" and "Current Projects"
            Assert.AreEqual(3, empDetailsTab.Count, TestDataInfrastructure.GetTestInputData("EmpDetailsTabPagesCount"));
            Assert.AreEqual(empDetailsTab[0].Current.Name.ToString(), TestDataInfrastructure.GetTestInputData("EmpDetailsTabGeneral"));
            Assert.AreEqual( empDetailsTab[1].Current.Name, TestDataInfrastructure.GetTestInputData("EmpDetailsTabLocation"));
            Assert.AreEqual(empDetailsTab[2].Current.Name, TestDataInfrastructure.GetTestInputData("EmpDetailsTabCurrentProjects"));
                ////TestDataInfrastructure.GetTestInputData("EmpDetailsTabPagesIncorrect"));

            //validate controls in each of the tabs
            ValidateGeneralTabControls();
            ValidateLocationTabControls();
            ValidateCurrentProjectsTabControls();
        }

        public static void AssertEmployeeGeneralData()
        {
            //select employee by name
            AutomationElementCollection employeeList = UICompositionPage<WpfAppLauncher>.EmployeesList;
            // UICompositionPage<WpfAppLauncher>.EmployeesList[1].Click();
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeeList[1].Current.BoundingRectangle.X + employeeList[1].Current.BoundingRectangle.X/4), (int)Math.Floor(employeeList[1].Current.BoundingRectangle.Y+5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(1000);
            MouseEvents.Click();
            //Thread.Sleep(2000);
            //MouseEvents.Click();
            //Thread.Sleep(2000);
            //MouseEvents.Click();
            Thread.Sleep(17000);
            Employee emp = GetEmployeeId();
            ValidateEmployeeDetailsGeneralTabData(emp);
        }

        public static void AssertEmployeeLocationData()
        {
            Thread.Sleep(3000);
            AutomationElementCollection employeeList = UICompositionPage<WpfAppLauncher>.EmployeesList;
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeeList[1].Current.BoundingRectangle.X + employeeList[1].Current.BoundingRectangle.X/4), (int)Math.Floor(employeeList[1].Current.BoundingRectangle.Y+5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(1000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(7000);
            ValidateEmployeeDetailsLocationTabData();
        }

        public static void AssertEmployeeProjectsData()
        {           
            AutomationElementCollection employeeList = UICompositionPage<WpfAppLauncher>.EmployeesList;
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeeList[1].Current.BoundingRectangle.X + employeeList[1].Current.BoundingRectangle.X/4), (int)Math.Floor(employeeList[1].Current.BoundingRectangle.Y+5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(1000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(7000);

            ValidateEmployeeDetailsCurrentProjectsTabData();
        }
        #endregion

        #region SilverLight Assertion
        public static void AssertSilverLightEmployeeSelection()
        {
            AutomationElement employeesListGrid = UICompositionPage<TApp>.EmployeesListGrid;
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeesListGrid.Current.BoundingRectangle.X + 75), (int)Math.Floor(employeesListGrid.Current.BoundingRectangle.Y + 55));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            System.Threading.Thread.Sleep(1000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            Assert.IsNotNull(employeesListGrid, "Could not find employees list grid");
        }

        public static void AssertSilverLightEmployeeGeneralData()
        {
            AutomationElement employeesListGrid = UICompositionPage<TApp>.EmployeesListGrid;           
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeesListGrid.Current.BoundingRectangle.X + 75), (int)Math.Floor(employeesListGrid.Current.BoundingRectangle.Y + 55));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            System.Threading.Thread.Sleep(1000);
            MouseEvents.Click();

            Thread.Sleep(5000);

            AutomationElement firstName = UICompositionPage<TApp>.SilverLightFirstNameTextBox;
            AutomationElement lastName = UICompositionPage<TApp>.SilverLightLastNameTextBox;
            AutomationElement phoneText = UICompositionPage<TApp>.SilverLightPhoneTextBox;
            AutomationElement emailText = UICompositionPage<TApp>.SilverLightEmailTextBox;

            Assert.IsNotNull(firstName, "Could not find first name text box");
            Assert.IsNotNull(lastName, "Could not find last name text box");
            Assert.IsNotNull(phoneText, "Could not find phone text box");
            Assert.IsNotNull(emailText, "Could not find email text box");

            Employee emp = GetEmployeeId2();
            Assert.AreEqual(firstName.Current.Name, emp.FirstName);
            Assert.AreEqual(lastName.Current.Name, emp.LastName);
            Assert.AreEqual(phoneText.Current.Name, emp.Phone);
            Assert.AreEqual(emailText.Current.Name, emp.Email);
        }

        public static void AssertSilverLightEmployeeCurrentProjects()
        {
            AutomationElement employeesListGrid = UICompositionPage<TApp>.EmployeesListGrid;           
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(employeesListGrid.Current.BoundingRectangle.X + 75), (int)Math.Floor(employeesListGrid.Current.BoundingRectangle.Y + 35));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            System.Threading.Thread.Sleep(1000);
            MouseEvents.Click();
            Thread.Sleep(5000);

            AutomationElement employeeTab = UICompositionPage<TApp>.EmployeeDetailsTabControl;           
            System.Windows.Point Point1 = new System.Windows.Point((int)Math.Floor(employeeTab.Current.BoundingRectangle.X + 100), (int)Math.Floor(employeeTab.Current.BoundingRectangle.Y + 10));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point1.X, (int)Point1.Y);
            System.Threading.Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(5000);

            //Check if the current projects grid is loaded.
            AutomationElement currentProjectsGrid = UICompositionPage<TApp>.SilverLightProjectsGrid;
            GridPattern projectPattern = currentProjectsGrid.GetCurrentPattern(GridPattern.Pattern) as GridPattern;
            Assert.AreEqual(TestDataInfrastructure.GetTestInputData("ProjectsRowCount"), projectPattern.Current.RowCount.ToString());
        }
        #endregion

        #region Private Helper methods

        private static void ValidateGeneralTabControls()
        {
            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;            
            System.Windows.Point Point1 = new System.Windows.Point((int)Math.Floor(empDetailsTab[0].Current.BoundingRectangle.X), (int)Math.Floor(empDetailsTab[0].Current.BoundingRectangle.Y + 10));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point1.X, (int)Point1.Y);
            System.Threading.Thread.Sleep(2000);
            MouseEvents.Click();

            //check all Labels (TextBlocks)
            
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.FirstNameLabel);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.LastNameLabel);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.PhoneLabel);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.EmailLabel);

            //check all Textboxes
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.FirstNameTextbox);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.LastNameTextBox);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.PhoneTextBox);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.EmailTextBox);
        }

        private static void ValidateLocationTabControls()
        {
            //Acceptance Tests for UI Composition do not validate the location of the selected Employee
            //in the Live Search Maps displayed in a HTML frame control.This method is the right place
            //to do any assertions for Employee Location displayed in HTML frame control.

            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;          
            System.Windows.Point Point1 = new System.Windows.Point((int)Math.Floor(empDetailsTab[1].Current.BoundingRectangle.X), (int)Math.Floor(empDetailsTab[1].Current.BoundingRectangle.Y + 10));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point1.X, (int)Point1.Y);
            System.Threading.Thread.Sleep(2000);
            MouseEvents.Click();

            
        }

        private static void ValidateCurrentProjectsTabControls()
        {
            //select the "Current Projects" tab
            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;          
            System.Windows.Point Point1 = new System.Windows.Point((int)Math.Floor(empDetailsTab[2].Current.BoundingRectangle.X), (int)Math.Floor(empDetailsTab[2].Current.BoundingRectangle.Y + 10));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point1.X, (int)Point1.Y);
            System.Threading.Thread.Sleep(2000);
            MouseEvents.Click();
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.ProjectsLabel);
            Assert.IsNotNull(UICompositionPage<WpfAppLauncher>.ProjectsList);
        }
        //
        private static void ValidateEmployeeDetailsGeneralTabData(Employee emp)
        {
            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;

            Assert.AreEqual(UICompositionPage<WpfAppLauncher>.FirstNameTextbox.GetValue(), emp.FirstName);
            Assert.AreEqual(UICompositionPage<WpfAppLauncher>.LastNameTextBox.GetValue(), emp.LastName);
            Assert.AreEqual(UICompositionPage<WpfAppLauncher>.PhoneTextBox.GetValue(), emp.Phone);
            Assert.AreEqual(UICompositionPage<WpfAppLauncher>.EmailTextBox.GetValue(), emp.Email);
        }
        //
        private static void ValidateEmployeeDetailsLocationTabData()
        { 
            //Acceptance Tests for UI Composition do not validate the location of the selected Employee
            //in the Live Search Maps displayed in a HTML frame control.This method is the right place
            //to do any assertions for Employee Location displayed in HTML frame control.

           empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;            
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(empDetailsTab[1].Current.BoundingRectangle.X + empDetailsTab[1].Current.BoundingRectangle.X / 4), (int)Math.Floor(empDetailsTab[1].Current.BoundingRectangle.Y+5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);

            
        }

        private static void ValidateEmployeeDetailsCurrentProjectsTabData()
        {
            empDetailsTab = UICompositionPage<WpfAppLauncher>.EmployeeDetailsTab;
            Thread.Sleep(2000);
         
            System.Windows.Point Point = new System.Windows.Point((int)Math.Floor(empDetailsTab[2].Current.BoundingRectangle.X + empDetailsTab[2].Current.BoundingRectangle.X/4), (int)Math.Floor(empDetailsTab[2].Current.BoundingRectangle.Y+5));
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)Point.X, (int)Point.Y);
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);
            MouseEvents.Click();
            Thread.Sleep(2000);

           // ListView projectsList = UICompositionPage<WpfAppLauncher>.ProjectsList;
            AutomationElementCollection projectsList = UICompositionPage<WpfAppLauncher>.ProjectsList;
            ////check if the list has two columns
            //Assert.AreEqual(2, projectsList.Header.Columns.Count);            
            ////check if the list has two rows
            Assert.AreEqual(2, projectsList.Count-1);
        }

        private static Employee GetEmployeeId()
        {
            Employee emp = new Employee(1)
            {
                FirstName = TestDataInfrastructure.GetTestInputData("Emp_1_FirstName"),
                LastName = TestDataInfrastructure.GetTestInputData("Emp_1_LastName"),
                Phone = TestDataInfrastructure.GetTestInputData("Emp_1_Phone"),
                Email = TestDataInfrastructure.GetTestInputData("Emp_1_Email")
            };

            return emp;
        }
        private static Employee GetEmployeeId2()
        {
            Employee emp = new Employee(1)
            {
                FirstName = TestDataInfrastructure.GetTestInputData("Emp_2_FirstName"),
                LastName = TestDataInfrastructure.GetTestInputData("Emp_2_LastName"),
                Phone = TestDataInfrastructure.GetTestInputData("Emp_2_Phone"),
                Email = TestDataInfrastructure.GetTestInputData("Emp_2_Email")
            };

            return emp;
        }

        #endregion

    }
}