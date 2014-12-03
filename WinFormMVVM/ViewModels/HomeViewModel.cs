using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WinFormMVVM.ViewModels
{
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
		    OKCmd.Subscribe(_=> Status = EnteredText + " is saved.");
		}

		string ModelString;
		public string EnteredText
		{
			get { return ModelString; }
			set { this.RaiseAndSetIfChanged( ref ModelString, value);}
		}

		string statusString = "";
		public string Status
		{
			get{return statusString;}
			set{this.RaiseAndSetIfChanged(ref statusString,value);}
		}

		public ReactiveCommand<object> OKCmd { get; private set; }

		
	}
}
