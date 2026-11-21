// RESPONSABLE: Integrante 1
// Este archivo ya registra TODOS los servicios, para que los demas integrantes
// no tengan que editarlo (evita conflictos de merge).

using DeportHub.Services;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var projectId = builder.Configuration["Firebase:ProjectId"]
    ?? throw new InvalidOperationException("Falta Firebase:ProjectId en la configuracion.");
var credentialsPath = builder.Configuration["Firebase:CredentialsPath"] ?? "firebase-credentials.json";

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddHttpClient();

// Firestore (se crea la primera vez que un servicio lo necesita).
// TODO (Integrante 1): verificar que funcione con el firebase-credentials.json local.
builder.Services.AddSingleton(_ => new FirestoreDbBuilder
{
    ProjectId = projectId,
    CredentialsPath = credentialsPath
}.Build());

// Validacion del JWT (idToken) emitido por Firebase Authentication.
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = $"https://securetoken.google.com/{projectId}";
        options.MapInboundClaims = false; // conserva los claims originales: "user_id", "sub"
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = $"https://securetoken.google.com/{projectId}",
            ValidateAudience = true,
            ValidAudience = projectId,
            ValidateLifetime = true
        };
    });
builder.Services.AddAuthorization();

// Servicios de negocio
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IMiembroService, MiembroService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthentication(); // siempre ANTES de UseAuthorization
app.UseAuthorization();

app.MapControllers();

app.Run();
