using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourcesConverter {

    public delegate void LoggerCallback(string level, string line);
    public sealed class Logger {
        private static Logger instance = null;
        private static readonly object padlock = new object();

        public LoggerCallback callback { get; set; }


        Logger() {
        }

        public static Logger Instance {
            get {
                lock (padlock) {
                    if (instance == null) {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void error(string from, string msg) {
            callback("ERROR", $"{from}: {msg}\n");
        }
        public void success(string from, string msg) {
            callback("SUCCESS", $"{from}: {msg}\n");
        }
        public void status(string from, string msg) {
            callback("STATUS", $"{from}: {msg}\n");
        }
        public void info(string from, string msg) {
            callback("INFO", $"{from}: {msg}\n");
        }
        public void warning(string from, string msg) {
            callback("WARNING", $"{from}: {msg}\n");
        }
    }
}
