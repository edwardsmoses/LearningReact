using System;
using System.Threading;
using System.Threading.Tasks;
using DataPersist;
using Domain;
using MediatR;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly DataContext context;

            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                var Activity = await context.Activities.FindAsync(request.Id);
                return Activity;
            }
        }
    }
}