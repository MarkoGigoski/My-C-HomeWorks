using System.Reflection.Metadata;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3
            Console.WriteLine("Exercise 3");
            /*
            * Create a class User with the following:
            - Id - int
            - Username - string
            - Password - string
            - Messages - Array of strings

            * Create an array of users and add 3 users to it manually ( hard-coded ).
            * 
            * Create a Console UI that will give the user two options to choose from:
             1.  Log in - When selected, the user should be asked for username and password.
            * If the user is found print welcome message and the messages that the user has in the Messages property:
            - Welcome NAME. Here are your messages:
            - Message1
            - Message2
            - If not found, it should print an error message

            2.  Register - When selected the user should be asked to enter ID, Username and password.
            It should then check if a there is already a username in the array of users like that.
            If there is, print a message that there is already a user called like that. If not,
            create a new user object from the information given in the console and add it to the Users array.
            Then print all the users by Id and Username

            - Registration complete! Users
            - 23 Username1
            - 44 Username2
            - 1 Username3
            - 56 Username4**
            */

            User[] users = new User[3];
            users[0] = new User(1, "userOne", "passwordOne", new string[2] { "message 1 of userOne", "message 2 of userOne" });
            users[1] = new User(2, "userTwo", "passwordTwo", new string[2] { "message 1 of userTwo","message 2 of userTwo" });
            users[2] = new User(3, "userThree","passwordThree", new string[2] {"message 1 of userThree","message 2 of userThree"});

            Console.WriteLine(" Type L for Login \n Or \n Type R for Register");
            string choise = Console.ReadLine();

            if (choise == "L" || choise == "l")
            {
                Console.Write("Enter Username: ");
                string usernameChek = Console.ReadLine();
                Console.Write("Enter Password: ");
                string passwordChek = Console.ReadLine();

                foreach(User u in users)
                {
                    if(u.Username != usernameChek && u.Password != passwordChek)
                    {
                        Console.WriteLine("User not found, try with a diferent user.");
                        // how can i stop this msg from showing if there is none only on the first rotation? and second or 3rd are actualy found:(??
                    }
                    else
                    {
                        Console.WriteLine($"WELCOME {u.Username}. Here are your messages: \n {u.Messages[0]} \n {u.Messages[1]}");
                        return;
                    }
                }
            }
            else if(choise == "R" || choise == "r")
            {
                Console.Write("Enter your new Username: ");
                string newUsername = Console.ReadLine();

                foreach(User newU in users)
                {
                    if(newU.Username == newUsername)
                    {
                        Console.WriteLine("User with that Username already exist!");
                        return;
                    }
                    
                }
                
                Console.Write("Enter your Password: ");
                string newPassword = Console.ReadLine();

                string[] newUserMsgs = new string[0];
                int newInt = users.Length + 1;

                User newUser = new User(newInt, newUsername, newPassword, newUserMsgs);

                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = newUser;
            }
            else
            {
                Console.WriteLine("You have enetered a wrong input");
            }

            foreach(User f in users)
            {
                Console.WriteLine($"- {f.Id}. {f.Username}");
            }
        }
    }
}