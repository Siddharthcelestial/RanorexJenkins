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
    public partial class ReplaceTabRegularExpression
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public string GetSymbol(Adapter repoItem, string Text)
        {
           
            string OptionText = repoItem.Element.GetAttributeValueText("Text");
      		string firstword = OptionText.Split(' ')[0];
            firstword= firstword.Trim();
            string combinedText = Text + firstword;
            Report.Info("combined text " +combinedText);
            return combinedText;
        }

       

    }
}
