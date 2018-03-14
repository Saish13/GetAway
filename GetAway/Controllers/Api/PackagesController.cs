using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GetAway.Dtos;
using GetAway.Models;
using AutoMapper;
using System.Data.Entity;

namespace GetAway.Controllers.Api
{
    public class PackagesController : ApiController
    {
        private ApplicationDbContext _context;
        public PackagesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/packages
        public IHttpActionResult GetPackages()
        {
            var packageDto = _context.Package.ToList().Select(Mapper.Map<Package, PackageDto>);
            return Ok(packageDto);
        }

        // GET /api/packages/id
        public IHttpActionResult GetPackage(int id)
        {
            var package = _context.Package.SingleOrDefault(p => p.Id == id);

            if (package == null)
                return NotFound();

            return Ok(Mapper.Map<Package, PackageDto>(package));
        }

        // PUT /api/packages/1
        [HttpPut]
        public IHttpActionResult UpdatePackage(int id, PackageDto packageDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var packageInDb = _context.Package.SingleOrDefault(p => p.Id == id);

            if (packageInDb == null)
                return NotFound();

            Mapper.Map(packageDto, packageInDb);
            _context.SaveChanges();

            return Ok();
            
        }

        // DELETE /api/packages/1
        [HttpDelete]
        public IHttpActionResult DeletePackage(int id)
        {
            var packageInDb = _context.Package.SingleOrDefault(p => p.Id == id);

            if (packageInDb == null)
                return NotFound();

            _context.Package.Remove(packageInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
