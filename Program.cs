using BlazorUsersJsonPlaceHolderApi.Components;
using BlazorUsersJsonPlaceHolderApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registra o HttpClient apontando para a API JsonPlaceHolder
builder.Services.AddHttpClient<UserService>(client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
});

var app = builder.Build();

// Ao iniciar, busca a primeira pessoa da API e imprime no console
using (var scope = app.Services.CreateScope())
{
    var userService = scope.ServiceProvider.GetRequiredService<UserService>();

    try
    {
        var firstUser = await userService.GetFirstUserAsync();

        if (firstUser != null)
        {
            UserService.PrintUser(firstUser);
        }
        else
        {
            Console.WriteLine("Nenhum usuário retornado pela API.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao consumir a API: {ex.Message}");
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
