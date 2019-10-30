using System.Collections.Generic;
using System.Threading.Tasks;
using DataPersist;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReactValuesController : ControllerBase
    {
        private readonly DataContext context;

        public ReactValuesController(DataPersist.DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domain.Value>>> Get()
        {
            var values = await context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Value>> Get(int id)
        {
            var value = await context.Values.FindAsync(id);
            return value;
        }
    }
}