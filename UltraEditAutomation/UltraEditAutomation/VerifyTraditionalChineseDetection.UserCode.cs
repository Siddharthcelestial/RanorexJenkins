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
    public partial class VerifyTraditionalChineseDetection
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
       
        public void TraditionalChinese()
        {
            try
            {
                // Locate the text editor element using the Ranorex Adapter
                 var textEditor = Host.Local.FindSingle<Ranorex.Unknown>(repo.UltraEdit64Bit.editorScreen.GetPath());

                // Retrieve text from WindowText
                string text = textEditor.Element.GetAttributeValueText("WindowText"); 
         
                // Check if the text is empty
                if (string.IsNullOrEmpty(text))
                {
                    Report.Warn("The text is empty or not accessible.");
                    return;
                }

                // Check if the text contains any Chinese characters
                bool isChinese = IsTextInChinese(text);

                // Report the result
                if (isChinese)
                {
                    Report.Info("The text contains Chinese characters.");
                }
                else
                {
                    Report.Error("The text does not contain Chinese characters.");
                    throw new Exception("Test case failed: The text does not contain Chinese characters.");
                }
            }
            catch (RanorexException ex)
            {
                Report.Error($"Error accessing the text: {ex.Message}");
            }
        }
        
        private bool IsTextInChinese(string text)
        {
            // Unicode range for Chinese
            foreach (char c in text)
            {
                if (c >= 0x4E00 && c <= 0x9FFF)
                {
                    return true; // Found a Chinese character
                }
            }
            return false; // No Chinese characters found
        }

        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

    }
}
