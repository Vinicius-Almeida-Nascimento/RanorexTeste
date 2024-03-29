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
    ///The InsertBrowCampoObrigatorio recording.
    /// </summary>
    [TestModule("200adccd-72db-42a7-8f14-6cb5ccab39fe", ModuleType.Recording, 1)]
    public partial class InsertBrowCampoObrigatorio : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertBrowCampoObrigatorio instance = new InsertBrowCampoObrigatorio();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertBrowCampoObrigatorio()
        {
            NomeTabela = "vendas_balcao";
            Confirmacao = "{Return}";
            CampoTabela = "nr_venda]";
            DescricaoCampo = "numero ";
            Resultado = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertBrowCampoObrigatorio Instance
        {
            get { return instance; }
        }

#region Variables

        string _NomeTabela;

        /// <summary>
        /// Gets or sets the value of variable NomeTabela.
        /// </summary>
        [TestVariable("dca2d49b-d5af-441f-8d77-d7813dec056d")]
        public string NomeTabela
        {
            get { return _NomeTabela; }
            set { _NomeTabela = value; }
        }

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("21ecb106-3466-4611-8a88-9f997d5f28fc")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _CampoTabela;

        /// <summary>
        /// Gets or sets the value of variable CampoTabela.
        /// </summary>
        [TestVariable("670152a3-8991-4472-8620-905ec0a5e5e7")]
        public string CampoTabela
        {
            get { return _CampoTabela; }
            set { _CampoTabela = value; }
        }

        string _DescricaoCampo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoCampo.
        /// </summary>
        [TestVariable("89d90454-c99f-4475-aded-79e1f32e7ac3")]
        public string DescricaoCampo
        {
            get { return _DescricaoCampo; }
            set { _DescricaoCampo = value; }
        }

        string _Resultado;

        /// <summary>
        /// Gets or sets the value of variable Resultado.
        /// </summary>
        [TestVariable("e3917739-b69e-453f-ab3e-f2dbd6ea9fd6")]
        public string Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528022'.", repo.FrmPrincipal.Form6528022Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form6528022Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 387;497.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("387;497");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NomeTabela' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(2));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(NomeTabela);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(3));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(4));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CampoTabela' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(5));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(CampoTabela);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(6));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(7));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(8));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(9));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'Assistente'.", repo.Assistente.SelfInfo, new RecordItemIndex(10));
            repo.Assistente.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoCampo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(11));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoCampo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(12));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(13));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoCampo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(14));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoCampo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(15));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CampoTabela' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(16));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(CampoTabela);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(17));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(18));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(19));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(20));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Resultado' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(21));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Resultado);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(22));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(23));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press("{Down}{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(24));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 448;240.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(25));
            repo.BASEDETESTESBIANCHINI.Image1.Click("448;240");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 415;538.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(26));
            repo.BASEDETESTESBIANCHINI.Image1.Click("415;538");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 1001;68.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(27));
            repo.BASEDETESTESBIANCHINI.Image1.Click("1001;68");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
