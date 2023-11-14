﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DemoSite_01
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateCreateNewAccount recording.
    /// </summary>
    [TestModule("bedc9a1e-2846-4129-b3b1-a343a1ffe1d6", ModuleType.Recording, 1)]
    public partial class ValidateCreateNewAccount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DemoSite_01Repository repository.
        /// </summary>
        public static DemoSite_01Repository repo = DemoSite_01Repository.Instance;

        static ValidateCreateNewAccount instance = new ValidateCreateNewAccount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCreateNewAccount()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateCreateNewAccount Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.HeaderLinks.CreateAnAccount' at 44;7.", repo.MagentoTesting.HeaderLinks.CreateAnAccountInfo, new RecordItemIndex(0));
            repo.MagentoTesting.HeaderLinks.CreateAnAccount.Click("44;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Create New Customer Account') on item 'MagentoTesting.AccountRegistration.CreateNewCustomerAccount'.", repo.MagentoTesting.AccountRegistration.CreateNewCustomerAccountInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MagentoTesting.AccountRegistration.CreateNewCustomerAccountInfo, "InnerText", "Create New Customer Account");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
