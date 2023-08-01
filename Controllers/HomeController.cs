using Microsoft.AspNetCore.Mvc;

namespace Bd.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPartido = BD.ListarPartidos();
        return View();
    }

    public IActionResult VerDetallePartido(int IdPartido)
    {
        ViewBag.InfoPartido = BD.VerInfoPartido(IdPartido);
        ViewBag.ListaCandidatos = BD.ListarCandidatos(IdPartido);
        return View();
    }

    public IActionResult VerDetalleCandidato(int idCandidato)
    {   
        ViewBag.VerInfoCandidato = BD.VerInfoCandidato(idCandidato);
        return View();
    }

    public IActionResult AgregarCandidato(int IdPartido)
    {
        ViewBag.IdPartido = IdPartido;
        return View();
    }
    
    [HttpPost] public IActionResult GuardarCandidato(Candidato can)
    {
        BD.AgregarCantidato(can);
        return RedirectToAction("VerDetallePartido", new {IdPartido = can.IdPartido});
    }

    public IActionResult EliminarCandidato(int IdCandidato, int idPartido)
    {
        Console.WriteLine(idPartido);
        Console.WriteLine(IdCandidato);
        BD.EliminarCandidato(IdCandidato);
        return RedirectToAction("VerDetallePartido", new {IdPartido = idPartido});
    }

    public IActionResult Elecciones()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }
}
