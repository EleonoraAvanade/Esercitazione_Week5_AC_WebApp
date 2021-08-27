using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrWork.Repository
{
    public class EFPiattoRepository : IPiattoRepository
    {
        private readonly RistoranteContext ctx;
        public EFPiattoRepository(RistoranteContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Piatto obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                ctx.Piatti.Add(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Piatto obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                ctx.Piatti.Remove(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Piatto GetById(int id)
        {
            return Read().FirstOrDefault(k=>k.Id==id);
        }

        public List<Piatto> Read()
        {
            return ctx.Piatti.ToList();
        }

        public bool Update(Piatto obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                ctx.Piatti.Update(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
