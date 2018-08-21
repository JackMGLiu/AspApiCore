using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreApi.Infrastructure.Core.Interface;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace AspCoreApi.Web.Models
{
    public interface ICoreService<out T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
        ILogger<T> Logger { get; }
        IFileProvider FileProvider { get; }
    }
}
