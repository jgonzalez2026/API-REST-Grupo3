// RESPONSABLE: Integrante 2
// TODO: agregar [FirestoreProperty] a cada propiedad y los 11 campos:
//   Id (string), Email, DisplayName, Username, PhoneNumber (string),
//   BirthDate (DateTime, UTC), Country, Bio (string),
//   Role (string, por defecto Roles.Miembro), CreatedAt (DateTime, UTC), UserId (string)


// RESPONSABLE: Integrante 2 - Jesús Peña
using Google.Cloud.Firestore;

namespace DeportHub.Models;

[FirestoreData]
public class Miembro
{
    [FirestoreProperty] public string Id { get; set; } = string.Empty;
    [FirestoreProperty] public string Email { get; set; } = string.Empty;
    [FirestoreProperty] public string DisplayName { get; set; } = string.Empty;
    [FirestoreProperty] public string Username { get; set; } = string.Empty;
    [FirestoreProperty] public string PhoneNumber { get; set; } = string.Empty;
    [FirestoreProperty] public DateTime BirthDate { get; set; }
    [FirestoreProperty] public string Country { get; set; } = string.Empty;
    [FirestoreProperty] public string Bio { get; set; } = string.Empty;
    [FirestoreProperty] public string Role { get; set; } = Roles.Miembro;
    [FirestoreProperty] public DateTime CreatedAt { get; set; }
    [FirestoreProperty] public string UserId { get; set; } = string.Empty;
}
