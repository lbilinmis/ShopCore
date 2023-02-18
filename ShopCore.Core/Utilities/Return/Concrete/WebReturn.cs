using ShopCore.Core.Utilities.Return.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.Utilities.Return.Concrete
{
    [Serializable()]
    public class WebReturn
    {

        public WebReturn()
        {
            this.Retcode = EN_Retcode.Null;
            this.RedirectUrl = "-";
            this.PostUrl = "-";
            this.PostData = new List<string>();
            this.Message = "-";
            this.Message_SignalR = "-";
        }

        public EN_Retcode Retcode { get; set; }
        public string RedirectUrl { get; set; }
        public string PostUrl { get; set; }
        public List<string> PostData { get; set; }
        public string Message { get; set; }
        public string Message_SignalR { get; set; }
        public bool CloseWindow { get; set; }
        public bool ReloadWindow { get; set; }
        public string OpenerButton { get; set; }
        public string PageButton { get; set; }
        public object Data { get; set; }
        public object Tag { get; set; }
    }
}
