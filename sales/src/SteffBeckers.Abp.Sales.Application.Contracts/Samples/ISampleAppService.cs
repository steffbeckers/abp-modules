﻿using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SteffBeckers.Abp.Sales.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
