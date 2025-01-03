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
    ///The CreateNewProject recording.
    /// </summary>
    [TestModule("7c6a1689-f1e2-49ff-ac4b-2c81fbe3c7c5", ModuleType.Recording, 1)]
    public partial class CreateNewProject : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UltraEditAutomation.UltraEditAutomationRepository repository.
        /// </summary>
        public static global::UltraEditAutomation.UltraEditAutomationRepository repo = global::UltraEditAutomation.UltraEditAutomationRepository.Instance;

        static CreateNewProject instance = new CreateNewProject();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewProject()
        {
            ProjectName = "";
            DirectoryPath = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewProject Instance
        {
            get { return instance; }
        }

#region Variables

        string _ProjectName;

        /// <summary>
        /// Gets or sets the value of variable ProjectName.
        /// </summary>
        [TestVariable("78c821ba-3979-4458-9cc7-8db2494ced8c")]
        public string ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        string _DirectoryPath;

        /// <summary>
        /// Gets or sets the value of variable DirectoryPath.
        /// </summary>
        [TestVariable("cd0ddc78-73db-4354-834f-724dca0b2bcc")]
        public string DirectoryPath
        {
            get { return _DirectoryPath; }
            set { _DirectoryPath = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'Uedit64.Project'.", repo.Uedit64.ProjectInfo, new RecordItemIndex(0));
            repo.Uedit64.Project.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Project' at Center.", repo.Uedit64.ProjectInfo, new RecordItemIndex(1));
            repo.Uedit64.Project.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.NewProject' at Center.", repo.FormEdit1UltraEdit64Bit.NewProjectInfo, new RecordItemIndex(2));
            repo.FormEdit1UltraEdit64Bit.NewProject.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Uedit64.SpecifyProjectFile'.", repo.Uedit64.SpecifyProjectFileInfo, new RecordItemIndex(3));
            Validate.Exists(repo.Uedit64.SpecifyProjectFileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ProjectName' with focus on 'FormEdit1UltraEdit64Bit.ComboBox1148'.", repo.FormEdit1UltraEdit64Bit.ComboBox1148Info, new RecordItemIndex(4));
            repo.FormEdit1UltraEdit64Bit.ComboBox1148.PressKeys(ProjectName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ButtonSave' at Center.", repo.Uedit64.ButtonSaveInfo, new RecordItemIndex(5));
            repo.Uedit64.ButtonSave.Click();
            Delay.Milliseconds(0);
            
            CheckAndClickYesButton(repo.Uedit64.ButtonYesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Uedit64.ProjectSettingsFifProj'.", repo.Uedit64.ProjectSettingsFifProjInfo, new RecordItemIndex(7));
            Validate.Exists(repo.Uedit64.ProjectSettingsFifProjInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'Uedit64.ButtonAddFolder'.", repo.Uedit64.ButtonAddFolderInfo, new RecordItemIndex(8));
            repo.Uedit64.ButtonAddFolder.Press();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Uedit64.AddFolder'.", repo.Uedit64.AddFolderInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Uedit64.AddFolderInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DirectoryPath' with focus on 'Uedit64.Text342'.", repo.Uedit64.Text342Info, new RecordItemIndex(10));
            repo.Uedit64.Text342.PressKeys(DirectoryPath);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ButtonAdd' at Center.", repo.Uedit64.ButtonAddInfo, new RecordItemIndex(11));
            repo.Uedit64.ButtonAdd.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'Uedit64.ProjectSettingsFifProj'.", repo.Uedit64.ProjectSettingsFifProjInfo, new RecordItemIndex(12));
            repo.Uedit64.ProjectSettingsFifProj.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
