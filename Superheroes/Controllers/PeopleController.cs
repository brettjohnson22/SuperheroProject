using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class PeopleController : Controller
    {
        ApplicationDbContext db;
        public PeopleController()
        {
            db = new ApplicationDbContext();
        }
        // GET: People
        public ActionResult Index()
        {
            return View(db.People);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            Person person = db.People.Where(p => p.Id == id).FirstOrDefault();
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            Person person = new Person();
            return View(person);
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            Person person = db.People.Where(p => p.Id == id).FirstOrDefault();
            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Person updatedPerson)
        {
            try
            {
                // TODO: Add update logic here
                Person personToUpdate;
                personToUpdate = db.People.Where(p => p.Id == id).FirstOrDefault();
                personToUpdate.superheroName = updatedPerson.superheroName;
                personToUpdate.alterEgo = updatedPerson.alterEgo;
                personToUpdate.primaryAbility = updatedPerson.alterEgo;
                personToUpdate.secondaryAbility = updatedPerson.secondaryAbility;
                personToUpdate.catchPhrase = updatedPerson.catchPhrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            Person person = db.People.Where(p => p.Id == id).FirstOrDefault();
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Person person)
        {
            try
            {
                
                // TODO: Add delete logic here
                person = db.People.Where(p => p.Id == id).FirstOrDefault();
                db.People.Remove(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
