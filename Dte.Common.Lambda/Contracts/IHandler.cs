using System.Threading;
using System.Threading.Tasks;

namespace Dte.Common.Lambda.Contracts
{
    public interface IHandler<in TMessage, TResponse>
    {
        Task<TResponse> HandleAsync(TMessage source, CancellationToken cancellationToken = default);
    }
}