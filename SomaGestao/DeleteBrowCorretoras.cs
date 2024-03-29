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
    ///The DeleteBrowCorretoras recording.
    /// </summary>
    [TestModule("6ca68bd5-73d1-40d5-93b4-d209d65f82fb", ModuleType.Recording, 1)]
    public partial class DeleteBrowCorretoras : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SomaGestaoRepository repository.
        /// </summary>
        public static SomaGestaoRepository repo = SomaGestaoRepository.Instance;

        static DeleteBrowCorretoras instance = new DeleteBrowCorretoras();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteBrowCorretoras()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteBrowCorretoras Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'BASEDETESTESBIANCHINI.Form652805'.", repo.BASEDETESTESBIANCHINI.Form652805Info, new RecordItemIndex(0));
            Validate.Exists(repo.BASEDETESTESBIANCHINI.Form652805Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 521;257.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(1));
            repo.BASEDETESTESBIANCHINI.Image1.Click("521;257");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 567;551.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(2));
            repo.BASEDETESTESBIANCHINI.Image1.Click("567;551");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Assistente'.", repo.Assistente.SelfInfo, new RecordItemIndex(3));
            Validate.Exists(repo.Assistente.SelfInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 697;337.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(4));
            repo.BASEDETESTESBIANCHINI.Image1.Click("697;337");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'BASEDETESTESBIANCHINI.Form652805'.", repo.BASEDETESTESBIANCHINI.Form652805Info, new RecordItemIndex(5));
            Validate.Exists(repo.BASEDETESTESBIANCHINI.Form652805Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BASEDETESTESBIANCHINI.Image1' at 975;96.", repo.BASEDETESTESBIANCHINI.Image1Info, new RecordItemIndex(6));
            repo.BASEDETESTESBIANCHINI.Image1.Click("975;96");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
