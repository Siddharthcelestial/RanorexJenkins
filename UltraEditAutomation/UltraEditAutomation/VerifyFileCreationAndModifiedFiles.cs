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

namespace UltraEditAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyFileCreationAndModifiedFiles recording.
    /// </summary>
    [TestModule("4dce27ff-e640-47f3-a591-c4b76a1447d3", ModuleType.Recording, 1)]
    public partial class VerifyFileCreationAndModifiedFiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static VerifyFileCreationAndModifiedFiles instance = new VerifyFileCreationAndModifiedFiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyFileCreationAndModifiedFiles()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyFileCreationAndModifiedFiles Instance
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

            Report.Screenshot(ReportLevel.Info, "User", "newfile.txt is created.", repo.Uedit64.NewfileTxt, false, new RecordItemIndex(0));
            
            // Verified Reloaded files
            Report.Log(ReportLevel.Info, "Section", "Verified Reloaded files", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.StringsTxtAsterisk' at 68;10.", repo.Uedit64.StringsTxtAsteriskInfo, new RecordItemIndex(2));
            repo.Uedit64.StringsTxtAsterisk.Click("68;10");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.Uedit64.StringsTxtAsterisk, false, new RecordItemIndex(3));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.UltraEdit64Bit.editorScreen, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
