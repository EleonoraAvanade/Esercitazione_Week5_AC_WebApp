using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
        [Authorize]
    public class PiattoController : Controller
    {
            private readonly IBusinessLayer bl;

            public PiattoController(IBusinessLayer businessLayer)
            {
                this.bl = businessLayer;
            }

            public IActionResult Index()
            {
                var model = bl.Read();
                return View(model);
            }

            public IActionResult Details(int id)
            {
                if (id <= 0)
                {
                    return View("Error", new ErrorViewModel());
                }

                //Recupero impiegato da visualizzare
                var emp = bl.GetPiattoById(id);

                //Restituzione della vista (check del modello)
                if (emp == null)
                {
                    return View("NotFound", new NotFoundViewModel()
                    {
                        EntityId = id,
                        Message = "L'oggetto è null"
                    });
                }
                return View(emp);
            }

            [Authorize(Policy = "AccountAdministrator")]
            public IActionResult Add()
            {
                return View();
            }

            [Authorize(Policy = "AccountAdministrator")]
            [HttpPost]
            public IActionResult Add(PiattoViewModel data)
            {
                //validazione
                if (data == null)
                {
                    return View("Error", new ErrorViewModel());
                }
                if (ModelState.IsValid)
                {
                    //chiamata al business layer
                    ItemResult result = bl.AddNewPiatto(new Piatto
                    {
                        Id = data.Id,
                        Nome = data.Nome,
                        Descrizione = data.Descrizione,
                        Tipologia = data.Tipologia,
                        Prezzo = data.Prezzo
                    });
                    //restituzione della view
                    if (result.Res)
                    {
                        return RedirectToAction("Index");
                    }
                }

                return View();
            }
            
            [Authorize(Policy = "AccountAdministrator")]
            public IActionResult Edit(int id)
            {
                if (id <= 0)
                {
                    return View("Error", new ErrorViewModel());
                }

                var model = bl.GetPiattoById(id);
                if (model == null)
                {
                    return View("NotFound", new NotFoundViewModel { EntityId = id, Message = "Elemento non trovato" });
                }
                var pViewModel = new PiattoViewModel
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Descrizione = model.Descrizione,
                    Tipologia = model.Tipologia,
                    Prezzo = model.Prezzo

                };
                return View(pViewModel);
            }
            
            [Authorize(Policy = "AccountAdministrator")]
            [HttpPost]
            public IActionResult Edit(PiattoViewModel data)
            {
                if (data == null)
                {
                    return View("Error", new ErrorViewModel());
                }
                if (ModelState.IsValid)
                {
                    var result = bl.EditPiatto(new Piatto
                    {
                        Id = data.Id,
                        Nome=data.Nome,
                        Descrizione=data.Descrizione,
                        Tipologia=data.Tipologia,
                        Prezzo=data.Prezzo
                    });
                    if (result.Res)
                    {
                        return RedirectToAction("Index");
                    }
                }

                return View();
            }
            
            [Authorize(Policy = "AccountAdministrator")]
            public IActionResult Delete(int id)
            {
                if (id <= 0)
                {
                    return View("Error", new ErrorViewModel());
                }
                var model = bl.GetPiattoById(id);
                if (model == null)
                {
                    return View("NotFound", new NotFoundViewModel()
                    {
                        EntityId = id,
                        Message = "L'oggetto è null"
                    });
                }
                return View(model);
            }
        
            [Authorize(Policy = "AccountAdministrator")]
            [HttpPost]
            public IActionResult Delete(Piatto data)
            {
                var pToDelete = bl.GetPiattoById(data.Id);

                var result = bl.DeletePiatto(pToDelete);
                if (result.Res)
                {
                    return RedirectToAction("Index");
                }

                return View();
            }
    }
}
