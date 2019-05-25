using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait.Models
{
    public class DemoMethods
    {
        public string Content()
        {
            Thread.Sleep(3000);
            return "Synchronous Method";
        }

        public int Count()
        {
            Thread.Sleep(6000);
            return 10;
        }

        public string Name()
        {
            Thread.Sleep(4000);
            return "Faisal Pathan";
        }
        public async Task<string> ContentAsync()
        {
            await Task.Delay(3000);
            return "Asynchronous Method";
        }

        public async Task<int> CountAsync()
        {
            await Task.Delay(6000);
            return 10;
        }

        public async Task<string> NameAsync()
        {
            await Task.Delay(4000);
            return "Faisal Pathan";
        }
    }
}