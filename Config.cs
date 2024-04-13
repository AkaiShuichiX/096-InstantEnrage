using Exiled.API.Interfaces;

namespace Old096
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        public bool InstantRage { get; set; } = true;
    }
}