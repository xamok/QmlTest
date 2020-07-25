using System;
using System.Collections.Generic;
using System.Text;
using Qml.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Dynamic;

namespace testQML
{
    
    public class QmlType
    {
        private HttpClient _http = new HttpClient();
        /// <summary>
        /// Properties are exposed to Qml.
        /// </summary>
        [NotifySignal("stringPropertyChanged")] // For Qml binding/MVVM.
        public string StringProperty { get; set; }

        /// <summary>
        /// Async methods can be invoked with continuations happening on Qt's main thread.
        /// </summary>
        public async Task<string> TestAsync()
        {
            // On the UI thread
            var res = await _http.GetStringAsync("http://ifconfig.io");
            // On the UI thread
            return res;
        }

    }
}
