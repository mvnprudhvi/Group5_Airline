﻿using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    //represents customer business logic layer 
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        CustomerDataAccessLayer _CustomerDataAccessLayer;
        public CustomerBusinessLogicLayer()
        {
            _CustomerDataAccessLayer = new CustomerDataAccessLayer();
        }
       /// <summary>
       /// validating User Name
       /// </summary>
       /// <param name="customer"></param>
        public void AddUserName(Customer customer)
        {
            if (customer.UserName != null)
            {
                _CustomerDataAccessLayer.Add(customer);
            }
            else
            {
                throw new Exception("Username can't be null");
            }
        }

        /// <summary>
        /// validating Mobile numbber
        /// </summary>
        /// <param name="customer"></param>
        public void AddmobileNumber(Customer customer)
        {
            if (customer.MobileNumber <= 10)
            {
                _CustomerDataAccessLayer.Add(customer);
            }
            else
            {
                Console.WriteLine(" Invalid Mobile Number ");
            }
        }

        //get customer
        public List<Customer> GetCustomers()
        {
            return _CustomerDataAccessLayer.GetCustomer();
        }
        

        /// <summary>
        /// update existing password
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateExistingCustomer(Customer customer)
        {
            if (customer.Password != null)
            {
                _CustomerDataAccessLayer.UpdateCustomer(customer);
            }
        }
    }
}