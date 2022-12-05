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
    ///The InsertBrowCliente_CRM recording.
    /// </summary>
    [TestModule("5c5a338a-d827-4350-894a-137250c2db06", ModuleType.Recording, 1)]
    public partial class InsertBrowCliente_CRM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static InsertBrowCliente_CRM instance = new InsertBrowCliente_CRM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertBrowCliente_CRM()
        {
            Confirmacao = "{Return}";
            NumCNPJ = "68565757000166";
            DescricaoTipo = "teste";
            Data = "01012022";
            NumCep = "{NumPad1}{NumPad3}{NumPad6}{NumPad0}{NumPad6}{NumPad3}{NumPad2}{NumPad1}";
            NumEnd = "{NumPad1}{NumPad0}";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertBrowCliente_CRM Instance
        {
            get { return instance; }
        }

#region Variables

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("60128501-af42-41ec-bd40-cb9f433578b7")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _NumCNPJ;

        /// <summary>
        /// Gets or sets the value of variable NumCNPJ.
        /// </summary>
        [TestVariable("2a6b3d0f-ca73-410c-8fd2-23ba543f0ee6")]
        public string NumCNPJ
        {
            get { return _NumCNPJ; }
            set { _NumCNPJ = value; }
        }

        string _DescricaoTipo;

        /// <summary>
        /// Gets or sets the value of variable DescricaoTipo.
        /// </summary>
        [TestVariable("025c49c0-6d31-492c-aee5-f8a4142cc45c")]
        public string DescricaoTipo
        {
            get { return _DescricaoTipo; }
            set { _DescricaoTipo = value; }
        }

        string _Data;

        /// <summary>
        /// Gets or sets the value of variable Data.
        /// </summary>
        [TestVariable("5aa2da39-ab4b-4b42-8c4c-46172f2f2764")]
        public string Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        string _NumCep;

        /// <summary>
        /// Gets or sets the value of variable NumCep.
        /// </summary>
        [TestVariable("f47f9da1-093f-4ef5-901a-590f11796a81")]
        public string NumCep
        {
            get { return _NumCep; }
            set { _NumCep = value; }
        }

        string _NumEnd;

        /// <summary>
        /// Gets or sets the value of variable NumEnd.
        /// </summary>
        [TestVariable("81f17355-4a56-48c3-9756-52ccff2738df")]
        public string NumEnd
        {
            get { return _NumEnd; }
            set { _NumEnd = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmPrincipal.Form6528026'.", repo.FrmPrincipal.Form6528026Info, new RecordItemIndex(0));
            Validate.Exists(repo.FrmPrincipal.Form6528026Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 269;544.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("269;544");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'None1' at -403;-239.", repo.None1.SelfInfo, new RecordItemIndex(2));
            repo.None1.Self.Click("-403;-239");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(3));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 601;150.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(4));
            repo.BASEDETESTESBIANCHINI.Image1.Click("601;150");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumCNPJ' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(5));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(NumCNPJ);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 870;156.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(6));
            repo.BASEDETESTESBIANCHINI.Image1.Click("870;156");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(7));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(8));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DescricaoTipo' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(9));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(DescricaoTipo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(10));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(11));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(12));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(13));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Data' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(14));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Data);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad1}{NumPad1}' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(15));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press("{NumPad1}{NumPad1}{NumPad1}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(16));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(17));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(18));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(19));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(20));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(21));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 393;534.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(22));
            repo.BASEDETESTESBIANCHINI.Image1.Click("393;534");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 994;388.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(23));
            repo.BASEDETESTESBIANCHINI.Image1.Click("994;388");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumCep' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(24));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(NumCep);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(25));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumEnd' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(26));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(NumEnd);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 454;502.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(27));
            repo.BASEDETESTESBIANCHINI.Image1.Click("454;502");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'BASEDETESTESBIANCHINI.Image1' at 942;143.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(28));
            repo.BASEDETESTESBIANCHINI.Image1.MoveTo("942;143");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'BASEDETESTESBIANCHINI.Image1' at 933;164.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(29));
            repo.BASEDETESTESBIANCHINI.Image1.MoveTo("933;164");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 943;142.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(30));
            repo.BASEDETESTESBIANCHINI.Image1.Click("943;142");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 407;529.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(31));
            repo.BASEDETESTESBIANCHINI.Image1.Click("407;529");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}