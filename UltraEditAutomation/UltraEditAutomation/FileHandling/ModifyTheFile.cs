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
    ///The ModifyTheFile recording.
    /// </summary>
    [TestModule("2bed0fef-c9ef-4068-a575-e58d9050fbc9", ModuleType.Recording, 1)]
    public partial class ModifyTheFile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static ModifyTheFile instance = new ModifyTheFile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyTheFile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ModifyTheFile Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.ToolBar.Edit' at 22;10.", repo.FormCUltraEditFilesUe20241025T06120.ToolBar.EditInfo, new RecordItemIndex(0));
            repo.FormCUltraEditFilesUe20241025T06120.ToolBar.Edit.Click("22;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Select' at 24;51.", repo.FormCUltraEditFilesUe20241025T06120.SelectInfo, new RecordItemIndex(1));
            repo.FormCUltraEditFilesUe20241025T06120.Select.Click("24;51");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.SelectAll' at 38;5.", repo.Uedit64.SelectAllInfo, new RecordItemIndex(2));
            repo.Uedit64.SelectAll.Click("38;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.ToolBar.Home' at 28;13.", repo.UltraEdit64Bit.ToolBar.HomeInfo, new RecordItemIndex(3));
            repo.UltraEdit64Bit.ToolBar.Home.Click("28;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.ToolBar.Copy' at 35;8.", repo.FormCUltraEditFilesUe20241025T06120.ToolBar.CopyInfo, new RecordItemIndex(4));
            repo.FormCUltraEditFilesUe20241025T06120.ToolBar.Copy.Click("35;8");
            Delay.Milliseconds(0);
            
            Storecontent1();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.ToolBar.Edit' at 32;16.", repo.FormCUltraEditFilesUe20241025T06120.ToolBar.EditInfo, new RecordItemIndex(7));
            repo.FormCUltraEditFilesUe20241025T06120.ToolBar.Edit.Click("32;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Duplicate' at 28;39.", repo.FormCUltraEditFilesUe20241025T06120.DuplicateInfo, new RecordItemIndex(8));
            repo.FormCUltraEditFilesUe20241025T06120.Duplicate.Click("28;39");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
