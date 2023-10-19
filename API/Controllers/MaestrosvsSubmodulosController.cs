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

public class MaestrosvsSubmodulosController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MaestrosvsSubmodulosController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<MaestrovsSubmoduloDto>>> Get()
    {
        var maestrosVsSubmodulos = await _unitOfWork.MaestrovsSubmodulos.GetAllAsync();
        return _mapper.Map<List<MaestrovsSubmoduloDto>>(maestrosVsSubmodulos);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MaestrovsSubmoduloDto>> Get(int id)
    {
        var maestrosVsSubmodulos = await _unitOfWork.MaestrovsSubmodulos.GetByIdAsync(id);
        if (maestrosVsSubmodulos == null)
        {
            return NotFound();
        }
        return _mapper.Map<MaestrovsSubmoduloDto>(maestrosVsSubmodulos);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MaestrovsSubmoduloDto>> Post(MaestrovsSubmoduloDto maestrosVsSubmodulosDto)
    {
        var maestrosVsSubmodulos = _mapper.Map<MaestrovsSubmodulo>(maestrosVsSubmodulosDto);
        if (maestrosVsSubmodulosDto.FechaCreacion == DateOnly.MinValue)
        {
            maestrosVsSubmodulosDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            maestrosVsSubmodulos.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (maestrosVsSubmodulosDto.FechaModificacion == DateOnly.MinValue)
        {
            maestrosVsSubmodulosDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            maestrosVsSubmodulos.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        _unitOfWork.MaestrovsSubmodulos.Add(maestrosVsSubmodulos);
        await _unitOfWork.SaveAsync();
        if (maestrosVsSubmodulosDto == null)
        {
            return BadRequest();
        }
        maestrosVsSubmodulosDto.Id = maestrosVsSubmodulos.Id;
        return CreatedAtAction(nameof(Post), new { id = maestrosVsSubmodulosDto.Id }, maestrosVsSubmodulosDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MaestrovsSubmoduloDto>> Put(int id, [FromBody] MaestrovsSubmoduloDto maestrosVsSubmodulosDto)
    {
        if (maestrosVsSubmodulosDto.Id == 0)
        {
            maestrosVsSubmodulosDto.Id = id;
        }
        if (maestrosVsSubmodulosDto.Id != id)
        {
            return NotFound();
        }
        var maestrosVsSubmodulos = _mapper.Map<MaestrovsSubmodulo>(maestrosVsSubmodulosDto);
        if (maestrosVsSubmodulosDto.FechaCreacion == DateOnly.MinValue)
        {
            maestrosVsSubmodulosDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            maestrosVsSubmodulos.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (maestrosVsSubmodulosDto.FechaModificacion == DateOnly.MinValue)
        {
            maestrosVsSubmodulosDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            maestrosVsSubmodulos.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        maestrosVsSubmodulosDto.Id = maestrosVsSubmodulos.Id;
        _unitOfWork.MaestrovsSubmodulos.Update(maestrosVsSubmodulos);
        await _unitOfWork.SaveAsync();
        return maestrosVsSubmodulosDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var maestrosVsSubmodulos = await _unitOfWork.MaestrovsSubmodulos.GetByIdAsync(id);
        if (maestrosVsSubmodulos == null)
        {
            return NotFound();
        }
        _unitOfWork.MaestrovsSubmodulos.Remove(maestrosVsSubmodulos);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}