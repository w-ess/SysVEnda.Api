using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysVenda.Domain.Entidades;

namespace SysVenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusMesasController : ControllerBase
    {
        // GET: api/StatusMesas
        [HttpGet]
        public IEnumerable<StatusMesa> GetStatusMesas()
        {
            return new StatusMesa().GetStatusMesas();            
        }

    }
}
