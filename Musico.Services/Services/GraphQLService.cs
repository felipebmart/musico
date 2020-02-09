﻿namespace Musico.Services.Services
{
    using GraphQL.Types;
    using Musico.DataContext.Queries;

    public class GraphQLService
        : IGraphQLService
    {
        public IObjectGraphType GetArtistQuery()
        {
            return new ArtistQuery();
        }
    }
}