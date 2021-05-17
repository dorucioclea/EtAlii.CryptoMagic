namespace EtAlii.BinanceMagic.Service
{
    using System.Threading;
    using System.Threading.Tasks;

    public class SimpleAlgorithmRunner : IAlgorithmRunner
    {
        public TradingBase Trading => _trading;
        private readonly SimpleTrading _trading;

        public SimpleAlgorithmRunner(SimpleTrading trading)
        {
            _trading = trading;
        }
        public void Run()
        {
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}