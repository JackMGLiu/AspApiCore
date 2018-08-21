using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreApi.Infrastructure.Core.Interface;
using AutoMapper;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace AspCoreApi.Web.Models
{
    public class CoreService<T> : ICoreService<T>
    {
        public IUnitOfWork UnitOfWork { get; }
        public ILogger<T> Logger { get; }
        public IMapper Mapper { get; }

        public IFileProvider FileProvider => throw new NotImplementedException();

        public CoreService(
            IUnitOfWork unitOfWork,
            ILogger<T> logger,
            IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Logger = logger;
            Mapper = mapper;
        }

        public virtual void Dispose()
        {
            UnitOfWork?.Dispose();
        }
    }
}
