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
    ///The ShippingPage recording.
    /// </summary>
    [TestModule("f574d14a-f0de-4809-a66a-18a81e4052b6", ModuleType.Recording, 1)]
    public partial class ShippingPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DemoSite_01Repository repository.
        /// </summary>
        public static DemoSite_01Repository repo = DemoSite_01Repository.Instance;

        static ShippingPage instance = new ShippingPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ShippingPage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ShippingPage Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.HeaderCart.Cart' at Center.", repo.MagentoTesting.HeaderCart.CartInfo, new RecordItemIndex(0));
            repo.MagentoTesting.HeaderCart.Cart.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'MagentoTesting.HeaderCart.TopCartBtnCheckout' at Center.", repo.MagentoTesting.HeaderCart.TopCartBtnCheckoutInfo, new RecordItemIndex(2));
            repo.MagentoTesting.HeaderCart.TopCartBtnCheckout.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.HeaderCart.TopCartBtnCheckout' at Center.", repo.MagentoTesting.HeaderCart.TopCartBtnCheckoutInfo, new RecordItemIndex(3));
            repo.MagentoTesting.HeaderCart.TopCartBtnCheckout.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.MinicartItems.ViewDetails' at Center.", repo.MagentoTesting.MinicartItems.ViewDetailsInfo, new RecordItemIndex(4));
            repo.MagentoTesting.MinicartItems.ViewDetails.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='M') on item 'MagentoTesting.MinicartItems.DdTagM'.", repo.MagentoTesting.MinicartItems.DdTagMInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MagentoTesting.MinicartItems.DdTagMInfo, "InnerText", "M");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Green') on item 'MagentoTesting.MinicartItems.Green'.", repo.MagentoTesting.MinicartItems.GreenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MagentoTesting.MinicartItems.GreenInfo, "InnerText", "Green");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.KoUnique1' at Center.", repo.MagentoTesting.KoUnique1Info, new RecordItemIndex(7));
            repo.MagentoTesting.KoUnique1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.ActionButtonContinuePrimary' at Center.", repo.MagentoTesting.ActionButtonContinuePrimaryInfo, new RecordItemIndex(8));
            repo.MagentoTesting.ActionButtonContinuePrimary.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
