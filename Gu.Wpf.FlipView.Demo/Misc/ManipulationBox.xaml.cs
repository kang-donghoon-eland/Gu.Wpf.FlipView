﻿namespace Gu.Wpf.FlipView.Demo.Misc
{
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for ManipulationBox.xaml
    /// </summary>
    public partial class ManipulationBox : EventBox
    {
        //private readonly ManipulationGestureFinder _manipulationGestureFinder;
        public ManipulationBox()
        {
            this.InitializeComponent();
            //_manipulationGestureFinder = new ManipulationGestureFinder { InputElement = InputElement };
        }

        protected override void OnEnded(object sender, InputEventArgs e)
        {
            this.Args.Add(new ArgsVm(e));
            //Args.Add(string.Format("Find: {0}", _manipulationGestureFinder.Find((ManipulationCompletedEventArgs)e)));
        }
    }
}
