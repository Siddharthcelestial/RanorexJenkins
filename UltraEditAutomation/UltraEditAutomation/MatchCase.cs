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
    ///The MatchCase recording.
    /// </summary>
    [TestModule("e6385fd6-39e2-46c1-86fe-44094e989c26", ModuleType.Recording, 1)]
    public partial class MatchCase : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static MatchCase instance = new MatchCase();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MatchCase()
        {
            Text = "";
            Warning = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MatchCase Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("a701400a-2c77-4853-b9da-fc5fc3ddfd4a")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        string _Warning;

        /// <summary>
        /// Gets or sets the value of variable Warning.
        /// </summary>
        [TestVariable("8547d97c-cd37-4841-a61b-230ef6c36a55")]
        public string Warning
        {
            get { return _Warning; }
            set { _Warning = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.FindASCII' at 9;9.", repo.HEXFindReplace.FindASCIIInfo, new RecordItemIndex(0));
            repo.HEXFindReplace.FindASCII.Click("9;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True ') on item 'HEXFindReplace.FindASCII'.", repo.HEXFindReplace.FindASCIIInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HEXFindReplace.FindASCIIInfo, "Checked", "True ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.CheckBoxMatchCase' at 10;5.", repo.HEXFindReplace.CheckBoxMatchCaseInfo, new RecordItemIndex(2));
            repo.HEXFindReplace.CheckBoxMatchCase.Click("10;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'HEXFindReplace.CheckBoxMatchCase'.", repo.HEXFindReplace.CheckBoxMatchCaseInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HEXFindReplace.CheckBoxMatchCaseInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Text1687' at 112;13.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(4));
            repo.HEXFindReplace.Text1687.Click("112;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(5));
            repo.HEXFindReplace.Text1687.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.ButtonNext' at 15;9.", repo.HEXFindReplace.ButtonNextInfo, new RecordItemIndex(6));
            repo.HEXFindReplace.ButtonNext.Click("15;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'UltraEdit.UltraEdit'.", repo.UltraEdit.UltraEditInfo, new RecordItemIndex(7));
            Validate.Exists(repo.UltraEdit.UltraEditInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Warning) on item 'UltraEdit.Text65535'.", repo.UltraEdit.Text65535Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.UltraEdit.Text65535Info, "Text", Warning);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit.ButtonOK' at 40;12.", repo.UltraEdit.ButtonOKInfo, new RecordItemIndex(9));
            repo.UltraEdit.ButtonOK.Click("40;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'HEXFindReplace'", repo.HEXFindReplace.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(10));
            repo.HEXFindReplace.SelfInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'HEXFindReplace'.", repo.HEXFindReplace.SelfInfo, new RecordItemIndex(11));
            repo.HEXFindReplace.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}