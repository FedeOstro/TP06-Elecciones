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
        ViewBag.InfoPartido = BD.VerInfoCandidato(IdPartido);
        ViewBag.ListaCandidatos = BD.ListaCandidatos(IdPartido);
        return View();
    }

    public IActionResult VerDetalleCandidato(int idCandidato)
    {   
        ViewBag.VerInfoCandidato = BD.VerDetalleCandidato(idCandidato);
        return View();
    }

    public IActionResult AgregarCantidato(int IdPartido)
    {
        ViewBag.IdPartido = IdPartido;
        return View();
    }
    
    [HttpPost] IActionResult GuardadCandidato(Candidato can)
    {
        BD.AgregarCantidato(can);
        VerDetallePartido(can.IdPartido);
    }

    IActionResult EliminarCandidato(int idCandidato, int idPartido)
    {
        BD.EliminarCandidato(idCandidato);
        VerDetallePartido(idPartido);
    }

    IActionResult Elecciones()
    {
        return View();
    }

    IActionResult Creditos()
    {
        return View();
    }
}
