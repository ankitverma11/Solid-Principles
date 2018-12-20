using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinicipals
{
    public class DIPPrinciple
    {
        //2.5 Dependency inversion principle(DIP)
        //This principle tells you not to write any tightly coupled code because that is a nightmare to maintain when the application is growing bigger and bigger.If a class depends on another class, 
        //then we need to change one class if something changes in that dependent class. We should always try to write loosely coupled class.
    }


    public class Email
    {
        public void Sendmail()
        {

        }
    }
    public class Notification_Tightly
    {
        private Email _email;
        public Notification_Tightly()
        {
            _email = new Email();
        }
        public void PromotionalNotification()
        {
            _email.Sendmail();
        }
        //Now Notification class totally depends on Email class, because it only sends one type of notification.If we want to introduce any other like SMS then? We need to change the notification system also.And this is called tightly coupled.
    }

    // Now, we can use dependency injection so that we can make it loosely coupled.There are 3 types to DI, Constructor injection, Property injection and method injection.

    public interface IMessenger
    {
        void SendMessage();
    }

    // Constructor Injection

    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification (IMessenger pmessenger)
        {
            _iMessenger = pmessenger;
        }

        public void DoNotify()
        {
             _iMessenger.SendMessage();
        }
    }

    //Property Injection
    public class NotificationP
    {
        private IMessenger _iMessenger;

        public NotificationP()
        {
        }

        public IMessenger MessageService
        {
            //private get;
            set
            {
                _iMessenger = value;
            }
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }

    //Method Injection

    public class NotificationM
    {
        public void DoNotify(IMessenger pmessanger)
        {
            pmessanger.SendMessage();
        }
    }

   // SOLID principle will help us to write loosely coupled code which is highly maintainable and less error prone.
  }
