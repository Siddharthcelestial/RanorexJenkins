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
    ///The ValidateFindResultsFile recording.
    /// </summary>
    [TestModule("3ffec21c-da52-4b7c-a169-86b7b80ba42e", ModuleType.Recording, 1)]
    public partial class ValidateFindResultsFile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static ValidateFindResultsFile instance = new ValidateFindResultsFile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateFindResultsFile()
        {
            ValidateText = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateFindResultsFile Instance
        {
            get { return instance; }
        }

#region Variables

        string _ValidateText;

        /// <summary>
        /// Gets or sets the value of variable ValidateText.
        /// </summary>
        [TestVariable("47b1b3ef-d058-4b07-96b5-1224d4af53a9")]
        public string ValidateText
        {
            get { return _ValidateText; }
            set { _ValidateText = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAst'.", repo.UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAstInfo, new RecordItemIndex(0));
            Validate.Exists(repo.UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAstInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='** Find Results ** ') on item 'UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAst'.", repo.UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAstInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.UltraEdit64Bit.TabPageAsteriskAsteriskFindResultsAstInfo, "Title", "** Find Results ** ");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.FormEdit1UltraEdit64Bit.PageTabList, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormEdit1UltraEdit64Bit.PageTabList'.", repo.FormEdit1UltraEdit64Bit.PageTabListInfo, new RecordItemIndex(3));
            Validate.Exists(repo.FormEdit1UltraEdit64Bit.PageTabListInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (WindowText>$ValidateText) on item 'Uedit64.FindResultsFile'.", repo.Uedit64.FindResultsFileInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.Uedit64.FindResultsFileInfo, "WindowText", ValidateText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}