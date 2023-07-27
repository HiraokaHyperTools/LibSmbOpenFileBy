using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSmbOpenFileBy
{
    public class OpenFileByResult
    {
        /// <summary>
        /// e.g. `C:\folder`, `C:\folder\file`, and so on
        /// </summary>
        public string Path { get; set; }

        public IEnumerable<OpenFileByResultUser> Users { get; set; }
    }
}
