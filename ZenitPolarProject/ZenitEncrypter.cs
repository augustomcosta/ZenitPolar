namespace ZenitPolarProject;

public class ZenitEncrypter
{
    public string? OriginalMessage { get; set; }
    public Dictionary<char, char> Substitutions = new Dictionary<char, char>();
    
    public ZenitEncrypter()
    {
        Substitutions['Z'] = 'P';
        Substitutions['E'] = 'O';
        Substitutions['N'] = 'L';
        Substitutions['I'] = 'A';
        Substitutions['T'] = 'R';
        Substitutions['P'] = 'Z';
        Substitutions['O'] = 'E';
        Substitutions['L'] = 'N';
        Substitutions['A'] = 'I';
        Substitutions['R'] = 'T';
        Substitutions['z'] = 'p';
        Substitutions['e'] = 'o';
        Substitutions['n'] = 'l';
        Substitutions['i'] = 'a';
        Substitutions['t'] = 'r';
        Substitutions['p'] = 'z';
        Substitutions['o'] = 'e';
        Substitutions['l'] = 'n';
        Substitutions['a'] = 'i';
        Substitutions['r'] = 't';
    }
    
    public string Encrypt(string originalMessage)
    {
        OriginalMessage = originalMessage;
        string encryptedMessage = "";
        
        foreach (char letter in originalMessage)
        {
            if (Substitutions.ContainsKey(letter))
            {
                encryptedMessage += Substitutions[letter];
            }
            else
            {
                encryptedMessage += letter;
            }
        }
        Console.WriteLine($"Mensagem criptografada: {encryptedMessage}");
        return encryptedMessage;
        
    }
}