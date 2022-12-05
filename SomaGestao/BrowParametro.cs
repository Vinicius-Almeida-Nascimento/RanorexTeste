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
    ///The BrowParametro recording.
    /// </summary>
    [TestModule("23714eb0-9d86-494b-bf80-934575048891", ModuleType.Recording, 1)]
    public partial class BrowParametro : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static BrowParametro instance = new BrowParametro();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BrowParametro()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BrowParametro Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Cadastro' at 9;15.", repo.BASEDETESTESBIANCHINI.CadastroInfo, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Cadastro.Click("9;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Cadastro' at 63;39.", repo.BASEDETESTESBIANCHINI.CadastroInfo, new RecordItemIndex(2));
            repo.BASEDETESTESBIANCHINI.Cadastro.Click("63;39");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Oficina.MenuItem2' at 55;4.", repo.Oficina.MenuItem2Info, new RecordItemIndex(3));
            repo.Oficina.MenuItem2.Click("55;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528019'.", repo.FrmPrincipal.Form6528019Info, new RecordItemIndex(4));
            Validate.Exists(repo.FrmPrincipal.Form6528019Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
