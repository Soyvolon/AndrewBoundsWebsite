using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CardGameData;

using Microsoft.Extensions.DependencyInjection;

using WebsiteMain.Database;

namespace WebsiteMain.Data
{
    public class CardGameService
    {
        private readonly IServiceProvider _services;
        public CardGame CurrentGame { get; private set; }
        public CardGuess LastGuess { get; private set; }

        public CardGameService(IServiceProvider serviceProvider)
        {
            _services = serviceProvider;
            BuildInitalDataTree();
        }

        private async void BuildInitalDataTree()
        {
            var database = _services.GetRequiredService<AndrewBoundsDatabaseModel>();

            var currentGame = database.CardGames.Where(x => x.EndDate == null);

        }


    }
}
