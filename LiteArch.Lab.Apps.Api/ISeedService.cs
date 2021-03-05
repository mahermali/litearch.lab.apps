using System.Threading.Tasks;

namespace LiteArch.Lab.Apps.Api
{
    public interface ISeedService
    {
        Task Seed(string key);
    }
}