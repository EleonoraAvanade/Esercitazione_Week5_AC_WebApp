using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.BusinessLayer
{
    public class MainBusinessLayer:IBusinessLayer
    {
        private readonly IAccountRepository accountRepository;
        private readonly IPiattoRepository piattoRepository;
        public MainBusinessLayer(IAccountRepository a, IPiattoRepository p)
        {
            accountRepository = a;
            piattoRepository = p;
        }

        public ItemResult AddNewPiatto(Piatto p)
        {
            if(p==null)
            {
                throw new ArgumentNullException();
            }
            bool res=piattoRepository.Add(p);
            if (res)
            {
                return new ItemResult
                {
                    Res=true,
                    Msg="Added"
                };
            }
            return new ItemResult
            {
                Res=false,
                Msg="Not added"
            };
        }

        public ItemResult DeletePiatto(Piatto p)
        {
            if (p == null)
            {
                throw new ArgumentNullException();
            }
            bool res = piattoRepository.Delete(p);
            if (res)
            {
                return new ItemResult
                {
                    Res = true,
                    Msg = "Deleted"
                };
            }
            return new ItemResult
            {
                Res = false,
                Msg = "Not deleted"
            };
        }

        public ItemResult EditPiatto(Piatto p)
        {
            if (p == null)
            {
                throw new ArgumentNullException();
            }
            bool res = piattoRepository.Update(p);
            if (res)
            {
                return new ItemResult
                {
                    Res = true,
                    Msg = "Updated"
                };
            }
            return new ItemResult
            {
                Res = false,
                Msg = "Not updated"
            };
        }

        public IEnumerable<Piatto> Read()
        {
            return piattoRepository.Read();
        }

        public Account GetAccount(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            return accountRepository.GetByUsername(username);
        }

        public Piatto GetPiattoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return piattoRepository.Read().FirstOrDefault(k=>k.Id==id);
        }
        public ItemResult AddAccount(Account p)
        {
            if (p == null)
            {
                throw new ArgumentNullException();
            }
            bool res = accountRepository.Add(p);
            if (res)
            {
                return new ItemResult
                {
                    Res = true,
                    Msg = "Added"
                };
            }
            return new ItemResult
            {
                Res = false,
                Msg = "Not added"
            };
        }
    }
}
