using ConsoleApp.Modelos;

Compromisso compromisso = new();

Console.WriteLine("Vamos registrar um compromisso");

Console.Write("Digite a data do compromisso (dd/MM/aaaa): ");
while (true)
{
    try
    {
        compromisso.Data = Console.ReadLine();
        break;
    }
    catch (Exception e)
    {
        Console.Write($"Erro: {e.Message}\nDigite novamente: ");
    }
}

Console.Write("Digite a hora do compromisso (HH:mm): ");
TimeSpan horaCompromisso;
while (true)
{
    string horaDigitada = Console.ReadLine();
    
    if (TimeSpan.TryParseExact(horaDigitada, "hh\\:mm", 
        System.Globalization.CultureInfo.InvariantCulture, out horaCompromisso) &&
        horaCompromisso >= TimeSpan.Zero && 
        horaCompromisso < TimeSpan.FromHours(24))
    {
        compromisso.Hora = horaCompromisso;
        break;
    }
    Console.Write("Hora inválida (formato HH:mm entre 00:00 e 23:59). Digite novamente: ");
}

Console.WriteLine("\nCompromisso registrado:");
Console.WriteLine($"Data: {compromisso.Data}");
Console.WriteLine($"Hora: {compromisso.Hora.ToString(@"hh\:mm")}");
// Console.Write("Digite a hora do compromisso (HH:mm): ");
// var horaDigitada = Console.ReadLine();

// TimeSpan horaCompromisso;

// while(!TimeSpan.TryParse(horaDigitada, out horaCompromisso)) {
//     Console.WriteLine("HORA INVÁLIDA. \nDigite a hora do compromisso (HH:mm): ");
//     horaDigitada = Console.ReadLine();
// }

// Console.Write("Digite a DESCRIÇÃO para o compromisso: ");
// var descricao = Console.ReadLine();

// Console.Write("Digite o LOCAL para o compromisso: ");
// var local = Console.ReadLine();

// DateTime dataEHoraParaCompromisso = dataCompromisso.Add(horaCompromisso); 

// Console.WriteLine("Data: " + dataCompromisso.Date.ToShortDateString());
// Console.WriteLine($"Hora: {horaCompromisso}");
// Console.WriteLine($"Descrição: {descricao}");
// Console.WriteLine($"Local: {local}");

// Console.WriteLine($"Data e Hora: {dataEHoraParaCompromisso}");


// // Compromisso compromisso = new Compromisso();
// // var compromisso = new Compromisso();



// // Compromisso compromisso = new();
// // compromisso.Data = DateTime.Now.Date;
// // Console.WriteLine(compromisso.Data);
// // Console.WriteLine(compromisso.DataBR());

// // compromisso.RegistrarData(DateTime.Now.Date);

// // Console.Write(compromisso.ObterData());

