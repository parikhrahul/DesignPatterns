using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_VS_Interface
{
    internal class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private StreamWriter _writer;

        private Logger()
        {
            _writer = new StreamWriter("app.log", append: true);
        }

        public static Logger Instance
        {
            get
            {
                if( _instance == null )
                {
                    lock(_lock )
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }

                return _instance;
            }
        }

        public void Info( string message )
        {
            _writer.WriteLine($"Info : {DateTime.Now} : {message}");
            _writer.Flush();
        }

        public void Close()
        {
            _writer.Close();
        }

    }
}
