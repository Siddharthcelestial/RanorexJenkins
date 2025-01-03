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

namespace UltraEditAutomation.SearchTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyHistoryAfterChangingSettings recording.
    /// </summary>
    [TestModule("564a15cb-08d2-4503-975c-fdcfa624652c", ModuleType.Recording, 1)]
    public partial class VerifyHistoryAfterChangingSettings : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static VerifyHistoryAfterChangingSettings instance = new VerifyHistoryAfterChangingSettings();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyHistoryAfterChangingSettings()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyHistoryAfterChangingSettings Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Home' at 26;8.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.Home.Click("26;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.Find' at 20;55.", repo.FormEdit1UltraEdit64Bit.FindInfo, new RecordItemIndex(1));
            repo.FormEdit1UltraEdit64Bit.Find.Click("20;55");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FindAndReplace'.", repo.FindAndReplace.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.FindAndReplace.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'FindAndReplace.Find'.", repo.FindAndReplace.FindInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FindAndReplace.FindInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            // Find Tab
            Report.Log(ReportLevel.Info, "Section", "Find Tab", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button' at 15;14.", repo.FindAndReplace.Uedit64.ButtonInfo, new RecordItemIndex(5));
            repo.FindAndReplace.Uedit64.Button.Click("15;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(6));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            // ReplaceTab
            Report.Log(ReportLevel.Info, "Section", "ReplaceTab", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Replace' at 20;8.", repo.FindAndReplace.ReplaceInfo, new RecordItemIndex(8));
            repo.FindAndReplace.Replace.Click("20;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button' at 7;16.", repo.FindAndReplace.Uedit64.ButtonInfo, new RecordItemIndex(9));
            repo.FindAndReplace.Uedit64.Button.Click("7;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(10));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button1' at 10;18.", repo.FindAndReplace.Uedit64.Button1Info, new RecordItemIndex(11));
            repo.FindAndReplace.Uedit64.Button1.Click("10;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(12));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            // FindInFiles
            Report.Log(ReportLevel.Info, "Section", "FindInFiles", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.FindInFiles' at 55;8.", repo.FindAndReplace.FindInFilesInfo, new RecordItemIndex(14));
            repo.FindAndReplace.FindInFiles.Click("55;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button' at 19;13.", repo.FindAndReplace.Uedit64.ButtonInfo, new RecordItemIndex(15));
            repo.FindAndReplace.Uedit64.Button.Click("19;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(16));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            // ReplaceInFiles
            Report.Log(ReportLevel.Info, "Section", "ReplaceInFiles", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.ReplaceInFiles' at 66;3.", repo.FindAndReplace.ReplaceInFilesInfo, new RecordItemIndex(18));
            repo.FindAndReplace.ReplaceInFiles.Click("66;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button' at 7;6.", repo.FindAndReplace.Uedit64.ButtonInfo, new RecordItemIndex(19));
            repo.FindAndReplace.Uedit64.Button.Click("7;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(20));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.Button1' at 11;16.", repo.FindAndReplace.Uedit64.Button1Info, new RecordItemIndex(21));
            repo.FindAndReplace.Uedit64.Button1.Click("11;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 100ms to not exist. Associated repository item: 'Uedit64.abcd'", repo.Uedit64.abcdInfo, new ActionTimeout(100), new RecordItemIndex(22));
            repo.Uedit64.abcdInfo.WaitForNotExists(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'FindAndReplace'.", repo.FindAndReplace.SelfInfo, new RecordItemIndex(23));
            repo.FindAndReplace.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
