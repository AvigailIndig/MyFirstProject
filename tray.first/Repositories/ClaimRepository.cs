using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tray.first.Interface;
using Claim = MyProject.Repositories.Entities.Claim;

namespace tray.first.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, int RoleId, int PermissionId, EPolicy Policy)
        {
            _context.Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow });
            return _context.Claims.First(p => p.Id == id);
        }

        public Claim Delete(int id)
        {
            Claim c = _context.Claims.First(p1 => p1.Id == id);
            _context.Claims = _context.Claims.Where(p1 => p1.Id != id).ToList();
            return c;
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.First(p => p.Id == id);
        }

        public Claim Update(Claim claim)
        {
            Claim r = _context.Claims.First(p => p.Id == claim.Id);
            r.RoleId = claim.RoleId;
            r.PermissionId = claim.PermissionId;
            r.Policy = claim.Policy;
            return r;
        }
    }
}
