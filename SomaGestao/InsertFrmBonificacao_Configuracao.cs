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
    ///The InsertFrmBonificacao_Configuracao recording.
    /// </summary>
    [TestModule("da28a05d-ca6b-4a13-b32e-42625c5544fb", ModuleType.Recording, 1)]
    public partial class InsertFrmBonificacao_Configuracao : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertFrmBonificacao_Configuracao instance = new InsertFrmBonificacao_Configuracao();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertFrmBonificacao_Configuracao()
        {
            Confirmacao = "{Return}";
            ValorBonus = "1";
            DiaEncerramento = "30";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertFrmBonificacao_Configuracao Instance
        {
            get { return instance; }
        }

#region Variables

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("99a87191-6fb7-4ba7-9706-ecb2eeb3d042")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _ValorBonus;

        /// <summary>
        /// Gets or sets the value of variable ValorBonus.
        /// </summary>
        [TestVariable("7e90b7c0-da1b-4940-be50-c7b6e314337e")]
        public string ValorBonus
        {
            get { return _ValorBonus; }
            set { _ValorBonus = value; }
        }

        string _DiaEncerramento;

        /// <summary>
        /// Gets or sets the value of variable DiaEncerramento.
        /// </summary>
        [TestVariable("f9d8f933-b35e-4042-888a-e364105b1b0c")]
        public string DiaEncerramento
        {
            get { return _DiaEncerramento; }
            set { _DiaEncerramento = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528023'.", repo.FrmPrincipal.Form6528023Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form6528023Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 845;522.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("845;522");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OperacaoBloqueada.UUltimaVenda' at 79;7.", repo.OperacaoBloqueada.UUltimaVendaInfo, new RecordItemIndex(2));
            repo.OperacaoBloqueada.UUltimaVenda.Click("79;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(3));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(4));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ValorBonus' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(5));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(ValorBonus);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(6));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DiaEncerramento' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(7));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DiaEncerramento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 934;515.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(8));
            repo.BASEDETESTESBIANCHINI.Image1.Click("934;515");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528023'.", repo.FrmPrincipal.Form6528023Info, new RecordItemIndex(9));
            Validate.Exists(repo.FrmPrincipal.Form6528023Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
