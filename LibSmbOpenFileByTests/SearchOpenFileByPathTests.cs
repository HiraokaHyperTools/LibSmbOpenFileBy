using LibSmbOpenFileBy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSmbOpenFileByTests
{
    public class SearchOpenFileByPathTests
    {
        [Test]
        public void EnumAll()
        {
            var items = new SearchOpenFileByPath().EnumAll();
            Console.WriteLine(
                string.Join(
                    "\n",
                    items
                        .Select(it => $"{it.Path}\t{string.Join("\t", it.Users.Select(one => $"{one.Computer}!{one.User}"))}")
                )
            );
        }
    }
}
