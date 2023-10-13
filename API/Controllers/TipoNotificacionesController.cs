using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TipoNotificacionesController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TipoNotificacionesController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoNotificacionDto>>> Get()
    {
        var tipoNotificaciones = await _unitOfWork.TipoNotificaciones.GetAllAsync();
        return _mapper.Map<List<TipoNotificacionDto>>(tipoNotificaciones);
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoNotificacionDto>> Get(int Id)
    {
        var tipoNotificaciones = await _unitOfWork.TipoNotificaciones.GetByIdAsync(Id);
        if (tipoNotificaciones == null)
        {
            return NotFound();
        }
        return _mapper.Map<TipoNotificacionDto>(tipoNotificaciones);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoNotificacionDto>> Post(TipoNotificacionDto tipoNotificacionesDto)
    {
        var tipoNotificaciones = _mapper.Map<TipoNotificacion>(tipoNotificacionesDto);
        if (tipoNotificacionesDto.FechaCreacion == DateOnly.MinValue)
        {
            tipoNotificacionesDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            tipoNotificaciones.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (tipoNotificacionesDto.FechaModificacion == DateOnly.MinValue)
        {
            tipoNotificacionesDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            tipoNotificaciones.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        _unitOfWork.TipoNotificaciones.Add(tipoNotificaciones);
        await _unitOfWork.SaveAsync();
        if (tipoNotificacionesDto == null)
        {
            return BadRequest();
        }
        tipoNotificacionesDto.Id = tipoNotificaciones.Id;
        return CreatedAtAction(nameof(Post), new { id = tipoNotificacionesDto.Id }, tipoNotificacionesDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoNotificacionDto>> Put(int id, [FromBody] TipoNotificacionDto tipoNotificacionesDto)
    {
        if (tipoNotificacionesDto.Id == 0)
        {
            tipoNotificacionesDto.Id = id;
        }
        if (tipoNotificacionesDto.Id != id)
        {
            return NotFound();
        }
        var tipoNotificaciones = _mapper.Map<TipoNotificacion>(tipoNotificacionesDto);
        if (tipoNotificacionesDto.FechaCreacion == DateOnly.MinValue)
        {
            tipoNotificacionesDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            tipoNotificaciones.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (tipoNotificacionesDto.FechaModificacion == DateOnly.MinValue)
        {
            tipoNotificacionesDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            tipoNotificaciones.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        tipoNotificacionesDto.Id = tipoNotificaciones.Id;
        _unitOfWork.TipoNotificaciones.Update(tipoNotificaciones);
        await _unitOfWork.SaveAsync();
        return tipoNotificacionesDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var tipoNotificaciones = await _unitOfWork.TipoNotificaciones.GetByIdAsync(id);
        if (tipoNotificaciones == null)
        {
            return NotFound();
        }
        _unitOfWork.TipoNotificaciones.Remove(tipoNotificaciones);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}