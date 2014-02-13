using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvLogMail
{
    public enum configType {
        JSON = 0,
        XML = 1,
        INI = 2,
        CSV = 3,
        Registry = 4
    }

    public class config {
        string host, username, password, domain; //...

        public config(string path, configType type) { }
        public config(string[] conf) { }
        
    }

    public class notifier {
        public notifier(listener listener) { }
        void attach() { }
        void testMail() { }
        void getStats() { }

    }

    public class listener {
        public listener(config conf) { }
        void listen() { }
        void writeEvent() { }
        void findEvents() { }
        void stop() { }

    }
}
