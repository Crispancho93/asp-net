using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using bioweb.Models;
using bioweb.Models.ViewModels;

namespace bioweb.Controllers
{
    public class EmpleadoController : Controller
    {

        /*
         * vista agregar
        */
        public ActionResult Agregar()
        {
            
            return View();
        }

        /*
         * método agregar
        */
        [HttpPost]
        public ActionResult Agregar(EmpleadoViewModel empleado)
        {
            try
            {
                // validar si nuetro modelo es valido, por medio de los data annotations
                if (ModelState.IsValid)
                {
                    using (biowebEntities db = new biowebEntities())
                    {
                        // creo un objeto de la tabla a la que lo voy agregar
                        var empTabla = new persona();

                        // asigno valores que me llegan de la vista
                        empTabla.nombre = empleado.nombre;
                        empTabla.tipo_persona = "empleado";
                        empTabla.tipo_documento = empleado.tipoDocumento;
                        empTabla.numero_documento = empleado.numeroDocumento;
                        empTabla.direccion = empleado.direccion;
                        empTabla.telefono = empleado.telefono;
                        empTabla.correo = empleado.correo;
                        empTabla.nombre_contacto = empleado.nombreContacto;
                        empTabla.telefono_contacto = empleado.telefonoContacto;

                        // agrego el objeto a memoria e inserto a base de datos
                        db.persona.Add(empTabla);
                        db.SaveChanges();
                        ViewBag.confirmacion = true;
                    }

                }

                
            }
            catch(Exception ex)
            {
                ViewBag.confirmacion = false;
                throw new Exception(ex.Message);  
            }

            return View();
        }
        
        /*
         * actualizar
        */
        public ActionResult Actualizar(int idEmpleado)
        {
            EmpleadoViewModel empleado = new EmpleadoViewModel();

            using (biowebEntities db = new biowebEntities())
            {
                var emTabla = db.persona.Find(idEmpleado);

                empleado.idPersona = emTabla.id_persona;
                empleado.nombre = emTabla.nombre;
                empleado.tipoDocumento = emTabla.tipo_documento;
                empleado.numeroDocumento = emTabla.numero_documento;
                empleado.direccion = emTabla.direccion;
                empleado.telefono = emTabla.telefono;
                empleado.correo = emTabla.correo;
                empleado.nombreContacto = emTabla.nombre_contacto;
                empleado.telefonoContacto = emTabla.telefono_contacto;
            }

            return View(empleado);
        }

       /*
        * método actualizar
       */
       [HttpPost]
       public ActionResult Actualizar(EmpleadoViewModel empleado) 
       {
            try
            {
                if (ModelState.IsValid)
                {
                    using (biowebEntities db = new biowebEntities())
                    {
                        var emTabla = db.persona.Find(empleado.idPersona);

                        emTabla.nombre = empleado.nombre;
                        emTabla.tipo_documento = empleado.tipoDocumento;
                        emTabla.numero_documento = empleado.numeroDocumento;
                        emTabla.direccion = empleado.direccion;
                        emTabla.telefono = empleado.telefono;
                        emTabla.correo = empleado.correo;
                        emTabla.nombre_contacto = empleado.nombreContacto;
                        emTabla.telefono_contacto = empleado.telefonoContacto;

                        db.Entry(emTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        ViewBag.confirmacion = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.confirmacion = false;
                throw new Exception(ex.Message);
            }

            return View(empleado);
       }

        /*
         * listar los empleados
        */
        public ActionResult Listar()
        {
            // lista de emplados
            List<EmpleadoViewModel> lista;
 
            // usamos entityFramework
            using (biowebEntities db = new biowebEntities()) 
            {
                // agregar a la lista
                lista = (from emTabla in db.persona

                     // creo un nuevo objeto por cada registro de la consulta       
                     select new EmpleadoViewModel
                     {
                           idPersona = emTabla.id_persona,
                           nombre = emTabla.nombre,
                           tipoPersona = emTabla.tipo_persona,
                           tipoDocumento = emTabla.tipo_documento,
                           numeroDocumento = emTabla.numero_documento,
                           direccion = emTabla.direccion,
                           telefono = emTabla.telefono,
                           correo = emTabla.correo,
                           nombreContacto = emTabla.nombre_contacto,
                          telefonoContacto = emTabla.telefono_contacto
                                 
                     }).Where(a => a.tipoPersona == "empleado").ToList();
            }
            return View(lista);
        }

    }
}