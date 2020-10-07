﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using PasajeDatosClase06Oct.Models;

namespace PasajeDatosClase06Oct.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            //Empleado em = new Empleado() { Apyn = "Juarez Marce" };

            //Cliente cli = new Cliente() { RazonSocial = "Nueva Empresa" };

            //ViewBag.ClienteNuevaEmpresa = cli;
            EmpleadoClienteVM emVM = new EmpleadoClienteVM("Juarez Marce", "Nueva Empresa");

            Session["EmpleadoCliente"] = emVM;

            CalculadoraSalarios calc = new CalculadoraSalarios();

            Administrativo emADM = new Administrativo() { Apyn = "Juan" };

            calc.ResolverCalculoSalario(emADM);




            return View(emVM);
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
