using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameday
{
    public class MainPageData : INotifyPropertyChanged        
    {
        private string _greeting = "Hello world";

        public string Greeting
        {
            get { return _greeting; }
            set {
                if (value == _greeting)
                    return;

                _greeting = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Greeting)));
            }

        }

        public List<NameDayModel> Namedays { get; set; }

        public MainPageData()
        {
            Namedays = new List<NameDayModel>();

            for (int month = 1; month <= 12; month++)
            {
                Namedays.Add(new NameDayModel(
                    month, 1, new string[] { "Adam" }));

                Namedays.Add(new NameDayModel(
                    month, 24, new string[] { "Eve", "Andrew" }));
            }
        }

        private NameDayModel _selectedNameday;

        public event PropertyChangedEventHandler PropertyChanged;

        public NameDayModel SelectedNameday
        {
            get { return _selectedNameday; }
            set {
                _selectedNameday = value;

                if (value == null)
                    Greeting = "Hellow World!";
                else
                    Greeting = "Hello" + value.NameAsString;
            }
        }

    }
}
