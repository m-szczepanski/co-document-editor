using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var userService = builder.AddProject<UserService>("user-service");
var editorService = builder.AddProject<EditorService>("editor-service");
var realTimeService = builder.AddProject<Real_timeService>("rt-service");

builder.Build().Run();