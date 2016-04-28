using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Autoupdate_label
{
    public class times : INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private string UHRZEITEN;
        public string uhrzeiten
        {
            get
            {
                return this.UHRZEITEN;
            }
            set
            {
                if (this.UHRZEITEN != value)
                {
                    this.UHRZEITEN = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool HasErrors
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyname = "")
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
               
            }
        }
    }
}
