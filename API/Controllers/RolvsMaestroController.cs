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

public class RolvsMaestroController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RolvsMaestroController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<RolvsMaestroDto>>> Get()
    {
        var rolVsMaestro = await _unitOfWork.RolvsMaestros.GetAllAsync();
        return _mapper.Map<List<RolvsMaestroDto>>(rolVsMaestro);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolvsMaestroDto>> Get(int id)
    {
        var rolVsMaestro = await _unitOfWork.RolvsMaestros.GetByIdAsync(id);
        if (rolVsMaestro == null)
        {
            return NotFound();
        }
        return _mapper.Map<RolvsMaestroDto>(rolVsMaestro);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolvsMaestroDto>> Post(RolvsMaestroDto rolVsMaestroDto)
    {
        var rolVsMaestro = _mapper.Map<RolvsMaestro>(rolVsMaestroDto);
        if (rolVsMaestroDto.FechaCreacion == DateOnly.MinValue)
        {
            rolVsMaestroDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            rolVsMaestro.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (rolVsMaestroDto.FechaModificacion == DateOnly.MinValue)
        {
            rolVsMaestroDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            rolVsMaestro.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        _unitOfWork.RolvsMaestros.Add(rolVsMaestro);
        await _unitOfWork.SaveAsync();
        if (rolVsMaestroDto == null)
        {
            return BadRequest();
        }
        rolVsMaestroDto.Id = rolVsMaestro.Id;
        return CreatedAtAction(nameof(Post), new { id = rolVsMaestroDto.Id }, rolVsMaestroDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RolvsMaestroDto>> Put(int id, [FromBody] RolvsMaestroDto rolVsMaestroDto)
    {
        if (rolVsMaestroDto.Id == 0)
        {
            rolVsMaestroDto.Id = id;
        }
        if (rolVsMaestroDto.Id != id)
        {
            return NotFound();
        }
        var rolVsMaestro = _mapper.Map<RolvsMaestro>(rolVsMaestroDto);
        if (rolVsMaestroDto.FechaCreacion == DateOnly.MinValue)
        {
            rolVsMaestroDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            rolVsMaestro.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (rolVsMaestroDto.FechaModificacion == DateOnly.MinValue)
        {
            rolVsMaestroDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            rolVsMaestro.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        rolVsMaestroDto.Id = rolVsMaestro.Id;
        _unitOfWork.RolvsMaestros.Update(rolVsMaestro);
        await _unitOfWork.SaveAsync();
        return rolVsMaestroDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var rolVsMaestro = await _unitOfWork.RolvsMaestros.GetByIdAsync(id);
        if (rolVsMaestro == null)
        {
            return NotFound();
        }
        _unitOfWork.RolvsMaestros.Remove(rolVsMaestro);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}