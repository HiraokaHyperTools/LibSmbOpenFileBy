using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LibSmbOpenFileBy
{
    public class SearchOpenFileByPath
    {
        /// <summary>
        /// Enumerate all `MSFT_SmbOpenFile` objects under `Root\Microsoft\Windows\SMB`
        /// </summary>
        /// <remarks>
        /// - This requires administrator privileges.
        /// </remarks>
        /// <exception cref="ManagementException">
        /// ```
        /// HResult	-2146233087	int
        /// ErrorCode	AccessDenied	System.Management.ManagementStatus
        /// Message	"アクセスは拒否されました "	string
        /// ```
        /// </exception>
        public IEnumerable<OpenFileByResult> EnumAll()
        {
            using (var managementClass = new ManagementClass(@"Root\Microsoft\Windows\SMB", "MSFT_SmbOpenFile", null))
            using (var managementObjectCollection = managementClass.GetInstances())
            {
                return managementObjectCollection
                    .Cast<ManagementObject>()
                    .Select(
                        one =>
                        {
                            return new OpenFileByResult
                            {
                                Path = one["Path"] + "",
                                Users = new OpenFileByResultUser[]
                                {
                                    new OpenFileByResultUser
                                    {
                                        Computer = one["ClientComputerName"] + "",
                                        User = one["ClientUserName"] + "",
                                    }
                                }
                            };
                        }
                    )
                    .ToArray();
            }
        }
    }
}
