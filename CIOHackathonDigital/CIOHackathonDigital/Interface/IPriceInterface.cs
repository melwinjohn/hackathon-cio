using CIOHackathonDigital.Model;
using System.Threading.Tasks;

namespace CIOHackathonDigital.Interface
{
    public interface IPriceInterface
    {
        Task<PriceDetails> GetPointsForPrice(string value);
    }
}
