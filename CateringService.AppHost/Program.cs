/*var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.CateringService_ApiService>("apiservice");

builder.AddProject<Projects.CateringService_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
*/


using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiGateway = builder.AddProject<CateringService_ApiService>("apigateway");
var ordersService = builder.AddProject<OrdersService>("orders");
var inventoryService = builder.AddProject<InventoryService>("inventory");
var paymentService = builder.AddProject<PaymentService>("payments");
var notificationService = builder.AddProject<NotificationService>("notifications");
var userService = builder.AddProject<UserService>("users");

builder.Build().Run();
