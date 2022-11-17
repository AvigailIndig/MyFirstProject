using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System.Security;
using tray.first.Repositories;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _PermissionRepository;

        public PermissionController()
        {
            var mock = new MockContext();
            _PermissionRepository = new PermissionRepository(mock);
        }

        [HttpGet]
        public List<Permission> Get()
        {
            return _PermissionRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _PermissionRepository.GetById(id);
        }
        [HttpPost]
        public Permission AddRole(int id, string name, string descripition)
        {
            return _PermissionRepository.Add(id, name, descripition);
        }
        [HttpPut]
        public Permission Update(Permission permission)
        {
            return _PermissionRepository.Update(permission);
        }
        [HttpDelete]
        public Permission Delete(int id)
        {
            return _PermissionRepository.Delete(id);
        }
    }
}
