using Microsoft.AspNetCore.Mvc;

namespace teste.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExemploController : ControllerBase
{
    private readonly IServicoExemplo _servico;

    public ExemploController(IServicoExemplo servico)
    {
        _servico = servico;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _servico.MetodoExemplo();
        return Ok("Hello, World!");
    }
}

public interface IServicoExemplo
{
    void MetodoExemplo();
}

public class ServicoExemplo : IServicoExemplo
{
    public void MetodoExemplo()
    {
        Console.WriteLine("MétodoExemplo executado com sucesso.");
    }
}