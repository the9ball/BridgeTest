using System;
using System.Threading.Tasks;

namespace BridgeTest
{
    public static class Class1
    {
        public static Action<string> Log;

        public static async Task RunA()
        {
            await Task.Delay(1000);
            Log?.Invoke("A.A");
            await Task.Delay(1000);
            Log?.Invoke("A.B");
        }

        public static async Task<int> RunB()
        {
            await Task.Delay(1000);
            Log?.Invoke("B.A");
            await Task.Delay(1000);
            Log?.Invoke("B.B");
            await Task.Delay(1000);
            return 12345;
        }
    }
}
