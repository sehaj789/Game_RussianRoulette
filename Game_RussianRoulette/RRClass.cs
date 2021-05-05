using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game_RussianRoulette
{
    public class RRClass
    {
        // initial variable setting
        public int Bullet; // bullet
        public int Shot = 0; // shot total 1-6
        public int Shot1 = 0; // shot to yourself
        public int Shot2 = 0; // shot to air
        public int Point = 0; // points 

        public void Load()
        {
            Bullet = 0;
        }

        public void Spin()
        {
            // setting Bullet in random number placing 0-5
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
        }
        public void Sound()
        {
            // sound starts after clicking Fire1 (Fire yourself).
            SoundPlayer player = new SoundPlayer(ResourcesFile.Sound);
            player.Play();
        }
        public void BulletA()
        {
            // bullet shifts next location
            Bullet = Bullet + 1;
        }
        public void BulletB()
        {
            if (Bullet < 6)
            {
                // checking actual bullet number in the console
                Console.WriteLine("Bullet is at: " + Bullet);
            }
        }
        public void PointA()
        {
            // winning case as adding ten points
            Point = Point + 10;
        }
        public void PointB()
        {
            // survived case as adding one point 
            Point = Point + 1;
        }
        public void PointC()
        {
            // setting bullet = 5 as firing bullet which means dead.
            Point = Point - 5;
        }
        public void ShotA()
        {
            // calculationg total shot counts and display
            Shot1 = Shot1 + 1;
            Shot = Shot1 + Shot2;
        }
        public void ShotB()
        {
            // counting shot total
            Shot2 = Shot2 + 1;
            Shot = Shot1 + Shot2;
        }
    }
}