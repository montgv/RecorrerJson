using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecorrerJson
{
    public class Cliente
    {
        public string dni;
        public string nombre;
        public int telef;
        public string email;
        public Propiedades propiedades;

        public Cliente(string d, string n, int t, string e, Propiedades p)
        {
            dni = d;
            nombre = n;
            telef = t;
            email = e;
            propiedades = p;
        }
    }

    public class Propiedades
    {
        public int referencia;
        public string direccion;
        public string localidad;
        public string descripcion;
        public int cuota;

        public Propiedades(int refer, string dir, string loc, string desc, int cuo)
        {
            referencia = refer;
            direccion = dir;
            localidad = loc;
            descripcion = desc;
            cuota = cuo;
        }
    }

    public class BaseDeDatos<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public BaseDeDatos(string ruta)
        {
            this.ruta = ruta;
        }

        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                //Para poder usar JsonConvert tenemos que irnos a Referencias/Administrar paquetes NuGet
                //y buscamos Newtonsoft.Json e instalamos y despues tenemos que importar el using
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            } 
            catch(Exception e) { }
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }
    }
}
