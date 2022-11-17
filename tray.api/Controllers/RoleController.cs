using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using tray.first.Repositories;

namespace tray.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpPost]
        public Role AddRole(int id,string name, string descripition)
        {
           return _roleRepository.Add(id,name,descripition);
        }
        [HttpPut]
        public Role Update(Role role)
        {
            return _roleRepository.Update(role);
        }
        [HttpDelete]
        public Role Delete(int id)
        {
            return _roleRepository.Delete(id);
        }

    }
}
