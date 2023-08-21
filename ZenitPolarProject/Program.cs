using ZenitPolarProject;
using ZenitPolarProject.Interfaces;

Console.WriteLine("## Zenit Polar Project ##\n");

while (true)
{
    IEncrypter encrypter = new ZenitEncrypter();
    Console.WriteLine("Digite a mensagem a ser criptografada: (insira 999 para sair)\n");
    string? originalMessage = Console.ReadLine();
    
    if (originalMessage == "999")
    {
        break;
    }
    encrypter.Encrypt(originalMessage);
}



