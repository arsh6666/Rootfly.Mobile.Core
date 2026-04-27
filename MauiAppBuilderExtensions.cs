using Autofac;
using Autofac.Extensions.DependencyInjection;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Rootfly.Mobile.Core.WhiteLabel.Config;
using Rootfly.Mobile.Core.WhiteLabel.Providers;
using Rootfly.Mobile.Core.WhiteLabel.Theme;
using Volo.Abp;
using Volo.Abp.Autofac;

namespace Rootfly.Mobile.Core;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseRootfly<TAppModule>(
        this MauiAppBuilder builder,
        Action<RootflyOptions>? configure = null)
        where TAppModule : Volo.Abp.Modularity.AbpModule
    {
        var options = new RootflyOptions();
        configure?.Invoke(options);

        builder.ConfigureContainer(new AutofacServiceProviderFactory(containerBuilder =>
        {
            // Register client config provider with the profile
            containerBuilder.RegisterInstance(new JsonClientConfigProvider(options.ClientConfigResourceName))
                .As<IClientConfigProvider>()
                .SingleInstance();
        }));

        builder.Services.AddApplication<TAppModule>();

        return builder;
    }
}

public class RootflyOptions
{
    public string ClientProfile { get; set; } = "default";
    public string ClientConfigResourceName { get; set; } = "client.json";
    public string ThemeConfigResourceName { get; set; } = "colors.json";
}
