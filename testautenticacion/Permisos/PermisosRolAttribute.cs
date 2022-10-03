using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testautenticacion.Models;

namespace testautenticacion.Permisos
{
    public class PermisosRolAttribute : ActionFilterAttribute
    {
        private Rol rol;


        public PermisosRolAttribute(Rol _rol) {

            rol = _rol;
        }



        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["User"] != null) {

                Users user = HttpContext.Current.Session["User"] as Users;


                if (user.rol != this.rol) {

                    filterContext.Result = new RedirectResult("~/Home/SinPermiso");
                
                }


            }



            base.OnActionExecuting(filterContext);
        }



    }
}