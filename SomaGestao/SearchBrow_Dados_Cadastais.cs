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
    ///The SearchBrow_Dados_Cadastais recording.
    /// </summary>
    [TestModule("f3e5ae12-31ec-4dca-a6d8-0c3d212fec61", ModuleType.Recording, 1)]
    public partial class SearchBrow_Dados_Cadastais : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static SearchBrow_Dados_Cadastais instance = new SearchBrow_Dados_Cadastais();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchBrow_Dados_Cadastais()
        {
            Confirmacao = "{Return}";
            DescricaoTipo = "teste";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchBrow_Dados_Cadastais Instance
        {
            get { return instance; }
        }

#region Variables

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("3ba7629d-dfa2-4cb3-b434-ab30bfc76d7d")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _DescricaoTipo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoTipo.
        /// </summary>
        [TestVariable("6f376016-e622-49cb-8bfb-53e9ae7ea059")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form652807'.", repo.FrmPrincipal.Form652807Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form652807Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 579;146.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("579;146");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(2));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(3));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form652807'.", repo.FrmPrincipal.Form652807Info, new RecordItemIndex(4));
            Validate.Exists(repo.FrmPrincipal.Form652807Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
