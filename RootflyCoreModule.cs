using Rootfly.Mobile.Core.Common.Module;
using Rootfly.Mobile.Core.WhiteLabel.Module;
using Rootfly.Mobile.Core.Security.Module;
using Rootfly.Mobile.Core.Networking.Module;
using Rootfly.Mobile.Core.Storage.Module;
using Rootfly.Mobile.Core.Diagnostics.Module;
using Rootfly.Mobile.Core.Media.Module;
using Rootfly.Mobile.Core.Upload.Module;
using Rootfly.Mobile.Core.Offline.Module;
using Rootfly.Mobile.Core.Notifications.Module;
using Rootfly.Mobile.Core.UI.Module;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Rootfly.Mobile.Core;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RootflyCommonModule),
    typeof(RootflyWhiteLabelModule),
    typeof(RootflySecurityModule),
    typeof(RootflyNetworkingModule),
    typeof(RootflyStorageModule),
    typeof(RootflyDiagnosticsModule),
    typeof(RootflyMediaModule),
    typeof(RootflyUploadModule),
    typeof(RootflyOfflineModule),
    typeof(RootflyNotificationsModule),
    typeof(RootflyUIModule)
)]
public class RootflyCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
