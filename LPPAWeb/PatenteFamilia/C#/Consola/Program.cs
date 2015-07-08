using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Patente patenteConsulta = new Patente();
            patenteConsulta.Nombre = "Pantalla de Consulta de Ventas";
            BLL.Patente.Insert(patenteConsulta);
            
            Familia familiaConsulta = new Familia();
            familiaConsulta.Nombre = "Rol de Consulta de Ventas";
            familiaConsulta.Add(patenteConsulta);
            BLL.Familia.Insert(familiaConsulta);

            Patente patenteVentas = new Patente();
            patenteVentas.Nombre = "Pantalla de Ventas";
            BLL.Patente.Insert(patenteVentas);

            Familia familiaVentas = new Familia();
            familiaVentas.Nombre = "Rol Ventas";
            familiaVentas.Add(patenteVentas);
            familiaVentas.Add(familiaConsulta);

            BLL.Familia.Insert(familiaVentas);

            Patente patentePantallaUsuario = new Patente();
            patentePantallaUsuario.Nombre = "Pantalla de Administración de Perfil del Usuario";
            BLL.Patente.Insert(patentePantallaUsuario);

            Usuario user = new Usuario();
            user.Nombre = "Pedro Rodriguez";
            user.Permisos.Add(familiaVentas);
            user.Permisos.Add(patentePantallaUsuario);

            BLL.Usuario.Insert(user);

            //Familia familia = BLL.Familia.GetAdapted(familiaVentas.IdFamiliaElement);
            Usuario usuario = BLL.Usuario.GetAdapted(user.IdUsuario);

            Console.WriteLine(String.Format("El usuario {0} tiene los siguientes permisos:", usuario.Nombre));
            MostrarEstructura(usuario.Permisos);

            //List<Patente> patentes = new List<Patente>();

            //foreach (FamiliaElement element in familia)
            //{
            //    if (element.ChildrenCount > 0) 
      
            //    else{
            //        if(!patentes.Exists(o => o.IdFamiliaElement == element.IdFamiliaElement))
            //        patentes.Add(element as Patente);
            //    }
            //}

            Console.ReadLine();

        }

        private static void MostrarEstructura(List<FamiliaElement> familia, String nivel = "-")
        {
            String siguienteNivel = String.Format("{0}-",nivel);

            foreach (FamiliaElement element in familia)
            {
                Console.WriteLine(String.Format("{0}{1}: {2}", nivel, element.GetType().Name, element.Nombre));
                
                if (element.ChildrenCount > 0)                                   
                    MostrarEstructura((element as Familia).Accesos, siguienteNivel);
                 
            }
        }
    }
}
