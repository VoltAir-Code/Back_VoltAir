namespace VoltAir.Utils
{
    public static class Criptografia
    {
        public static string CreateHash(string passWord)
        {
            return BCrypt.Net.BCrypt.HashPassword(passWord);
        }

        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
