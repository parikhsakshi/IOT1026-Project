/*
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace MinotaurLabyrinth
=======
namespace MinotaurLabyrinth
>>>>>>> f2cafba (Gaming method A1)
=======
﻿namespace MinotaurLabyrinth
>>>>>>> dca1384 (Gaming method)

{
    /// <summary>
    /// Represents a portal room, which contains portal that can take the sword.
    ///</summary>
<<<<<<< HEAD
    // name class Game
=======
>>>>>>> f2cafba (Gaming method A1)
    public class Game : Room
    {
        static Game()
        {
            RoomFactory.Instance.Register(RoomType.Room, () => new Game());
        }
        /// <inheritdoc/>
        public override RoomType Type { get; } = RoomType.Room;

        ///<inheritdoc/>
        public override bool IsActive { get; protected set; } = true;

        /// <summary>
        /// Activates the portal, making the user to  automatically lose consequences.
        ///</summary>
        public override void Activate(Hero hero, Map map)
        {
            if (IsActive)
            {
                ConsoleHelper.WriteLine("You walk into the room and feel the prresence of a portal to another dimension .", ConsoleColor.DarkYellow);
                ///Could update the probabilities to be based on the hero abilities
                double chanceOfSuccess = hero.HasSword ? 0.25 : 0.75;


                if (hero.HasSword)
                {
                    ConsoleHelper.WriteLine("You desperately try to run away from the portal and grab the sword firmly.", ConsoleColor.DarkGreen);
                    if (RandomNumberGenerator.NextDouble() < chanceOfSuccess)
                    {
                        IsActive = false;
                        ConsoleHelper.WriteLine("You manage to successufully escape from the portal suddenly the portal dissapear. Now run to the exit.", ConsoleColor.DarkGreen);

                    }
                    else
                    {
                        ConsoleHelper.WriteLine("You manage to successfully escape from the portal but instead, you lost the sword, yo will have to retreive it again.", ConsoleColor.DarkGreen);
                    }
                }



            }
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
}
=======
}
>>>>>>> f2cafba (Gaming method A1)
=======
}
>>>>>>> dca1384 (Gaming method)
*/
