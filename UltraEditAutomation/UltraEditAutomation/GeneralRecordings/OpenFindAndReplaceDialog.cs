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

namespace UltraEditAutomation.GeneralRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenFindAndReplaceDialog recording.
    /// </summary>
    [TestModule("52bd87ad-316e-4894-b0bc-2d499a91bfc5", ModuleType.Recording, 1)]
    public partial class OpenFindAndReplaceDialog : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static OpenFindAndReplaceDialog instance = new OpenFindAndReplaceDialog();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenFindAndReplaceDialog()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenFindAndReplaceDialog Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Home'.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.Home.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.FindReplaceInFiles' at Center.", repo.UltraEdit64Bit.FindReplaceInFilesInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.FindReplaceInFiles.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FindAndReplace'.", repo.FindAndReplace.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.FindAndReplace.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Selected='True') on item 'FindAndReplace.FindInFiles'.", repo.FindAndReplace.FindInFilesInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FindAndReplace.FindInFilesInfo, "Selected", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
