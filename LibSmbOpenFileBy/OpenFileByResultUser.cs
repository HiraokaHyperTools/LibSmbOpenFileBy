using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSmbOpenFileBy
{
    public class OpenFileByResultUser
    {
        /// <summary>
        /// e.g. `[fe80::c057:dc56:526b:dabf]`, `127.0.0.1`, or such
        /// </summary>
        public string Computer { get; set; }

        /// <summary>
        /// e.g. `MicrosoftAccount\user@domain.com`, `Server\account`, or such
        /// </summary>
        public string User { get; set; }
    }
}
