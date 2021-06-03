using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Backend6.Data;
using Backend6.Models;

namespace Backend6.Controllers
{
    public class FoldersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoldersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Folders;
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? idParent)
        {
            if (idParent == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .Include(f => f.Files)
                .SingleOrDefaultAsync(m => m.Id == idParent);
            if (folder == null)
            {
                return NotFound();
            }
            return View(folder);
        }

        public IActionResult Create()
        {
            return View(new Folder());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Folder model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid? idParent)
        {
            if (idParent == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .SingleOrDefaultAsync(m => m.Id == idParent);
            if (folder == null)
            {
                return NotFound();
            }
            return View(folder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid idParent, Folder model)
        {
            if (idParent == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .SingleOrDefaultAsync(m => m.Id == idParent);

            if (folder == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                folder.Name = model.Name;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(Guid? idParent)
        {
            if (idParent == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .Include(f => f.Files)
                .SingleOrDefaultAsync(m => m.Id == idParent);
            if (folder == null)
            {
                return NotFound();
            }
            return View(folder);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid idParent)
        {
            if (idParent == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .SingleOrDefaultAsync(m => m.Id == idParent);

            if (folder == null)
            {
                return NotFound();
            }
            _context.Folders.Remove(folder);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Folders");
        }

        private bool FolderExists(Guid id)
        {
            return _context.Folders.Any(e => e.Id == id);
        }
    }
}