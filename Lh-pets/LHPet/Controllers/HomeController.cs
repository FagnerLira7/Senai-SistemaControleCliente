using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancia tipo clientes
        Cliente cliente1 = new Cliente(1, "junior", "123.456.789-10", "junior123@hotmail.com", "Zé");
        Cliente cliente2 = new Cliente(2, "julia", "321.654.987-01", "julia456@hotmail.com", "Zoinho");
        Cliente cliente3 = new Cliente(3, "jonatan", "213.546.879-10", "jonatan789@hotmail.com", "Zuca");
        Cliente cliente4 = new Cliente(4, "jacara", "231.564.897-10", "jacara10@hotmail.com", "Zefa");
        Cliente cliente5 = new Cliente(5, "jigi", "109-876-543-21", "jigi@hotmail.com", "zuzu");

        //Criando a lista de cliente e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        // leva os dados pra view
        ViewBag.listaClientes = listaClientes;

        //instancia tipo clientes e atribuir os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Fornecedor ABC Ltda.", "07.387.239/0001-68", "fornecedorabc@exemplo.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Fornecedor XYZ S/A", "82.685.109/0001-82", "fornecedorxyz@exemplo.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Fornecedor YYY EIRELI", "10.567.124/0001-12", "fornecedoryyy@exemplo.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Fornecedor KLM & Cia.", "30.452.015/0001-01", "fornecedorklm@exemplo.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Fornecedor JKL Comércio Ltda.", "18.357.432/0001-55", "fornecedorjkl@exemplo.com.br");

        //Criando a lista de fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        // leva os dados pra view
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
