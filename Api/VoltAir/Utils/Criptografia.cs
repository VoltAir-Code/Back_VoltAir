namespace VoltAir.Utils
{
    public static class Criptografia
    {
        public static string CreateHash(string passWord)
        {
            return BCrypt.Net.BCrypt.HashPassword(passWord);
        }

        public static bool ComparareHash(string formPassWord, string DbPassWord)
        {
            return BCrypt.Net.BCrypt.Verify(formPassWord, DbPassWord);
        }
    }
}
