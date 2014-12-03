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
            var okCmdObs = this.WhenAny(vm => vm.EnteredText,
                s => !string.IsNullOrWhiteSpace(s.Value));


            //var OKCmdObs = this.WhenAny(vm => vm.EnteredText,
            //    s => (s.Value == "123"));

			OKCmd = ReactiveCommand.Create(okCmdObs);
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
