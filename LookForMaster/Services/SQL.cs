using BookStore.Data;
using LookForMaster.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookForMaster.Services;

public class SQL
{
    public async static Task<List<Customer>> GetCustomers()
    {
        var customer = App.DIContainer.GetInstance<LookForMasterDbContext>().Customers.ToList();
        return customer;
    }

    public async static Task<List<Master>> GetMasters()
    {
        var masters = App.DIContainer.GetInstance<LookForMasterDbContext>().Masters.ToList();
        return masters;
    }

    public async static void AddCustomer(Customer customer)
    {
        App.DIContainer.GetInstance<LookForMasterDbContext>().Customers.Add(customer);
        App.DIContainer.GetInstance<LookForMasterDbContext>().SaveChanges();
    }

    public async static void AddMaster(Masters master)
    {
        App.DIContainer.GetInstance<LookForMasterDbContext>().Masters.Add(master);
        App.DIContainer.GetInstance<LookForMasterDbContext>().SaveChanges();
    }

}
