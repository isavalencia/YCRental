using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Car.Modelo;

namespace Car
{
    class CDatosAlquiler
    {
        yalexrentaEntities2 db;

        public void Create(alquilere palquileres)
        {
            try
            {
                using (db = new yalexrentaEntities2())
                {
                    db.alquileres.Add(palquileres);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

        public List<alquilere> Read()
        {
            try
            {
                using (db = new yalexrentaEntities2())
                {
                    return db.alquileres.ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(alquilere palquilere) 
        {
            try
            {
                using (db = new yalexrentaEntities2())
                {
                    db.Entry(palquilere).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(int pid_alquiler)
        {
            try
            {
                using (db = new yalexrentaEntities2())
                {
                    db.alquileres.Remove(db.alquileres.Single
                        (p => p.id_alquiler == pid_alquiler));
                    db.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<alquilere> buscarIdAlquiler(int pid_alquiler)
        {
            try
            {
                using (db = new yalexrentaEntities2())
                {
                   return db.alquileres.Where(p => p.id_alquiler == pid_alquiler).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        
    }
}
