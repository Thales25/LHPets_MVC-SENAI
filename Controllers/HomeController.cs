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
        
       // isntancia do tipo cliente
        Cliente cliente1 = new Cliente(01, "Ricardo Silva","109.003.251.25","thalessousa8579@gmail.com","Mel", "cachoro");
        Cliente cliente2 = new Cliente(02,"Ana Silva", "123.456.789-10", "ana.silva@email.com", "Rex", "Cachorro");
        Cliente cliente3 = new Cliente(03,"Carlos Oliveira", "456.789.123-10", "carlos.oliveira@email.com", "Thor", "Cachorro");
        Cliente cliente4 = new Cliente(04,"Daniela Costa", "789.123.456-10", "daniela.costa@email.com", "Mingau", "Gato");
        Cliente cliente5 = new Cliente(05," Eduardo Almeida", "321.654.987-10", "eduardo.almeida@email.com", "Polly", "Papagaio");

        //lista de cliente
        List<Cliente> listaCLientes = new List<Cliente>();
        listaCLientes.Add(cliente1);
        listaCLientes.Add(cliente2);
        listaCLientes.Add(cliente3);
        listaCLientes.Add(cliente4);
        listaCLientes.Add(cliente5);

        ViewBag.listaCLientes = listaCLientes;




        //instancia do tipo fornecedores
        Fornecedor forncedor1 = new Fornecedor(01,"SoluçãoPet","14.182.102/0001","solucaopet@gmail.com" );
        Fornecedor forncedor2 = new Fornecedor(02,"Pet Shop do Bairro", "1234567890001-01", "petshopbairro@email.com");
        Fornecedor forncedor3 = new Fornecedor(03,"Mundo dos Pets", "34567890001-03", "mundodospets@email.com");
        Fornecedor forncedor4 = new Fornecedor(04,"Loja dos Animais", "4567890001-04", "lojadosanimais@email.com");
        Fornecedor forncedor5 = new Fornecedor(05,"Pet Feliz", "567890001-05", "petfeliz@email.com");
        
        
        //Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(forncedor1);
        listaFornecedores.Add(forncedor2);
        listaFornecedores.Add(forncedor3);
        listaFornecedores.Add(forncedor4);
        listaFornecedores.Add(forncedor5);

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
