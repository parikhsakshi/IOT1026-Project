﻿using MinotaurLabyrinth;

namespace MinotaurLabyrinthTest
{
    ///Class
    [TestClass]
    public class RoomTests
    {
        ///Method
        [TestMethod]
        public void PitRoomTest()
        {
            // Seed the RandomNumberGenerator so the sequence of random numbers
            // is deterministic
            RandomNumberGenerator.SetSeed(1);

            Pit pitRoom = new Pit();
            Hero hero = new Hero();
            Map map = new Map(1, 1);

            pitRoom.Activate(hero, map);
            Assert.AreEqual(pitRoom.IsActive, false);
            Assert.AreEqual(hero.IsAlive, true);

            hero.HasSword = true;
            pitRoom.Activate(hero, map);
            //Hero should not die because pitRoom is inactive here
            Assert.AreEqual(hero.IsAlive, true);

            Pit newPitRoom = new Pit();
            newPitRoom.Activate(hero, map);
            Assert.AreEqual(hero.IsAlive, true);

            newPitRoom.Activate(hero, map);
            newPitRoom = new Pit();
            newPitRoom.Activate(hero, map);
            Assert.AreEqual(hero.IsAlive, false);
        }

        [TestClass]
        public class MonsterTests
        {
            [TestMethod]

            public void MinotaurTest()
            {
                Hero hero = new Hero();
                Minotaur minotaur = new Minotaur();
                Map map = new Map(4, 4);
                hero.HasSword = true;
                Assert.AreEqual(hero.HasSword, true);

                minotaur.Activate(hero, map);
                //Change moves the hero 1 room east and 2 rooms north
                // -1 is off the map so hero position should be (0,2)
                Assert.AreEqual(hero.Location, new Location(0, 2));
                Assert.AreEqual(hero.HasSword, false);

                minotaur.Activate(hero, map);
                Assert.AreEqual(hero.Location, new Location(0, 3));

                hero.Location = new Location(3, 1);
                minotaur.Activate(hero, map);
                Assert.AreEqual(hero.Location, new Location(2, 3));
            }
        }

        [TestMethod]

        public void GelMoveTest()
        {
            Hero hero = new Hero();
            var gelLocation = new Location(1, 1);
            Doreamon gel = new(gelLocation);
            Map map = new Map(4, 4);
            map.GetRoomAtLocation(gelLocation).AddMonster(gel);
            map.SetRoomAtLocation(new Location(2, 1), RoomType.Pit);




            gel.Move(hero, map);
            //New location should be (1,1)
            var expectedLocation = new Location(2, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
            gel.Move(hero, map);
            expectedLocation = new Location(3, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
            gel.Move(hero, map);
            expectedLocation = new Location(3, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
        }
    }
}