using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CryptoHelpers
{
    /// <summary>
    /// Types of X509 files along with the extension used
    /// </summary>
    public class X509FileFlavor
    {
        /// <summary>
        /// Friendly name.
        /// </summary>
        public string Name { get; set; }

        public X509ContentType ContentType { get; set; }

        public string ExtensionName { get; set; }

        public string Comments { get; set; }

        /// <summary>
        /// Some content requires passwords
        /// </summary>
        public bool  RequiresPassword { get; set; }

        public X509FileFlavor(string name, X509ContentType contentType, string ext, string comments, bool requiresPassword)
        {
            this.Name = name;
            this.ContentType = contentType;
            this.ExtensionName = ext;
            this.Comments = comments;
            this.RequiresPassword = requiresPassword;
        }
    }
}
