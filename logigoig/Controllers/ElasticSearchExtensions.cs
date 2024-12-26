using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;

public static class ElasticSearchExtensions
{
    public static IServiceCollection AddElasticSearch(this IServiceCollection services, string uri)
    {
        var settings = new ConnectionSettings(new Uri(uri))
            .DefaultIndex("user-logs");

        var client = new ElasticClient(settings);

        services.AddSingleton<IElasticClient>(client);

        return services;
    }
}