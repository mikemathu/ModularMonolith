﻿using Microsoft.AspNetCore.Mvc;

namespace Modules.UserManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : Controller
{
    private readonly Module.UserManagement.Services.IUsers users;

    public UsersController(Module.UserManagement.Services.IUsers users)
    {
        this.users = users;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Integration.UserManagement.UserDetails>> Get(int id)
    {
        var user = await users.WithId(id);

        return user == null ? NotFound() : user;
    }
}
