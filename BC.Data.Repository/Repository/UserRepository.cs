﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Data.Entity;

namespace BC.Data.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BcContext _context;

        public UserRepository(BcContext context)
        {
            this._context = context;
        }

        public IQueryable<User> All
        {
            get { return _context.Users.AsQueryable(); }
        }

        public User Find(int id)
        {
            return _context.Users.Find(id);
        }

        public void InsertOrUpdate(User item)
        {         
            if (item != null)
            {
                _context.Users.AddOrUpdate(item);
            }
            else
            {
                throw new NullReferenceException("Project is null");
            }
        }

        public void Delete(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id.Equals(id));

            if (user != null)
            {
                _context.Users.Remove(user);
            }
            else
            {
                throw new NullReferenceException("There is no such user");
            }
        }
    }
}
