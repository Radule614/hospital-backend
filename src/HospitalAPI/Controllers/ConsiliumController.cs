﻿using HospitalAPI.Dtos;
using HospitalAPI.Mappers;
using HospitalLibrary.Core.Model;
using HospitalLibrary.Core.Service;
using Microsoft.AspNetCore.Mvc;


namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsiliumController : ControllerBase
    {
        private readonly IConsiliumService _consiliumService;
        private readonly IGenericMapper<Consilium, ConsiliumDTO> _consiliumMapper;

        public ConsiliumController(IConsiliumService consiliumService, IGenericMapper<Consilium, ConsiliumDTO> consiliumMapper)
        {
            _consiliumService = consiliumService;
            _consiliumMapper = consiliumMapper;
        }

        [HttpPost]
        public ActionResult Create(ConsiliumDTO consiliumDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Consilium consilium = _consiliumMapper.ToModel(consiliumDTO);
            _consiliumService.Create(consilium);
            return CreatedAtAction("Create", new { id = consilium.ConsiliumId }, consilium);
        }
    }
}
