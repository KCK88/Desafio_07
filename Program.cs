// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.Builder.Internal;
using MySqlConnector;

Console.WriteLine("Hello, World!");

var builder = ApplicationBuilder.



var connection =
    new MySqlConnection(
        "server=localhost; port=3306; database=BancoEscola; user=root; password=8617509; Persist Security Info=False; Connect Timeout=300;");
