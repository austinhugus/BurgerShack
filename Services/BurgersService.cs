using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;

namespace burgershack.Services

{
    public class BurgerService {
        private readonly BurgerRepository _repo;
        public BurgerService (BurgerRepository repo) {
            _repo = repo;
        }
        internal IEnumerable<Burger> Get () {
            return _repo.GetAll ();
        }
        internal Burger Get (int id) {
            Burger found = _repo.GetById (id);
            if (found == null) {
                throw new Exception ("Bad Burg Id");
            }
            return found;
        }

        internal Burger Create (Burger newBurger) {
            _repo.Create (newBurger);
            return newBurger;
        }
        internal Burger Edit (Burger editBurger) {
            Burger original = Get (editBurger.Id);
            original.Name = editBurger.Name.Length > 0 ? editBurger.Name : original.Name;
            original.Description = editBurger.Description.Length > 0 ? editBurger.Description : original.Description;
            original.Price = editBurger.Price > 0 ? editBurger.Price : original.Price;

            _repo.Edit (original);
            return original;
        }

        internal object GetById (string id) {
            throw new NotImplementedException ();
        }

        internal Burger Delete (int id) {
            Burger burgerToDelete = Get (id);
            _repo.Delete (burgerToDelete);
            return burgerToDelete;
        }
    }

}