using FastReaderApp.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfManagerApp1.ViewModel.Base;

namespace FastReaderApp.ViewModels
{
    class MainWindowVM : ViewModelBase
    {
        TextProvider TextProvider { get; set; }
        public string Title
        {
            get => "Reader";
        }
        private string currentWord;
        public string CurrentWord
        {
            get => currentWord;
            set => Set(ref currentWord, value);
        }

        void Increase()
        {
            CurrentWord = TextProvider.textArr[TextProvider.index];
        }
        public MainWindowVM()
        {
            TextProvider = new TextProvider();
            TextProvider.IndexChanged += Increase;
        }
    }
}
