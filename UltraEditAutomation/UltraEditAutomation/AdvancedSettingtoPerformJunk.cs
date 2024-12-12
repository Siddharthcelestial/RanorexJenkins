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
    ///The AdvancedSettingtoPerformJunk recording.
    /// </summary>
    [TestModule("aecca4da-b82f-4f69-a825-8960a7f38b1b", ModuleType.Recording, 1)]
    public partial class AdvancedSettingtoPerformJunk : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static AdvancedSettingtoPerformJunk instance = new AdvancedSettingtoPerformJunk();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdvancedSettingtoPerformJunk()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AdvancedSettingtoPerformJunk Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.Advanced' at 44;13.", repo.FormEdit1UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(0));
            repo.FormEdit1UltraEdit64Bit.Advanced.Click("44;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.Settings' at 16;50.", repo.FormEdit1UltraEdit64Bit.SettingsInfo, new RecordItemIndex(1));
            repo.FormEdit1UltraEdit64Bit.Settings.Click("16;50");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.XMLHTMLMarkdown' at 74;8.", repo.Configuration.XMLHTMLMarkdownInfo, new RecordItemIndex(2));
            repo.Configuration.XMLHTMLMarkdown.Click("74;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.AutomaticallyCloseXMLHTMLTags'.", repo.Configuration.AutomaticallyCloseXMLHTMLTagsInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Configuration.AutomaticallyCloseXMLHTMLTagsInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Close' at 19;23.", repo.Configuration.CloseInfo, new RecordItemIndex(4));
            repo.Configuration.Close.Click("19;23");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
