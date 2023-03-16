using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using application.services;
using api.Dtos;
using api.entities;
using domain.value_objects;
using Newtonsoft.Json;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistaController : ControllerBase
{

    private readonly IMapper _mapper;
    private readonly IArtistaService artistaService;

    public ArtistaController(IMapper mapper, IArtistaService artistaService)
    {
        _mapper = mapper;
        this.artistaService = artistaService;
    }

    [HttpPost]
    public ActionResult post(ArtistaDto request)
    {
        ArtistaVentaVO artista = this.artistaService.create(_mapper.Map<ArtistaEntity>(request));
        string json = JsonConvert.SerializeObject(artista, Formatting.Indented);
        return Ok(json);
    }
}
