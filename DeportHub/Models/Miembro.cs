// RESPONSABLE: Integrante 2
// TODO: agregar [FirestoreProperty] a cada propiedad y los 11 campos:
//   Id (string), Email, DisplayName, Username, PhoneNumber (string),
//   BirthDate (DateTime, UTC), Country, Bio (string),
//   Role (string, por defecto Roles.Miembro), CreatedAt (DateTime, UTC), UserId (string)
using Google.Cloud.Firestore;

namespace DeportHub.Models;

[FirestoreData]
public class Miembro
{
    [FirestoreProperty] public string Id { get; set; } = string.Empty;
    [FirestoreProperty] public string Role { get; set; } = Roles.Miembro;
    // TODO (Integrante 2): resto de campos
}
