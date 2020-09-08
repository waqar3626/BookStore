
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waqar.BookStore.Data;
using Webgentle.BookStore.Models;

namespace Waqar.BookStore.Repository
{
    public class LanguageRepository
    {
        private readonly BookStoreContext _Context = null;

        public LanguageRepository(BookStoreContext context)
        {

            _Context = context;
        }

        public async Task<List<LanguageModel>> GetLanguages()
        {

            return await _Context.Languages.Select(x => new LanguageModel()
            {
                Id=x.Id,
                Name=x.Name,
                Description=x.Description

            }

            
            ).ToListAsync();
        
        }
        
    }
}
