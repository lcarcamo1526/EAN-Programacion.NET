﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMVC5.Models;

namespace TallerMVC5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Usuario() {
            return View();
        }

        [HttpPost]
        public IActionResult Usuario(Usuario user)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    ViewData["Nombre"] = user.Nombre;
                    ViewData["Apellido"] = user.Apellido;
                    ViewData["Numero_horas"] = user.Numero_horas;
                    ViewData["Valor_horas"] = user.Valor_horas;
                    ViewData["Riesgo"] = user.Riesgo;

                    return View("Info");
                }
                return View("Info");
            }
            catch (Exception)
            {
                return View();

            }
        }

        public IActionResult Info()
        {

            return View();
        }



        public IActionResult Calificaciones()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calificaciones(Calificaciones califcacion)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    ViewData["Nombre_Estudiante"] = califcacion.Nombre_Estudiante;
                    ViewData["Apellido_Estudiante"] = califcacion.Apellido_Estudiante;
                    ViewData["Nota1"] = califcacion.Nota1;
                    ViewData["Nota2"] = califcacion.Nota2;
                    ViewData["Nota3"] = califcacion.Nota3;

                    return View("Resultados");
                }
                return View("Resultados");
            }
            catch (Exception)
            {
                return View();

            }
        }




    }
}


