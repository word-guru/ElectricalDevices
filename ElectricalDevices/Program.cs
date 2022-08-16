using ElectricalDevices.Repozitorys.Interface;
using ElectricalDevices.Repozitorys;
using Autofac;

var builder = new ContainerBuilder();
builder.RegisterType<Repozitory>().As<IRepozitory>();
builder.RegisterType<DeviceRepo>().As<IDeviceRepo>();
var container = builder.Build();

using (var scope = container.BeginLifetimeScope())
{
    var device = scope.Resolve<IDeviceRepo>();

    device.Display();
    device.Save();
}