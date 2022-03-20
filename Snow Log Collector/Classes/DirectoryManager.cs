using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLogCollector.Classes
{
    class DirectoryManager
    {

        private string _root;

        public string Root
        {
            get { return _root; }
            set { _root = value; }
        }

        private string _data;

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _export;

        public string Export
        {
            get { return _export; }
            set { _export = value; }
        }

        private string _resource;

        public string Resource
        {
            get { return _resource; }
            set { _resource = value; }
        }

        private string _logs;

        public string Logs
        {
            get { return _logs; }
            set { _logs = value; }
        }


        public DirectoryManager(string rootDirectory)
        {
            _root = rootDirectory;
        }

        public void CreateDirectories()
        {
            // Define our paths, probably not the best way
            // of doing this but, i don't have code reviewers lol
            _data = _root + @"Data\";
            _resource = _root + @"Resources\";
            _logs = _root + @"Logs\";
            _export = _data + @"Exports\";

            // Create our root directory first in
            // AppData (%AppData%\Goosetuv\Snow Log Collector\)
            Directory.CreateDirectory(_root);

            // Make sure the root directory exists
            // then create the child directories
            if (Directory.Exists(_root))
            {
                Directory.CreateDirectory(_data);
                Directory.CreateDirectory(_resource);
                Directory.CreateDirectory(_logs);
                Directory.CreateDirectory(_export);
            }
        }

    }
}
