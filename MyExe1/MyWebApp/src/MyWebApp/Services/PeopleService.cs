using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;
using Microsoft.Data.Entity;

namespace MyWebApp.Services
{
    public interface IPeopleService
    {
        Task<List<Person>> GetAllPeople();
        Task<Person> GetSingle(int? id);
        void Edit(Person person);
        void Create(Person person);
        void Delete(Person person);

    }
    public class PeopleService : IPeopleService
    {
        private PeopleContext _context;

        public PeopleService(PeopleContext context)
        {
            _context = context;
        }

        public void Create(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public void Edit(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
        }

        public void Delete(Person person)
        {
            _context.Person.Remove(person);
            _context.SaveChanges();
        }

        public async Task<List<Person>> GetAllPeople()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetSingle(int? id)
        {
            return await _context.Person.SingleAsync(m => m.Id == id);
        }
    }
}
