using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
    // REALIZADO!!!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia1 = new Nokia(numero: "12545852", modelo: "1101", IMEI2: "215215", memoria: 126);
nokia1.Ligar();
nokia1.InstalarAplicativo("Instagram");
nokia1.ReceberLigacao();

Console.WriteLine("Smartphone iPHONE:");
Smartphone iphone1 = new Iphone(numero: "248562", modelo: "XR", IMEI2: "36589", memoria: 256);
iphone1.Ligar();
iphone1.InstalarAplicativo("Telegram");
iphone1.ReceberLigacao();