using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDoom.Models
{
    class DProcess
    {
        // Process name
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        // Process folder path
        private string location;
        public string Location
        {
            get => location;
            set => location = value;
        }

        // Process description
        private string description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        public DProcess(string Name, string Path)
        {
            name = Name;
            location = Path;
            description = "";
        }

        public DProcess(string Name, string Path, string Description)
        {
            name = Name;
            location = Path;
            description = Description;
        }
    }
}
