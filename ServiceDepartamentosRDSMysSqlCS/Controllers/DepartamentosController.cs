using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceDepartamentosRDSMysSqlCS.Models;
using ServiceDepartamentosRDSMysSqlCS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


[Route("api/[controller]")]
[ApiController]
public class DepartamentosController : ControllerBase
{
    RepositoryDepartamentos repo;

    public DepartamentosController(RepositoryDepartamentos repo)
    {
        this.repo = repo;
    }

    [HttpGet]
    public List<Departamento> GetDepartamentos()
    {
        return this.repo.GetDepartamentos();
    }

    [HttpGet("{id}")]
    public Departamento FindDepartamento(int id)
    {
        return this.repo.FindDepartamento(id);
    }
}
