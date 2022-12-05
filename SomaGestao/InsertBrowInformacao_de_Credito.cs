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
    ///The InsertBrowInformacao_de_Credito recording.
    /// </summary>
    [TestModule("9c88dee1-96cc-4c4e-8ff9-7bdf230b9256", ModuleType.Recording, 1)]
    public partial class InsertBrowInformacao_de_Credito : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertBrowInformacao_de_Credito instance = new InsertBrowInformacao_de_Credito();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertBrowInformacao_de_Credito()
        {
            DescricaoTipo = "teste";
            Confirmacao = "{Return}";
            ResultadoConsulta = "resultado";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertBrowInformacao_de_Credito Instance
        {
            get { return instance; }
        }

#region Variables

        string _DescricaoTipo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoTipo.
        /// </summary>
        [TestVariable("b403aa15-1a14-452f-a037-50439a4799f7")]
        public string DescricaoTipo
        {
            get { return _DescricaoTipo; }
            set { _DescricaoTipo = value; }
        }

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("ee9cfd59-d347-4892-9ace-f15e46e07e0b")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _ResultadoConsulta;

        /// <summary>
        /// Gets or sets the value of variable ResultadoConsulta.
        /// </summary>
        [TestVariable("78c13184-852f-46f0-9149-58ad8e664ec4")]
        public string ResultadoConsulta
        {
            get { return _ResultadoConsulta; }
            set { _ResultadoConsulta = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form652806'.", repo.FrmPrincipal.Form652806Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form652806Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 470;509.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("470;509");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form65281'.", repo.FrmPrincipal.Form65281Info, new RecordItemIndex(2));
            Validate.Exists(repo.FrmPrincipal.Form65281Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 377;280.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(3));
            repo.BASEDETESTESBIANCHINI.Image1.Click("377;280");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(4));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'ProcuraFrmProcura'.", repo.ProcuraFrmProcura.SelfInfo, new RecordItemIndex(5));
            repo.ProcuraFrmProcura.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'ProcuraFrmProcura'.", repo.ProcuraFrmProcura.SelfInfo, new RecordItemIndex(6));
            repo.ProcuraFrmProcura.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ProcuraFrmProcura.TESTECNPJTESTE' at 116;7.", repo.ProcuraFrmProcura.TESTECNPJTESTEInfo, new RecordItemIndex(7));
            repo.ProcuraFrmProcura.TESTECNPJTESTE.DoubleClick("116;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(8));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ResultadoConsulta' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(9));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(ResultadoConsulta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(10));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 389;408.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(11));
            repo.BASEDETESTESBIANCHINI.Image1.Click("389;408");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
