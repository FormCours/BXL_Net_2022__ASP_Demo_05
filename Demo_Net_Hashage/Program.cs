using Isopoh.Cryptography.Argon2;
using System.Text;

Console.WriteLine("Demo Hash avec Argon2i");
Console.WriteLine();
// Installer le nugget package : Isopoh.Cryptography.Argon2

Console.WriteLine("Entrer un mot de passe : ");
string pwd = Console.ReadLine();

// Hashage du mot de passe via Argon2i
string hash1 = Argon2.Hash(pwd);
Console.WriteLine(hash1);

string hash2 = Argon2.Hash(pwd);
Console.WriteLine(hash2);

Console.WriteLine("Longeur du Hash");
Console.WriteLine(hash1.Length);

Console.WriteLine("Entrer un mot de passe à valider : ");
string check = Console.ReadLine();
bool test = Argon2.Verify(hash1, check);
Console.WriteLine(test ? "Pwd OK" : "Boum :o");