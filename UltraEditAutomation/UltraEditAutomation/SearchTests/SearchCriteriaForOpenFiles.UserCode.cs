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

namespace UltraEditAutomation.SearchTests
{
    public partial class SearchCriteriaForOpenFiles
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ClearTextField(Adapter TextField)
        {
            if (TextField == null)
	        {
	            return;
	        }
		        try
	        {
	            TextField.Click(); // Focus on the text field
	            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}{Back}"); // Select all text and delete it
	            Report.Info("Text field cleared successfully.");
	        }
	        catch (Exception ex)
	        {
	            Report.Error($"Failed to clear text field: {ex.Message}");
	        }
        }

    }
}