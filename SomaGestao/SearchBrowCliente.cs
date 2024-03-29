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
    ///The SearchBrowCliente recording.
    /// </summary>
    [TestModule("54846abe-5fe8-4b67-b642-2ecf06749684", ModuleType.Recording, 1)]
    public partial class SearchBrowCliente : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static SearchBrowCliente instance = new SearchBrowCliente();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchBrowCliente()
        {
            Confirmacao = "{Return}";
            SearchName = "Operador teste";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchBrowCliente Instance
        {
            get { return instance; }
        }

#region Variables

        string _Confirmacao;

        /// <summary>
        /// Gets or sets the value of variable Confirmacao.
        /// </summary>
        [TestVariable("21b9da48-b526-4cf2-ad97-2895a058fe1b")]
        public string Confirmacao
        {
            get { return _Confirmacao; }
            set { _Confirmacao = value; }
        }

        string _SearchName;

        /// <summary>
        /// Gets or sets the value of variable SearchName.
        /// </summary>
        [TestVariable("9a3477f7-fc51-4529-b5ec-36115cf63445")]
        public string SearchName
        {
            get { return _SearchName; }
            set { _SearchName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 448;143.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(0));
            repo.BASEDETESTESBIANCHINI.Image1.Click("448;143");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SearchName' with focus on 'FrmPrincipal'.", repo.FrmPrincipal.SelfInfo, new RecordItemIndex(1));
            repo.FrmPrincipal.Self.EnsureVisible();
            Keyboard.Press(SearchName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Confirmacao'.", new RecordItemIndex(2));
            Keyboard.Press(Confirmacao);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 422;260.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(3));
            repo.BASEDETESTESBIANCHINI.Image1.Click("422;260");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
