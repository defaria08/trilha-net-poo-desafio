using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smart Nokia");
Smartphone Nokia = new Nokia(numero: "12982108744", modelo: "A1200", imei: "23ODFUOSF932", memoria: 32);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smart Nokia");
Smartphone Iphone = new Nokia(numero: "12996548888", modelo: "S23FE", imei: "123IAIDSJI12", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");