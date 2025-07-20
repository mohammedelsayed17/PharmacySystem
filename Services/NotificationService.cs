using System;

namespace PharmacySystem.Services
{
    // Dummy implementation
    public class NotificationService : INotificationService
    {
        public void Notify(string message)
        {
            // This is just a placeholder service, won't be used
            Console.WriteLine("Notification: " + message);
        }
    }
}
