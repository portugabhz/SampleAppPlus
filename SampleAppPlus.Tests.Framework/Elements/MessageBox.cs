﻿using AutomationRhapsody.NTestsRunner.Types;
using System;
using System.Windows.Automation;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace SampleAppPlus.Tests.Framework.Elements
{
    public class MessageBox
    {
        private Window win;
        public MessageBox(Window window)
        {
            win = window;
        }

        #region Elements
        private Button Button_OK
        {
            get
            {
                return win.Get<Button>(SearchCriteria.ByControlType(ControlType.Button).AndByText("OK"));
            }
        }
        private Label Label_Text
        {
            get
            {
                return win.Get<Label>(SearchCriteria.ByControlType(ControlType.Text));
            }
        }
        #endregion

        #region Actions
        public void ClickOkButton()
        {
            Button_OK.Click();
        }
        #endregion

        #region Verifications
        public Verification VerifyMessageText(Messages message)
        {
            return BaseTest.VerifyText(message.GetStringValue(), Label_Text.Text);
        }
        #endregion
    }
}
