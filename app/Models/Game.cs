using escape_corona.Interfaces;

namespace escape_corona.Models
{
  class Game : IGame
  {
    public IPlayer CurrentPlayer { get; set; }
    public IRoom CurrentRoom { get; set; }

    ///<summary>Initalizes data and establishes relationships</summary>
    public Game()
    {
      // NOTE ALL THESE VARIABLES ARE REMOVED AT THE END OF THIS METHOD
      // We retain access to the objects due to the linked list


      // NOTE Create all rooms
      Room welcome = new Room("Welcome To the GAME", @"
            
   _____________  __________ __    _____   __   ________  ________   _________    __  _________
  / ___/_  __/ / / / ____/ //_/   /  _/ | / /  /_  __/ / / / ____/  / ____/   |  /  |/  / ____/
  \__ \ / / / / / / /   / ,<      / //  |/ /    / / / /_/ / __/    / / __/ /| | / /|_/ / __/   
 ___/ // / / /_/ / /___/ /| |   _/ // /|  /    / / / __  / /___   / /_/ / ___ |/ /  / / /___   
/____//_/  \____/\____/_/ |_|  /___/_/ |_/    /_/ /_/ /_/_____/   \____/_/  |_/_/  /_/_____/   
                                                                                               

            Can you really tell if this is reality? You will probably say yes because you can control your own actions however are you sure those are not dependent on your emotions? aRe YoU ReaLLy In CONtroL? This is a simple game, the best ones are, choose correctly and you will leave this game with your life. I would wish you luck but truthly I alredy know the outcome.");



      Room server = new Room("Server Room", @"
.--.
|__| .-------.
|=.| |.-----.|
|--| || KCK ||
|  | |'-----'|
|__|~')_____('


      This room is full of servers with one terminal in the corner. The room is dark but you can see the glow of lights on the servers. On the terminal reads that these servers are supporting thousands of lives.");



      Room lab = new Room("Lab", @" 
      
      
      
      _---~~(~~-_.
    _{        )   )
  ,   ) -~~- ( ,-' )_
 (  `-,_..`., )-- '_,)
( ` _)  (  -~( -_ `,  }
(_-  _  ~_-~~~~`,  ,' )
  `~ -^(    __;-,((()))
        ~~~~ {_ -_(())
               `\  }
                 { }  
      
      
      You walk into a lab, their are blood stains along the walls and all over the floor, you smell the putrid smell of decaying human bodys as well. You see a white board that has many differnet equations written on it. After looking around a little more you find this is all research on virtual reality and how far you can push the human brain before the person naturally goes insane. This sends shivers down your spine.");

      Room bedroom = new Room("Bedroom", @"
      
      
      
      ______________________________    . \  | / .
     /                            / \     \ \ / /
    |                            | ==========  - -
     \____________________________\_/     / / \ \
  ______________________________      \  | / | \
 /                            / \     \ \ / /.   .
|                            | ==========  - -
 \____________________________\_/     / / \ \    /
      ______________________________   / |\  | /  .
     /                            / \     \ \ / /
    |                            | ==========  -  - -
     \____________________________\_/     / / \ \
                                        .  / | \  .
      
      Its someones bedroom, not yours but hey your not sure where you even are. You look around, the room is dirty and unkept. You sart to look through the room and see explosives in a desk, you can take them. The choice is yours.");

      Room killRoom = new Room("Kill Room", @" 
      
      
      

 ....,       ,....
.' ,,, '.   .' ,,, '.
 .`   `.     .`   `.
: ..... :   : ..... :
:`~'-'-`:   :`-'-'~`:
 `.~-`.'     `.~`'.'
   ```   ___   ```
       ( . . )

        .._..
      .'     '.   
     `.~~~~~~~.`
       `-...-`  
      
      
      It smells like blood, the scent of iron drifting around in the room make you sick to your stomach. a figure appears out of what seems like nowhere. He stands there still giving you a look so crazy its indescribable. There is an exit to the West. If I were you I would get out of there...RIGHT NOW!");




      EndRoom secretExit = new EndRoom("Secret Exit", @" 
   _____          __  __ ______    ______      ________ _____  
  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                               
      
      
      You werent supposed to find this exit, but you did. You used the wire to fix a door that looked broken.", true, "You Have won the game!");

      EndRoom win = new EndRoom("You won", @" 
   _____          __  __ ______    ______      ________ _____  
  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                               
      
      
      Since you used the explosives it blew a whole in the door to the east. You run out and are chased by a crazy man. As soon as you think the coast is clear you feel someone touch you on your shoulder. I toLd YOu, ThIs iS noT YOUr reALIty", true, "You wake up in a place you cant identify, in a different reality.");







      EndRoom trap = new EndRoom("You have been trapped", @"
      
                     ...                            
             ;::::;                           
           ;::::; :;                          
         ;:::::'   :;                         
        ;:::::;     ;.                        
       ,:::::'       ;           OOO\         
       ::::::;       ;          OOOOO\        
       ;:::::;       ;         OOOOOOOO       
      ,;::::::;     ;'         / OOOOOOO      
    ;:::::::::`. ,,,;.        /  / DOOOOOO    
  .';:::::::::::::::::;,     /  /     DOOOO   
 ,::::::;::::::;;;;::::;,   /  /        DOOO  
;`::::::`'::::::;;;::::: ,#/  /          DOOO 
:`:::::::`;::::::;;::: ;::#  /            DOOO
::`:::::::`;:::::::: ;::::# /              DOO
`:`:::::::`;:::::: ;::::::#/               DOO
 :::`:::::::`;; ;:::::::::##                OO
 ::::`:::::::`;::::::::;:::#                OO
 `:::::`::::::::::::;'`:;::#                O 
  `:::::`::::::::;' /  / `:#                  
   ::::::`:::::;'  /  /   `#     
      
      
      
      You are trapped in a room its dark, its scary, its silent. You sit there in fear hoping for something to happen but it never does.", false, "One day you finnaly hear something... you are scared youve been in this room so long you have lost track of time, lights suddenly turn on and all you see is this figure. I guess your time is truly lost.");

      // NOTE Create all Items
      Item w = new Item("Wire", "You unplug the servers. Your not sure if the lives being supported from the servers are dead or not.");

      Item e = new Item("Bomb", "It goes boom");

      // NOTE Make Room Relationships
      welcome.Exits.Add("east", server);
      server.Exits.Add("west", welcome);
      server.Exits.Add("north", lab);
      server.Exits.Add("east", trap);
      lab.Exits.Add("south", server);
      lab.Exits.Add("north", bedroom);
      lab.AddLockedRoom(w, "west", secretExit);
      bedroom.Exits.Add("south", lab);
      bedroom.Exits.Add("north", killRoom);
      killRoom.Exits.Add("west", trap);
      killRoom.AddLockedRoom(e, "east", win);
      secretExit.Exits.Add("east", lab);


      // NOTE put Items in Rooms
      server.Items.Add(w);
      bedroom.Items.Add(e);


      CurrentRoom = welcome;
    }
  }
}