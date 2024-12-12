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
    ///The ASCIItoEBCDICConversion recording.
    /// </summary>
    [TestModule("098dd6ea-7519-49d0-8eb4-233ff75f85b3", ModuleType.Recording, 1)]
    public partial class ASCIItoEBCDICConversion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static ASCIItoEBCDICConversion instance = new ASCIItoEBCDICConversion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ASCIItoEBCDICConversion()
        {
            File = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ASCIItoEBCDICConversion Instance
        {
            get { return instance; }
        }

#region Variables

        string _File;

        /// <summary>
        /// Gets or sets the value of variable File.
        /// </summary>
        [TestVariable("228fd9f8-45e1-4031-841e-9fa893a889c1")]
        public string File
        {
            get { return _File; }
            set { _File = value; }
        }

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.ToolBar.Advanced'.", repo.UltraEdit64Bit.ToolBar.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.ToolBar.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Conversions' at 90;9.", repo.FormCUltraEditFilesUe20241025T06120.ConversionsInfo, new RecordItemIndex(1));
            repo.FormCUltraEditFilesUe20241025T06120.Conversions.Click("90;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ASCIIToEBCDIC' at 83;12.", repo.Uedit64.ASCIIToEBCDICInfo, new RecordItemIndex(2));
            repo.Uedit64.ASCIIToEBCDIC.Click("83;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='langFile_ASCII_DOS.txt*') on item 'FormCUltraEditFilesUe20241025T06120.LangFileASCIIDOSTxtAsterisk'.", repo.FormCUltraEditFilesUe20241025T06120.LangFileASCIIDOSTxtAsteriskInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FormCUltraEditFilesUe20241025T06120.LangFileASCIIDOSTxtAsteriskInfo, "Title", "langFile_ASCII_DOS.txt*");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "File is changed", repo.FormCUltraEditFilesUe20241025T06120.LangFileASCIIDOSTxtAsterisk, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ApplicationMenu' at 29;12.", repo.Uedit64.ApplicationMenuInfo, new RecordItemIndex(5));
            repo.Uedit64.ApplicationMenu.Click("29;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.SaveAs' at Center.", repo.Uedit64.SaveAsInfo, new RecordItemIndex(6));
            repo.Uedit64.SaveAs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$File' with focus on 'SaveAs.Text1001'.", repo.SaveAs.Text1001Info, new RecordItemIndex(7));
            repo.SaveAs.Text1001.PressKeys(File);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.ButtonSave' at 22;17.", repo.SaveAs.ButtonSaveInfo, new RecordItemIndex(8));
            repo.SaveAs.ButtonSave.Click("22;17");
            Delay.Milliseconds(0);
            
            CheckAndClickYesButton(repo.Uedit64.ButtonYesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1047  (IBM EBCDIC - Latin-1/Open System)') on item 'FormCUltraEditFilesUe20241025T06120.Text1047IBMEBCDICLatin1OpenSys'.", repo.FormCUltraEditFilesUe20241025T06120.Text1047IBMEBCDICLatin1OpenSysInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FormCUltraEditFilesUe20241025T06120.Text1047IBMEBCDICLatin1OpenSysInfo, "Text", "1047  (IBM EBCDIC - Latin-1/Open System)");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.FormCUltraEditFilesUe20241025T06120.Text1047IBMEBCDICLatin1OpenSys, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}