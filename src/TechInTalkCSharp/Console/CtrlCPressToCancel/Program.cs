namespace CtrlCPressToCancel
{
    internal class Program
    {
        static bool termicated = false;
        static CancellationTokenSource cts = new CancellationTokenSource();
        
        public static async Task Main(string[] args)
        {
            Console.CancelKeyPress += new
                ConsoleCancelEventHandler(Console_CancelKeyPress);

            while (!termicated)
            {
                await MainAsync(cts.Token);
            }
        }

        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Press Y or y to exit, any other key to continue!");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'Y' || key.KeyChar == 'y')
            {
                // We'll stop the process manually by using the CancellationToken
                e.Cancel = true;

                // Change the state of the CancellationToken to "Canceled"
                // - Set the IsCancellationRequested property to true
                // - Call the registered callbacks
                cts.Cancel();
                termicated = true;
            }
        }

            private static async Task MainAsync(CancellationToken cancellationToken)
        {
            try
            {
                Console.WriteLine("Waiting");

                // milliseconds delay
                int milliseconds = 1000_00;

                await Task.Delay(milliseconds, cancellationToken);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation canceled");
            }
        }
    }
}