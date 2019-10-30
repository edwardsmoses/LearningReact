using System;
using System.Threading;
using System.Threading.Tasks;
using DataPersist;
using MediatR;

namespace Application.Activities
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext context;

            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                //handler logic goes here
                var activity = await context.Activities.FindAsync(request.Id);
                if (activity == null)
                    throw new Exception("Activity couldn't be found");

                context.Activities.Remove(activity);

                var success = await context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving Activities");
            }
        }

    }
}