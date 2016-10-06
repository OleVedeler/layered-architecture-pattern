using System;

namespace TheShop.Domain.Core.Interfaces
{
    public interface ILogger
    {
        void LogException(Exception ex);

        void LogWarning(string warningMessage);
    }
}
