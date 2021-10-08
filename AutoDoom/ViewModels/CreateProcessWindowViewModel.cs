using AutoDoom.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Prism.Commands;

namespace AutoDoom.ViewModels
{
    class CreateProcessWindowViewModel: BindableBase
    {
        private DProcess process = new("BlankProcess", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        public DProcess Process
        {
            get => process;
            set => process = value;
        }

        // Create button enabled
        private bool createButtonEnabled = true;
        public bool CreateButtonEnabled
        {
            get => createButtonEnabled;
            set
            {
                SetProperty(ref createButtonEnabled, value);
                RaisePropertyChanged(nameof(CreateButtonEnabled));
            }
        }

        private bool NameReady = true;
        private bool LocationReady = true;

        public DelegateCommand<string> NameTextChangeCommand { get; private set; }
        private void NameTextChange(string text)
        {
            NameReady = text != "";

            CreateButtonEnabled = NameReady && LocationReady;
            process.Name = text;
        }

        public DelegateCommand<string> LocationTextChangeCommand { get; private set; }
        private void LocationTextChange(string text)
        {
            LocationReady = text != "";

            CreateButtonEnabled = NameReady && LocationReady;
            process.Name = text;
        }

        public DelegateCommand<string> DescriptionTextChangeCommand { get; private set; }
        private void DescriptionTextChange(string text)
        {
            process.Description = text;
        }

        public DelegateCommand CreateProcessCommand { get; private set; }
        private void CreateProcess()
        {

        }

        public CreateProcessWindowViewModel()
        {
            NameTextChangeCommand = new DelegateCommand<string>(NameTextChange);
            LocationTextChangeCommand = new DelegateCommand<string>(LocationTextChange);
            DescriptionTextChangeCommand = new DelegateCommand<string>(DescriptionTextChange);
            CreateProcessCommand = new DelegateCommand(CreateProcess);
        }
    }
}
