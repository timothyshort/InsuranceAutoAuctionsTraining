using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Test Project #6 - NUnit Test Attributes
 * Use TestCase to Parameterize a single set
 * Use Test, TestCaseSource to Parameterize a set of data
 * Create the static object[] DataProvider to pass set of data
 */

namespace TestingProject01
{
    class Test06
    {
        [TestCase("rob","tom","kelly")]
        public void TestwithTestCase(string name1, string name2, string name3)
        {
            Console.Write(name1);
            Console.Write(name2);
            Console.Write(name3);
        }

        [Test, TestCaseSource("DataProvider")]
        public void TestwithTestCaseSource(string user, string email, int num)
        {
            Console.Write(user);
            Console.Write(email);
            Console.Write(num);
        }

        static object[] DataProvider =
        {
            new object[] { "User1", "a2@testemail.com", 4 },
            new object[] { "User2", "b5@testemail.com", 10 },
            new object[] { "User3", "c6@testemail.com", 420 },
        };
    }
}
