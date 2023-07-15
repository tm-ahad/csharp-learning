
class Caeser_cipher {
    static string encode(string s, byte key)
    {
        string res = string.Empty;

        foreach (char c in s)
        {
            res += (char)(key + (byte)c);
        }

        return res;
    }

    static string decode(string s, byte key)
    {
        string res = string.Empty;

        foreach (char c in s)
        {
            res += (char)((byte)c - key);
        }

        return res;
    }

    static void Main()
    {
        string str = "Hi I'm TM Ahad";

        string encoded_str = encode(str, 5);
        string decoded_str = decode(encoded_str, 5);

        Console.WriteLine(encoded_str);
        Console.WriteLine(decoded_str);
    }
}