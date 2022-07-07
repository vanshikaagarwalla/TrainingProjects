using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    public class Event
    {
        public int EventId;
        public void CreateEvent()
        {
            int eventId;
            string Eventname;
            string Eventtype;
            string EventDescription;
        }
        public void SelectEvents()
        {
            Console.WriteLine("Event selected!");
        }
    }
    public class Customer
    {
        public int CustomerId;  
        public void CreateCustomer()
        {
            Console.WriteLine("Customer Created!");
        }
        public void SelectCustomer()
        {
            Console.WriteLine("Customer selected!");
        }
    }

    public class EventBooking
    {
        public int CustomerId;
        public void CreateEventBooking()
        {
            Console.WriteLine("EventBooking Created!");
        }
        public void SelectEventBooking()
        {
            Console.WriteLine("EventBooking selected!");
        }
    }
}
