﻿//created by Madhumitha.....
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>


namespace Znalytics.Group5.DataAccessLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    class TicketCancellationDataAccessLayer : ITicketCancellationDataAccessLayer
    {
        private static List<TicketCancellation> CancellationID
        {
            set;
            get;
        }
        //constructor

        static TicketCancellationDataAccessLayer()
        {

            CancellationID = new List<TicketCancellation>()
            {

           new TicketCancellation() { customerID = "12345", bookingID = "67890", seatNumber = "01", date = "2020-08-29", cancellationId = "23" }
          new TicketCancellation() { customerID = "12345", bookingID = "67890", seatNumber = "01", date = "2020-08-29", cancellationId = "23" }
          new TicketCancellation() { customerID = "12345", bookingID = "67890", seatNumber = "01", date = "2020-08-29", cancellationId = "23" }
            };
        }
        //methods to add ticket cancellation
        public void AddTicketCancellations(TicketCancellation bookingId)
        {
            if (CancellationID.Exists(temp => temp.customerID == bookingId.customerID))
            {
                CancellationID.Add(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //methods to update ticket cancellation
        public void UpdateTicketCancellations(TicketCancellation bookingId)
        {
            if (CancellationID.Exists(temp => temp.customerID == bookingId.customerID))
            {
                CancellationID.Update(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //method to get ticket cancellation by ticket cancellation id
        public TicketCancellation GetTicketCancellationsByCancellationID(int cancellationID)
        {
            return CancellationID.Find(temp => temp.cancellationID == cancellationID);
        }
        //method to get ticket cancellation by ticket customer id
        public TicketCancellation GetTicketCancellationsByCustomerID(int customerID)
        {
            return CancellationID.Find(temp => temp.cancellationID == customerID);
        }
        //method to get ticket cancellation by ticket booking id
        public TicketCancellation GetTicketCancellationsByBookingID(int bookingID)
        {
            return CancellationID.Find(temp => temp.cancellationID == bookingID);
        }
    }
}



        /*//method to display the added booking id
        public List<TicketCancellation> GetTicketCancellations()
        {
            return TicketCancellationDataAccessLayer.CancellationID();
        }
        //method to display ticket cancellation by ticket cancellation id
        public TicketCancellation GetTicketCancellationByCancellationID(int customerId)
        {
            return TicketCancellationDataAccessLayer.GetTicketCancellationByCancellationID(CancellationID);
        }
    }
}


        //represents adding ticket cancellation
        public void AddTicketCancellation(TicketCancellation ticketCancellation)
        {
            _TicketCancellation = Add(ticketCancellation);
        }
        //Updation of  ticket cancellation
        public void UpdateTicketCancellation(TicketCancellation CustomerID)
        {
            //Get matching ticket cancellation based on CustomerId
            TicketCancellation tc = TicketCancellation.Find(temp => temp.CustomerID == customer.CustomerID);
            if (CustomerID != null)
            {
                TicketCancellation.CustomerID = TicketCancellation.CustomerID;
            }
        }
        public TicketCancellation GetTicketCancellationsByCustomerID(int CustomerID)
        {
            //get ticket cancellation by customer id
            TicketCancellation tc = TicketCancellation.FindAll(temp => temp.CustomerID == customer.CustomerID);
            if (CustomerID != null)
            {
                TicketCancellation.CustomerID = TicketCancellation.CustomerID;
            }
        }
        public TicketCancellation GetTicketCancellationsByBookingID(int BookingID)
        {
            TicketCancellation tc = TicketCancellation.FindAll(temp => temp.BookingID == CustomerID);
            if (CustomerID != null)
            {
                TicketCancellation.CustomerID = TicketCancellation.CustomerID;
            }
        }
    }

    public TicketCancellation GetTicketCancellationsByCancellationID(int CustomerID)
        {

        }


           /* //represents Get  bookingid
            public List<TicketCancellation> GetbookingId()
        {
            return _flights;
        }


        //add date
        public void Adddate(TicketCancellation date)
        {
            _flights.Add(date);
        }

        //Get  date
        public List<TicketCancellation> Getdate()
        {
            return _flights;
        }
        //update date
        public void updatedate(TicketCancellation date)
        {
            _flights.Add(date);
        }
       }

}*/








/*using System.Collections.Generic;
using Znalytics.Group5.AirLine.CancellationModule.Entities;

namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
{
    public class FlightCancellationDataAccessLayer : CancellationDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName)
        {
            ////flight generating 

            //flight.Add(flight);

            //not done
        }
    }
}*/
