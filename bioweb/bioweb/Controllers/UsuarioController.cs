using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bioweb.Models;
using bioweb.Models.ViewModels;

namespace bioweb.Controllers
{
    public class UsuarioController : Controller
    {
        /*
         * vista usuario
        */ 
        public ActionResult Agregar()
        {

            return View();
        }

        /*
         * método agregar
        */ 
        [HttpPost]
        public ActionResult Agregar(UsuarioViewModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (biowebEntities db = new biowebEntities())
                    {
                        var usuarioT = new usuario();

                        usuarioT.nombre = usuario.nombre;
                        usuarioT.tipo_usuario = usuario.tipoUsuario;
                        usuarioT.tipo_documento = usuario.tipoDocumento;
                        usuarioT.numero_documento = usuario.numeroDocumento;
                        usuarioT.direccion = usuario.direccion;
                        usuarioT.telefono = usuario.telefono;
                        usuarioT.correo = usuario.correo;
                        usuarioT.loguin = usuario.loguin;
                        usuarioT.clave = usuario.clave;

                        db.usuario.Add(usuarioT);
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

            return View();
        }

        /*
         * vista actualizar
        */ 
        public ActionResult Actualizar(int idUsuario)
        {
            UsuarioViewModel usuario = new UsuarioViewModel();

            using (biowebEntities db = new biowebEntities())
            {
                var usuarioT = db.usuario.Find(idUsuario);
                
                usuario.idUsuario = usuarioT.id_usuario;
                usuario.nombre = usuarioT.nombre;
                usuario.tipoUsuario = usuarioT.tipo_usuario;
                usuario.tipoDocumento = usuarioT.tipo_documento;
                usuario.numeroDocumento = usuarioT.numero_documento;
                usuario.direccion = usuarioT.direccion;
                usuario.telefono = usuarioT.telefono;
                usuario.correo = usuarioT.correo;
                usuario.loguin = usuarioT.loguin;
                usuario.clave = usuarioT.clave;
            }

            return View(usuario);
        }

        /*
         * método actualizar
        */
        [HttpPost]
        public ActionResult Actualizar(UsuarioViewModel usuario)
        {
            try
            {
                using (biowebEntities db = new biowebEntities())
                {
                    var usuarioT = db.usuario.Find(usuario.idUsuario);

                    usuarioT.id_usuario = usuario.idUsuario;
                    usuarioT.nombre = usuario.nombre;
                    usuarioT.tipo_usuario = usuario.tipoUsuario;
                    usuarioT.tipo_documento = usuario.tipoDocumento;
                    usuarioT.numero_documento = usuario.numeroDocumento;
                    usuarioT.direccion = usuario.direccion;
                    usuarioT.telefono = usuario.telefono;
                    usuarioT.correo = usuario.correo;
                    usuarioT.loguin = usuario.loguin;
                    usuarioT.clave = usuario.clave;

                    db.Entry(usuarioT).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.confirmacion = true;
                }
            }
            catch (Exception ex)
            {
                ViewBag.confirmacion = false;
                throw new Exception(ex.Message);
            }

            return View();
        }


        /*
         * lista todos los usuarios
        */
        public ActionResult Listar()
        {
            List<UsuarioViewModel> lista;

            using (biowebEntities db = new biowebEntities())
            {
                lista = (from tablaUsuario in db.usuario
                         
                         select new UsuarioViewModel
                         {
                             idUsuario = tablaUsuario.id_usuario,
                             nombre = tablaUsuario.nombre,
                             tipoUsuario = tablaUsuario.tipo_usuario,
                             tipoDocumento = tablaUsuario.tipo_documento,
                             numeroDocumento = tablaUsuario.numero_documento,
                             direccion = tablaUsuario.direccion,
                             telefono = tablaUsuario.telefono,
                             correo = tablaUsuario.correo,
                             loguin = tablaUsuario.loguin,
                             clave = tablaUsuario.clave

                         }).ToList();
            }
            return View(lista);
        }
    }
}