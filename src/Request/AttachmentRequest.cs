using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpScoutNet.Request
{
    public class AttachmentRequest : FieldRequest
    {
        public string FileName { get; set; }

        public string MimeType { get; set; }

        public string Data { get; set; }

        public override NameValueCollection ToNameValueCollection()
        {
            base.ToNameValueCollection();
            if (!string.IsNullOrEmpty(FileName))
            {
                Nv.Add("fileName", FileName);
            }
            if (!string.IsNullOrEmpty(FileName))
            {
                Nv.Add("mimeType", MimeType);
            }
            if (!string.IsNullOrEmpty(FileName))
            {
                Nv.Add("Data", Data);
            }

            return Nv;
        }
    }
}
