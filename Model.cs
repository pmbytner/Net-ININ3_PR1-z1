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
        void OnPropertyChanged([CallerMemberName] string własnaNazwa = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(własnaNazwa));
        }

        internal void Resetuj()
        {
            Zeruj();
        }
        internal void Zeruj()
        {
            IO = "0";
            flagaPrzecinka = false;
            flagaUłamka = false;
        }
        internal void UsuńZnak()
        {
            if (buforIO.Length == 1 || buforIO == "0," || buforIO == "-0,")
                Zeruj();
            else
            {
                char usuwanyZnak = buforIO[^1];
                IO = buforIO.Substring(0, buforIO.Length - 1);
                flagaPrzecinka = false;
                if (buforIO[^1] == ',')
                {
                    flagaUłamka = false;
                    flagaPrzecinka = true;
                }
            }
        }
        internal void DopiszCyfrę(string cyfra)
        {
            if (buforIO == "0")
                buforIO = "";
            else if(flagaPrzecinka)
            {
                flagaUłamka = true;
                flagaPrzecinka = false;
            }
            IO += cyfra;
        }
        internal void ZmieńZnak()
        {
            if (buforIO == "0")
                return;
            if (buforIO[0] == '-')
                IO = buforIO.Substring(1);
            else
                IO = "-" + buforIO;
        }
        internal void Przecinek()
        {
            if (flagaUłamka)
                return;
            else if(flagaPrzecinka)
            {
                IO = buforIO.Substring(0, buforIO.Length - 1);
                flagaPrzecinka = false;
            }
            else
            {
                IO += ",";
                flagaPrzecinka = true;
            }
        }

        bool
            flagaPrzecinka = false,
            flagaUłamka = false
            ;
        string buforIO = "0";
        public string IO {
            get { return buforIO; }
            set
            {
                buforIO = value;
                OnPropertyChanged();
            }
        }
    }
}
