bool? desejaReceberEmails = null;

    //Verifica se tem um valor   |  Verifica se o valor é verdadeiro
if (desejaReceberEmails.HasValue && desejaReceberEmails.Value)
{
    Console.WriteLine("Vai receber");
}
else
{
    Console.WriteLine("O user não respondeu ou optou por não receber");
}