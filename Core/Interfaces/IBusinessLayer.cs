using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IBusinessLayer
    {
        IEnumerable<Piatto> Read();
        Piatto GetPiattoById(int id);
        ItemResult AddNewPiatto(Piatto newEmp);
        ItemResult EditPiatto(Piatto data);
        ItemResult DeletePiatto(Piatto data);
        ItemResult AddAccount(Account p);
        Account GetAccount(string username);
    }
}
