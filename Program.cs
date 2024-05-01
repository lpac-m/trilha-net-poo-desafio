using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - FEITO
Iphone cel1 = new Iphone("99877474","Iphone7","22222222",128);
Console.WriteLine(cel1.Numero);
cel1.Ligar();
cel1.InstalarAplicativo("Telegram");

Nokia cel2 = new Nokia("988475632","N500","55555555",256);
Console.WriteLine(cel2.Numero);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Instagram");