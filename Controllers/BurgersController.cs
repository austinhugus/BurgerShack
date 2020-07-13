using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class BurgersController : ControllerBase {
        private readonly BurgerService _service;

        public BurgersController (BurgerService service) //Dependency Injection
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burger>> GetAll () //<> - Of type, IEnumerable - list
        {
            try {
                return Ok (_service.Get ());
            } catch (Exception e) {
                return BadRequest (e.Message);
            }
        }

        [HttpGet ("{id}")]
        public ActionResult<Burger> Get (string id) {
            try {
                return Ok (_service.GetById (id));
            } catch (Exception e) {
                return BadRequest (e);
            }
        }

        [HttpPost]
        public ActionResult<Burger> Create ([FromBody] Burger newBurger) // req.body
        {
            try {
                return Ok (_service.Create (newBurger));
            } catch (Exception e) {
                return BadRequest (e.Message);
            }
        }

        [HttpPut ("{id}")]
        public ActionResult<Burger> Edit ([FromBody] Burger editBurger, int id) // req.params.id
        {
            try {
                editBurger.Id = id;
                return Ok (_service.Edit (editBurger));
            } catch (Exception e) {
                return BadRequest (e.Message);
            }
        }

        [HttpDelete ("{Id}")]
        public ActionResult<Burger> Delete (int id) // req.params.id
        {
            try {
                return Ok (_service.Delete (id));
            } catch (Exception e) {
                return BadRequest (e.Message);
            }
        }

    }
}