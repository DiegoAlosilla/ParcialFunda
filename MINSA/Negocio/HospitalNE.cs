using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Negocio
{
    public class HospitalNE
    {

        public  Model1 context = new Model1();

        public void insertarHsopital(Hospital hp)
        {
           context.Hospitals.Add(hp);
            context.SaveChanges();
        }




        public void updateHsopital(Hospital hp)        {
            context.Hospitals.Find(hp.Numero_de_Identificacion);
            context.SaveChanges();
        }



        public List<Hospital> listarHospitales()
        {
            return  context.Hospitals.ToList();
        }

    }
}
