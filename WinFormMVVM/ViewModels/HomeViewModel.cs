using System;
using ReactiveUI;

namespace WinFormMVVM.ViewModels
{
    /// <summary>
    ///
    /// ViewModel that will process data and events
    /// The ViewModel inherits from the ReactiveObject class. 
    /// This class  grants your classes access to the RaiseAndSetIfChanged helper function. 
    /// This conveniently wires up your properties to the INotifyPropertyChanged/IObservable 
    /// interfaces, so in one step you have a class that can be data bound AND observed using 
    /// Reactive Extensions.
    /// 
    /// In the constructor for the ViewModel we set up the conditions under which something 
    /// happens, i.e. when the OK button is clicked. An IObservable object is returned from 
    /// the WhenAny extension, which allows you to observe whenever one or more properties 
    /// on an object have changed. We then Subscribe to the events of the ReactiveCommand, 
    /// which will update the status message. Note that the ViewModel has no references to 
    /// any UI elements, which allows us to perform testing without worrying about the 
    /// particular UI technology used.
    /// 
    /// (From http://www.codeproject.com/Articles/801986/Using-ReactiveUI-for-WinForms-MVVM-Design#xx4876432xx
    ///  written by http://www.codeproject.com/Members/User-10914367)
    /// </summary>
    public class HomeViewModel : ReactiveUI.ReactiveObject
    {
        public HomeViewModel()
        {
            //Define conditions
            var okCmdObs = this.WhenAny(vm => vm.EnteredText,
            s => !string.IsNullOrWhiteSpace(s.Value));

            //Create conditions
            OKCmd = ReactiveCommand.Create(okCmdObs);

            //Update Status
            OKCmd.Subscribe(_ => Status = EnteredText + " is saved.");
        }

        string ModelString;
        public string EnteredText
        {
            get { return ModelString; }
            set { this.RaiseAndSetIfChanged(ref ModelString, value); }
        }

        string statusString = "";
        public string Status
        {
            get { return statusString; }
            set { this.RaiseAndSetIfChanged(ref statusString, value); }
        }

        public ReactiveCommand<object> OKCmd { get; private set; }


    }
}
