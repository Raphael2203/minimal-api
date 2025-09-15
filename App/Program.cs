using MinimalApi;

IHostBuilder CreatedHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    });
}

CreatedHostBuilder(args).Build().Run();