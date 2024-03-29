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
    ///The DeleteBrowCargo recording.
    /// </summary>
    [TestModule("1e849d40-e03a-431e-a638-4f9a1d601689", ModuleType.Recording, 1)]
    public partial class DeleteBrowCargo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static DeleteBrowCargo instance = new DeleteBrowCargo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteBrowCargo()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteBrowCargo Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528016'.", repo.FrmPrincipal.Form6528016Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form6528016Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 474;255.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("474;255");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 567;542.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(2));
            repo.BASEDETESTESBIANCHINI.Image1.Click("567;542");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Assistente.ButtonSim' at 21;5.", repo.Assistente.ButtonSimInfo, new RecordItemIndex(3));
            repo.Assistente.ButtonSim.Click("21;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528016'.", repo.FrmPrincipal.Form6528016Info, new RecordItemIndex(4));
            Validate.Exists(repo.FrmPrincipal.Form6528016Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 971;89.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(5));
            repo.BASEDETESTESBIANCHINI.Image1.Click("971;89");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
