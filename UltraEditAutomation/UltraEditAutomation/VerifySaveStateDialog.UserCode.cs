﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace UltraEditAutomation
{
    public partial class VerifySaveStateDialog
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
        //	var saveStateIsEnabled = repo.Uedit64.SaveStateIsEnabled;
        	// Your recording specific initialization code goes here.
        }

        public void CheckSaveState(RepoItemInfo formInfo, RepoItemInfo checkboxInfo, RepoItemInfo buttonInfo)
        {
          Delay.Milliseconds(5000);

    if (repo.Uedit64.SaveStateIsEnabledInfo.Exists())
    {
        Report.Success("Save state dialog found.");

        var dontShowThisWindowAgainInfo = repo.Uedit64.DontShowThisWindowAgainInfo;
        Validate.AttributeEqual(dontShowThisWindowAgainInfo, "checked", "true");

        var buttonOK = repo.Uedit64.ButtonOK;
        buttonOK.Click();
        Report.Success("Clicked on OK button.");
   		 }
        }
	 }
  }
