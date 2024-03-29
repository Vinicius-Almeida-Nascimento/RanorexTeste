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

namespace SomaGestao
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BrowSituacao_Cliente recording.
    /// </summary>
    [TestModule("2d103168-d3e2-43bc-a051-bbc112ba43b9", ModuleType.Recording, 1)]
    public partial class BrowSituacao_Cliente : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static BrowSituacao_Cliente instance = new BrowSituacao_Cliente();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BrowSituacao_Cliente()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BrowSituacao_Cliente Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'BASEDETESTESBIANCHINI.Image1'.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(0));
            Validate.Exists(repo.BASEDETESTESBIANCHINI.Image1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Cadastro' at 25;4.", repo.BASEDETESTESBIANCHINI.CadastroInfo, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Cadastro.Click("25;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Oficina.MenuItem3' at 71;-12.", repo.Oficina.MenuItem3Info, new RecordItemIndex(2));
            repo.Oficina.MenuItem3.Click("71;-12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Oficina.MenuItem4' at 79;4.", repo.Oficina.MenuItem4Info, new RecordItemIndex(3));
            repo.Oficina.MenuItem4.Click("79;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form652803'.", repo.FrmPrincipal.Form652803Info, new RecordItemIndex(4));
            Validate.Exists(repo.FrmPrincipal.Form652803Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
