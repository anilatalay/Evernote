﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Evernote.DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();

        List<T> List(Expression<Func<T, bool>> where);

        int Insert(T obj);

        int Save();

        int Update(T obj);

        int Delete(T obj);

        T Find(Expression<Func<T, bool>> where);
    }
}
