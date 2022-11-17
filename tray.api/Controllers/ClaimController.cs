using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using tray.first.Repositories;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimController()
        {
            var mock = new MockContext();
            _claimRepository = new ClaimRepository(mock);
        }

        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _claimRepository.GetById(id);
        }
        [HttpPost]
        public Claim AddClaim(int id, int RoleId, int PermissionId, EPolicy Policy)
        {
            return _claimRepository.Add(id, RoleId, PermissionId, Policy);
        }
        [HttpPut]
        public Claim Update(Claim claim)
        {
            return _claimRepository.Update(claim);
        }
        [HttpDelete]
        //public Claim Delete(int id)
        //{
        //    return _claimRepository.Delete(id);
        //}

    }
}
