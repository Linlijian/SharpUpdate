using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SharpUpdate
{
    internal enum HashType
    {
        MD5,
        SHA1,
        SHA512
    }
    internal static class Hasher
    {
       internal static string Hashfile(string filePath, HashType algo)
        {
            switch (algo)
            {
                case HashType.MD5:
                    return MakehashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA1:
                    return MakehashString(SHA1.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                case HashType.SHA512:
                    return MakehashString(SHA512.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
                default:
                    return "";
            }
        }

        private static string MakehashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
                s.Append(b.ToString("x2").ToLower());

            return s.ToString();
        }
    }
}
