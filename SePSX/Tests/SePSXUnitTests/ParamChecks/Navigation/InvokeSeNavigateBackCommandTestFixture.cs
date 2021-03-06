﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 8/20/2012
 * Time: 8:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SePSXUnitTests.CheckCmdletParameters
{
    using MbUnit.Framework;

    /// <summary>
    /// Description of InvokeSeNavigateBackCommand.
    /// </summary>
    [TestFixture]
    public class InvokeSeNavigateBackCommand_ParamCheck // NavigationCmdletBase
    {
        public InvokeSeNavigateBackCommand_ParamCheck()
        {
        }
        
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspaceForParamChecks();
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            // MiddleLevelCode.DisposeRunspace(); // 20121226
        }
        
        [Test]
        [Category("Fast")]
        [Category("Invoke-SeNavigateBack")]
        public void InvokeSeNavigateBack_Empty()
        {
            CmdletUnitTest.TestRunspace.RunAndCheckCmdletParameters_ParamsOK_CmdletException(
                "Invoke-SeNavigateBack;");
        }
    }
}
