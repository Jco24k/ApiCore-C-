using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using LibreriaBackEnd.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibreriaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly LibreriaContext db;

        public ClienteController(LibreriaContext obj)
        {
            db = obj;
        }

        [HttpGet("cliente/{dni}")]
        public Cliente GETCLIENTE_DNI(string dni)
        {
            var cli = db.Clientes.Where(c => c.Dni == dni).FirstOrDefault();
            return cli;
        }

        [HttpGet("cliente")]
        public List<Cliente> GETCLIENTE()
        {
            return db.Clientes.ToList();
        }

        [HttpGet("ListarProductoCliente/{dni}")]
        public List<PA_PRODUCTO_CLIENTE> LISTAR_PAGOS_SEMESTRE(string dni)
        {
            var listado = db.PA_PRODUCTO_CLIENTE
                            .FromSqlRaw<PA_PRODUCTO_CLIENTE>("PA_PRODUCTO_CLIENTE {0}",dni)
                            .ToList();

            return listado;
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
