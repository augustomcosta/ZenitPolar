using ZenitPolarProject;

Console.WriteLine("## Zenit Polar Project ##\n");

while (true)
{
    var encrypt = new ZenitEncrypter();
    Console.WriteLine("Digite a mensagem a ser criptografada: (insira 999 para sair)\n");
    string? originalMessage = Console.ReadLine();
    
    if (originalMessage == "999")
    {
        break;
    }
    
    encrypt.Encrypt(originalMessage);
    
}



