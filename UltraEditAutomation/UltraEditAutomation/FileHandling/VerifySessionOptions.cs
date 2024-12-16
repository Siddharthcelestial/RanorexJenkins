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

namespace UltraEditAutomation.FileHandling
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifySessionOptions recording.
    /// </summary>
    [TestModule("3db627bd-46a4-4294-b830-0cb100ef1ef6", ModuleType.Recording, 1)]
    public partial class VerifySessionOptions : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static VerifySessionOptions instance = new VerifySessionOptions();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifySessionOptions()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifySessionOptions Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Advanced'.", repo.UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Settings' at 8;51.", repo.UltraEdit64Bit.SettingsInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.Settings.Click("8;51");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.FileHandling' at 59;3.", repo.Configuration.FileHandlingInfo, new RecordItemIndex(2));
            repo.Configuration.FileHandling.Click("59;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.SessionOptions' at 57;10.", repo.Configuration.SessionOptionsInfo, new RecordItemIndex(3));
            repo.Configuration.SessionOptions.Click("57;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.ReloadFilesPreviouslyOpenOnStartup'.", repo.Configuration.ReloadFilesPreviouslyOpenOnStartupInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Configuration.ReloadFilesPreviouslyOpenOnStartupInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.ToSavedFiles'.", repo.Configuration.ToSavedFilesInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Configuration.ToSavedFilesInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.ToUnsavedEditFiles'.", repo.Configuration.ToUnsavedEditFilesInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.Configuration.ToUnsavedEditFilesInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.ReloadFTPFilesWhenReloadingAProjec'.", repo.Configuration.ReloadFTPFilesWhenReloadingAProjecInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Configuration.ReloadFTPFilesWhenReloadingAProjecInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.RememberAndReloadUnsavedChangesToF'.", repo.Configuration.RememberAndReloadUnsavedChangesToFInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.Configuration.RememberAndReloadUnsavedChangesToFInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.OpenFromExplorerAlsoLoadsFileList'.", repo.Configuration.OpenFromExplorerAlsoLoadsFileListInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.Configuration.OpenFromExplorerAlsoLoadsFileListInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'Configuration.DiscardUnsavedEditFilesWithNoPromp'.", repo.Configuration.DiscardUnsavedEditFilesWithNoPrompInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.Configuration.DiscardUnsavedEditFilesWithNoPrompInfo, "Checked", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'Configuration'.", repo.Configuration.SelfInfo, new RecordItemIndex(11));
            repo.Configuration.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}