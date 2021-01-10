﻿using System.Threading;
using System.Threading.Tasks;
using Deployer.Core.Requirements.Disk;
using MediatR;

namespace Deployer.Core.Requirements
{
    // ReSharper disable once UnusedType.Global
    public class DiskHandler : IRequestHandler<DiskRequest, RequirementResponse>
    {
        public Task<RequirementResponse> Handle(DiskRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new RequirementResponse(new[]
            {
                new FulfilledRequirement(request.Key, request.Index),
            }));
        }
    }
}