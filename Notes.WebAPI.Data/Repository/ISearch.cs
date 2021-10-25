using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.WebAPI.Data.Models;

namespace Notes.WebAPI.Data.Repository
{
    public interface ISearch<TEntity>
    {
        IEnumerable<TEntity> Search(string term);
    }
}
