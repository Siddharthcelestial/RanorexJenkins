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
    ///The ValidateUnixRegularExpressionCount recording.
    /// </summary>
    [TestModule("e8b28476-17e8-42c5-b71f-b93aba1c4d3a", ModuleType.Recording, 1)]
    public partial class ValidateUnixRegularExpressionCount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static ValidateUnixRegularExpressionCount instance = new ValidateUnixRegularExpressionCount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateUnixRegularExpressionCount()
        {
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateUnixRegularExpressionCount Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("97bdc9fe-cfb1-4829-91dc-41ebe7bea008")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
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

            ClearTextfield(repo.FindAndReplace.Uedit64.FindTextField);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'FindAndReplace.Uedit64.FindTextField'.", repo.FindAndReplace.Uedit64.FindTextFieldInfo, new RecordItemIndex(1));
            repo.FindAndReplace.Uedit64.FindTextField.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FindAndReplace.Uedit64.RegularExpressions'.", repo.FindAndReplace.Uedit64.RegularExpressionsInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.RegularExpressionsInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.ComboBox2926' at 138;16.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(3));
            repo.FindAndReplace.Uedit64.ComboBox2926.Click("138;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Unix' at 118;10.", repo.List1000.UnixInfo, new RecordItemIndex(4));
            repo.List1000.Unix.Click("118;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (SelectedItemText='Unix') on item 'FindAndReplace.Uedit64.ComboBox2926'.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.ComboBox2926Info, "SelectedItemText", "Unix");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.CountAll' at 20;7.", repo.FindAndReplace.Uedit64.CountAllInfo, new RecordItemIndex(6));
            repo.FindAndReplace.Uedit64.CountAll.Click("20;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='84 occurrences found.') on item 'FindAndReplace.Uedit64.occurrences'.", repo.FindAndReplace.Uedit64.occurrencesInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.occurrencesInfo, "Text", "84 occurrences found.");
            Delay.Milliseconds(100);
            
            ClearTextfield(repo.FindAndReplace.Uedit64.FindTextField);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
