using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrWork.Repository
{
    public class EFAccountRepository : IAccountRepository
    {
        private readonly RistoranteContext ctx;
        public EFAccountRepository(RistoranteContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Account obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                ctx.Accounts.Add(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Account obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            try
            {
                ctx.Accounts.Remove(obj);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Account GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException();
            }
            return Read().FirstOrDefault(k => k.Id == id);
        }

        public Account GetByUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException();
            }
            try
            {
                return ctx.Accounts.FirstOrDefault(x => x.Username.Equals(username));
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<Account> Read()
        {
            return ctx.Accounts.ToList();
        }

        public bool Update(Account obj)
        {
            throw new NotImplementedException();
        }
    }
}
