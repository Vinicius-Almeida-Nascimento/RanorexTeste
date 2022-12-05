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
    ///The InsertBrowCargo recording.
    /// </summary>
    [TestModule("3cd10dbb-09aa-49cc-9657-522c3bff6c3c", ModuleType.Recording, 1)]
    public partial class InsertBrowCargo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertBrowCargo instance = new InsertBrowCargo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertBrowCargo()
        {
            DescricaoTipo = "teste";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertBrowCargo Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescricaoTipo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoTipo.
        /// </summary>
        [TestVariable("71a17d63-f3d3-47cb-be72-c05918774abd")]
        public string DescricaoTipo
        {
            get { return _DescricaoTipo; }
            set { _DescricaoTipo = value; }
        }

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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 436;542.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("436;542");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'None' at 26;20.", repo.None.SelfInfo, new RecordItemIndex(2));
            repo.None.Self.Click("26;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 541;342.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(3));
            repo.BASEDETESTESBIANCHINI.Image1.Click("541;342");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(4));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 473;393.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(5));
            repo.BASEDETESTESBIANCHINI.Image1.Click("473;393");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 915;252.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(6));
            repo.BASEDETESTESBIANCHINI.Image1.Click("915;252");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
