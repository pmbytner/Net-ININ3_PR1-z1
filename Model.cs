using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Net_ININ3_PR1_z1
{
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        /*Kluczami są właściwości z seterem, wartościami właściwości z samym geterem*/
        readonly static Dictionary<string, string[]> PowiązaneWłaściwości = new()
        {
            ["Imię"] = new string[]{ "Format" }
        };
        void OnPropertyChanged([CallerMemberName] string własnaNazwa = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(własnaNazwa));
            foreach(string nazwaWłaściwościPowiązanej in PowiązaneWłaściwości[własnaNazwa])
                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nazwaWłaściwościPowiązanej)
                    );
        }

        string imię = "Nemo";
        public string Imię {
            get { return imię; }
            set
            {
                imię = value;
                OnPropertyChanged();
                /*OnPropertyChanged("Format")*/
            }
        }
        public string Format
        {
            get { return $"Podane imię to {Imię}."; }
        }
    }
}
