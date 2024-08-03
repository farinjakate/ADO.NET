using Birthday_Messanger_Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Messanger_Scheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Friendship friendship = new Friendship();
            List<Friend> friends = friendship.GetFriendsWithTodayBirthday();

            foreach (Friend myfriend in friends)//var item in List(object)
            {  
                Console.WriteLine($"Friend_ID :{myfriend.Id}\n " +
                    $"Friend Name:{myfriend.Name} \n" +
                    $"DOB:{myfriend.DateOfBirth}\n" +
                    $"Friend_Mobile:{myfriend.Mobile}\n " +
                    $"Massage :{myfriend.WhatsAppMessage}\n" +
                    $"Email:{myfriend.Email}\n " +
                    $"Message Sent Time: @{DateTime.Now}\n");
               
            }
            Console.ReadLine();
        }
    }
}





