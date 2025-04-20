using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSharpRender.src.controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase {
    private readonly IConfiguration _configuration;

    public StatusController(IConfiguration configuration) {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult GetStatus() {
        var connString = _configuration.GetConnectionString("DefaultConnection");
        var jwtKey = _configuration["JwtSettings:Secret"];
        return Ok(new {
            status = "OK",
            connString,
            jwtKey
        });
    }

    [HttpGet("health")]
    public IActionResult GetHealth() {
        return Ok(new { status = "Healthy" });
    }
}
