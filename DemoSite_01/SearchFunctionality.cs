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
    ///The SearchFunctionality recording.
    /// </summary>
    [TestModule("edc16063-bc76-4b89-bb5d-f280b2230a29", ModuleType.Recording, 1)]
    public partial class SearchFunctionality : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DemoSite_01Repository repository.
        /// </summary>
        public static DemoSite_01Repository repo = DemoSite_01Repository.Instance;

        static SearchFunctionality instance = new SearchFunctionality();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchFunctionality()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchFunctionality Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Didi Sport Watch' with focus on 'MagentoTesting.Search'.", repo.MagentoTesting.SearchInfo, new RecordItemIndex(1));
            repo.MagentoTesting.Search.PressKeys("Didi Sport Watch");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.Search1' at Center.", repo.MagentoTesting.Search1Info, new RecordItemIndex(2));
            repo.MagentoTesting.Search1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'MagentoTesting.Maincontent.ItemProductProductItem' at Center.", repo.MagentoTesting.Maincontent.ItemProductProductItemInfo, new RecordItemIndex(3));
            repo.MagentoTesting.Maincontent.ItemProductProductItem.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\nDidi Sport Watch ') on item 'MagentoTesting.Maincontent.ATagDidiSportWatch'.", repo.MagentoTesting.Maincontent.ATagDidiSportWatchInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MagentoTesting.Maincontent.ATagDidiSportWatchInfo, "InnerText", "\nDidi Sport Watch ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MagentoTesting.Maincontent.ATagDidiSportWatch' at Center.", repo.MagentoTesting.Maincontent.ATagDidiSportWatchInfo, new RecordItemIndex(5));
            repo.MagentoTesting.Maincontent.ATagDidiSportWatch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(6));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}