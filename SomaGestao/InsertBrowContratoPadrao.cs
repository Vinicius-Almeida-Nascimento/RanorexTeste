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
    ///The InsertBrowContratoPadrao recording.
    /// </summary>
    [TestModule("516a1522-668b-424d-aeb3-3eafbfc3aead", ModuleType.Recording, 1)]
    public partial class InsertBrowContratoPadrao : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertBrowContratoPadrao instance = new InsertBrowContratoPadrao();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertBrowContratoPadrao()
        {
            DescricaoTipo = "teste";
            DataContrato = "01012021";
            ValorContratoPadrao = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertBrowContratoPadrao Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescricaoTipo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoTipo.
        /// </summary>
        [TestVariable("b6b3194d-dcda-4399-9bb7-e6ecd12780fc")]
        public string DescricaoTipo
        {
            get { return _DescricaoTipo; }
            set { _DescricaoTipo = value; }
        }

        string _DataContrato;

        /// <summary>
        /// Gets or sets the value of variable DataContrato.
        /// </summary>
        [TestVariable("6b15ec9e-1ec1-4c1e-a8b9-399f740e9f1c")]
        public string DataContrato
        {
            get { return _DataContrato; }
            set { _DataContrato = value; }
        }

        string _ValorContratoPadrao;

        /// <summary>
        /// Gets or sets the value of variable ValorContratoPadrao.
        /// </summary>
        [TestVariable("feca9196-f07b-4a62-b431-9a21600809ba")]
        public string ValorContratoPadrao
        {
            get { return _ValorContratoPadrao; }
            set { _ValorContratoPadrao = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528014'.", repo.FrmPrincipal.Form6528014Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form6528014Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 442;547.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("442;547");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(2));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 748;131.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(3));
            repo.BASEDETESTESBIANCHINI.Image1.Click("748;131");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DataContrato' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(4));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DataContrato);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 429;291.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(5));
            repo.BASEDETESTESBIANCHINI.Image1.Click("429;291");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(6));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 289;534.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(7));
            repo.BASEDETESTESBIANCHINI.Image1.Click("289;534");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ServicoTodos' at 78;-2.", repo.List1000.ServicoTodosInfo, new RecordItemIndex(8));
            repo.List1000.ServicoTodos.Click("78;-2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 359;180.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(9));
            repo.BASEDETESTESBIANCHINI.Image1.Click("359;180");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Porcentagem' at 78;8.", repo.List1000.PorcentagemInfo, new RecordItemIndex(10));
            repo.List1000.Porcentagem.Click("78;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 413;180.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(11));
            repo.BASEDETESTESBIANCHINI.Image1.Click("413;180");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 730;179.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(12));
            repo.BASEDETESTESBIANCHINI.Image1.Click("730;179");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Atencao.ButtonOK' at 58;12.", repo.Atencao.ButtonOKInfo, new RecordItemIndex(13));
            repo.Atencao.ButtonOK.Click("58;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ValorContratoPadrao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(14));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(ValorContratoPadrao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'BASEDETESTESBIANCHINI.Image1' at 722;171.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(15));
            repo.BASEDETESTESBIANCHINI.Image1.MoveTo("722;171");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'BASEDETESTESBIANCHINI.Image1' at 722;171.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(16));
            repo.BASEDETESTESBIANCHINI.Image1.MoveTo("722;171");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 1067;72.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(17));
            repo.BASEDETESTESBIANCHINI.Image1.Click("1067;72");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 1067;75.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(18));
            repo.BASEDETESTESBIANCHINI.Image1.Click("1067;75");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528014'.", repo.FrmPrincipal.Form6528014Info, new RecordItemIndex(19));
            Validate.Exists(repo.FrmPrincipal.Form6528014Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}