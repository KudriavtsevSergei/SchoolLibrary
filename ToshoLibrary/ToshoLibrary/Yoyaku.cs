using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ToshoLibrary
{
    public class Yoyaku
    {
       public int YoyakuNo {  get; set; }
       public string Isbn {  get; set; }
        public string GakuNo {  set; get; }
        public DateTime YoyakuDate { get; set; }
        public string Title {  get; set; }
        public string GakuName {  set; get; }
        public string MailAddres {  get; set; }
    }
}
