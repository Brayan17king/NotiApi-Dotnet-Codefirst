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

public class BlockchainController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BlockchainController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<BlockchainDto>>> Get()
    {
        var blockChain = await _unitOfWork.Blockchains.GetAllAsync();
        return _mapper.Map<List<BlockchainDto>>(blockChain);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BlockchainDto>> Get(int id)
    {
        var blockChain = await _unitOfWork.Blockchains.GetByIdAsync(id);
        if (blockChain == null)
        {
            return NotFound();
        }
        return _mapper.Map<BlockchainDto>(blockChain);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BlockchainDto>> Post(BlockchainDto blockChainDto)
    {
        var blockChain = _mapper.Map<Blockchain>(blockChainDto);
        if (blockChainDto.FechaCreacion == DateOnly.MinValue)
        {
            blockChainDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            blockChain.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (blockChainDto.FechaModificacion == DateOnly.MinValue)
        {
            blockChainDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            blockChain.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        _unitOfWork.Blockchains.Add(blockChain);
        await _unitOfWork.SaveAsync();
        if (blockChainDto == null)
        {
            return BadRequest();
        }
        blockChainDto.Id = blockChain.Id;
        return CreatedAtAction(nameof(Post), new { id = blockChainDto.Id }, blockChainDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<BlockchainDto>> Put(int id, [FromBody] BlockchainDto blockChainDto)
    {
        if (blockChainDto.Id == 0)
        {
            blockChainDto.Id = id;
        }
        if (blockChainDto.Id != id)
        {
            return NotFound();
        }
        var blockChain = _mapper.Map<Blockchain>(blockChainDto);
        if (blockChainDto.FechaCreacion == DateOnly.MinValue)
        {
            blockChainDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            blockChain.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
        }
        if (blockChainDto.FechaModificacion == DateOnly.MinValue)
        {
            blockChainDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            blockChain.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
        }
        blockChainDto.Id = blockChain.Id;
        _unitOfWork.Blockchains.Update(blockChain);
        await _unitOfWork.SaveAsync();
        return blockChainDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var blockChain = await _unitOfWork.Blockchains.GetByIdAsync(id);
        if (blockChain == null)
        {
            return NotFound();
        }
        _unitOfWork.Blockchains.Remove(blockChain);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}