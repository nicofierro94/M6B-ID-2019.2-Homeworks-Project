﻿using System;
using Microsoft.EntityFrameworkCore;
using Homeworks.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Homeworks.DataAccess
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext context)
        {
            Context = context;
        }
        public override User Get(Guid id)
        {
            return Context.Set<User>().First(x => x.Id == id);
        }
        public override IEnumerable<User> GetAll()
        {
            return Context.Set<User>().ToList();
        }
    }
}
