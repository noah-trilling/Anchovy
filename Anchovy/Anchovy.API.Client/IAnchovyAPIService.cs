﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Anchovy.API.Client;
using Microsoft.Rest;

namespace Anchovy.API.Client
{
    public partial interface IAnchovyAPIService : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        ICooks Cooks
        {
            get; 
        }
        
        ICrusts Crusts
        {
            get; 
        }
        
        ICustomers Customers
        {
            get; 
        }
        
        ILines Lines
        {
            get; 
        }
        
        IManagers Managers
        {
            get; 
        }
        
        IMenuListings MenuListings
        {
            get; 
        }
        
        IOrderLines OrderLines
        {
            get; 
        }
        
        IOrders Orders
        {
            get; 
        }
        
        IPizzas Pizzas
        {
            get; 
        }
        
        IPizzaToppings PizzaToppings
        {
            get; 
        }
        
        ISauces Sauces
        {
            get; 
        }
        
        IShifts Shifts
        {
            get; 
        }
        
        ISizes Sizes
        {
            get; 
        }
        
        IToppings Toppings
        {
            get; 
        }
    }
}
