using System;
using System.IO;
using System.Threading.Tasks;

namespace CSharpAsync {
    class Program {
        private static async Task Main (string[] args) {
            string contents = await ReadTestFile();
            Console.WriteLine(contents);
        }

        public static async Task<string> ReadTestFile () {
            string fileData = await File.ReadAllTextAsync("../../../Test.txt");
            return fileData;
        }
    }
}
