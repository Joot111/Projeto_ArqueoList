using System;
using Microsoft.AspNetCore.Identity;
using Projeto_ArqueoList.Data;

namespace Aulas.Data
{

    internal class DbInitializer
    {

        internal static async void Initialize(ApplicationDbContext dbContext)
        {

            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
        }
    }
}