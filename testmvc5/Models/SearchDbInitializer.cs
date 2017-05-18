using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testmvc5.Models
{
    public class SearchDbInitializer : DropCreateDatabaseAlways<SearchDbContext>
    {
        protected override void Seed(SearchDbContext context)
        {
            context.Persons.Add(new Person { Family="Вейдер", Name = "Дарт"});
            context.Persons.Add(new Person { Family = "Принцесса", Name = "Лея" });
            base.Seed(context);
        }
    }
}