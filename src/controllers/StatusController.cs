using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSharpRender.src.controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase {
    [HttpGet]
    public IActionResult GetStatus() {
        return Ok(new { status = "OK" });
    }

    [HttpGet("health")]
    public IActionResult GetHealth() {
        return Ok(new { status = "Healthy" });
    }
}
