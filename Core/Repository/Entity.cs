﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository;

public abstract class Entity
{
}

public abstract class Entity<TId> : Entity
{
    public TId Id { get; set; }
}
