using Celulares.Models;

Iphone iphone = new Iphone("1001", "XR", "111111A", 64);

Nokia nokia = new Nokia("1032", "Modelo 1", "4154251A", 32);

Console.WriteLine("Smartphone Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

