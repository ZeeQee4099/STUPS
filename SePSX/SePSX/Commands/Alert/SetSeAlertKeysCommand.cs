﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 9/3/2012
 * Time: 1:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSX.Commands
{
    using System.Management.Automation;

    /// <summary>
    /// Description of SetSeAlertKeysCommand.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Invoke, "SeAlertKeys")]
    [OutputType(typeof(bool))]
    public class SetSeAlertKeysCommand : AlertCmdletBase
    {
        public SetSeAlertKeysCommand()
        {
        }
        
        #region Parameters
        [Parameter(Mandatory = true,
                   Position = 0)]
        public string Text { get; set; }
        #endregion Parameters
        
        protected override void ProcessRecord()
        {
            CheckInputAlert(true);
            
            SeHelper.AlertSendKeys(this, InputObject, Text);
        }
    }
}
