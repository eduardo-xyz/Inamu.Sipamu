using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inamu.Sipamu.Models;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;

namespace Inamu.Sipamu.Controllers
{
    public class UsuariosController : Controller
    {
        private  List<string> Usuarios = new List<string>(); 
        private SIPAMU_Entities db = new SIPAMU_Entities();

        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            var seg_usuario = db.SEG_USUARIO.Include(s => s.CAT_PERSONA).Include(s => s.SEG_PERFIL);
            return View(seg_usuario.ToList());
        }

        //
        // GET: /Usuarios/Details/5

        public ActionResult Details(int id = 0)
        {
            SEG_USUARIO seg_usuario = db.SEG_USUARIO.Find(id);
            if (seg_usuario == null)
            {
                return HttpNotFound();
            }
            return View(seg_usuario);
        }

        //
        // GET: /Usuarios/Create

        public ActionResult Create()
        {
            ViewBag.I_IDPERSONA = new SelectList(db.CAT_PERSONA, "I_IDPERSONA", "VC_IDENTIFICACION");
            ViewBag.I_IDPERFIL = new SelectList(db.SEG_PERFIL, "I_IDPERFIL", "VC_DESCRIPCION");
            return View();
        }

        //
        // POST: /Usuarios/Create

        [HttpPost]
        public ActionResult Create(SEG_USUARIO seg_usuario)
        {
            if (ModelState.IsValid)
            {
                db.SEG_USUARIO.Add(seg_usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.I_IDPERSONA = new SelectList(db.CAT_PERSONA, "I_IDPERSONA", "VC_IDENTIFICACION", seg_usuario.I_IDPERSONA);
            ViewBag.I_IDPERFIL = new SelectList(db.SEG_PERFIL, "I_IDPERFIL", "VC_DESCRIPCION", seg_usuario.I_IDPERFIL);
            return View(seg_usuario);
        }

        //
        // GET: /Usuarios/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SEG_USUARIO seg_usuario = db.SEG_USUARIO.Find(id);
            if (seg_usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.I_IDPERSONA = new SelectList(db.CAT_PERSONA, "I_IDPERSONA", "VC_IDENTIFICACION", seg_usuario.I_IDPERSONA);
            ViewBag.I_IDPERFIL = new SelectList(db.SEG_PERFIL, "I_IDPERFIL", "VC_DESCRIPCION", seg_usuario.I_IDPERFIL);
            return View(seg_usuario);
        }

        //
        // POST: /Usuarios/Edit/5

        [HttpPost]
        public ActionResult Edit(SEG_USUARIO seg_usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seg_usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.I_IDPERSONA = new SelectList(db.CAT_PERSONA, "I_IDPERSONA", "VC_IDENTIFICACION", seg_usuario.I_IDPERSONA);
            ViewBag.I_IDPERFIL = new SelectList(db.SEG_PERFIL, "I_IDPERFIL", "VC_DESCRIPCION", seg_usuario.I_IDPERFIL);
            return View(seg_usuario);
        }

        //
        // GET: /Usuarios/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SEG_USUARIO seg_usuario = db.SEG_USUARIO.Find(id);
            if (seg_usuario == null)
            {
                return HttpNotFound();
            }
            return View(seg_usuario);
        }

        //
        // POST: /Usuarios/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SEG_USUARIO seg_usuario = db.SEG_USUARIO.Find(id);
            db.SEG_USUARIO.Remove(seg_usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public void validaCorreo(string VC_LOGIN)
        {
            if (VC_LOGIN.Contains("@inamu.go.cr"))
            {
                System.Windows.Forms.MessageBox.Show("Correo inamu");
            }

        }

        [HttpPost]
        public ActionResult VerificarUsuario(SEG_USUARIO seg_usuario)
        {
            //DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, Environment.UserDomainName);
            //Domain domain = Domain.GetDomain(dc);
            //DirectoryEntry de = domain.GetDirectoryEntry();

            //ObtenerUsuarios(de);

            if (seg_usuario.VC_LOGIN.Contains("@inamu.go.cr"))
            {
                System.Windows.Forms.MessageBox.Show("Correo inamu");
            }
 

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        private void ObtenerUsuarios(DirectoryEntry de)
        {
            DirectorySearcher deSearch = new DirectorySearcher(de);

            deSearch.Filter = "(&(objectClass=user)(objectCategory=person))";
            SearchResultCollection results = deSearch.FindAll();

            foreach (SearchResult srUser in results)
            {
                DirectoryEntry deUser = srUser.GetDirectoryEntry();

                int flag = (int)deUser.Properties["userAccountControl"].Value;

                bool mActivo = false;
                if (!Convert.ToBoolean(flag & 0x0002)) mActivo = true;

                if (deUser.Properties["sAMAccountName"].Value.ToString().Contains(".") && mActivo)
                    Usuarios.Add(deUser.Properties["sAMAccountName"].Value.ToString());
            }
        }

        [HttpGet]
        public string ValidateUser(string userName)
        {
            return UserExists(userName)? "Usuario NO disponible." : "Usuario disponible";
        }

        public static bool UserExists(string objectPath)
        {
            bool found = false;
            try 
	        {	        
                if (DirectoryEntry.Exists("WinNT://BABEL/" + objectPath))
                {
                    found = true;
                }
                return found;
                }
	        catch (Exception)
	        {		
		        return found;
	        }
        }
    }
}