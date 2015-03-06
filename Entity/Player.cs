﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheChicagoProject.Item;

namespace TheChicagoProject.Entity
{

    enum Direction
    {
        Up,
        UpRight,
        Right,
        DownRight,
        Down,
        DownLeft,
        Left,
        UpLeft
    }

    class Player : Entity
    {
        public Weapon[] holster;
        private int activeWeapon;
        private int cash;
        private int questPoints;
        private int lives;
        public Direction direction;
        public Quests.QuestLog log;

        private double lastShot;    //The time of the last time the player shot

        public Player()
        {
            holster = new Weapon[10];
            activeWeapon = 0;
            cash = 40;
            questPoints = 0;
            lives = 4;
            direction = Direction.Up;
        }

        //properties
        public int Cash { get { return Cash; } set { cash = value;/*maybe implement rule that cash cannot be < 0*/} }
        public int QuestPoints { get { return questPoints; } 
            set 
            { 
                questPoints = value;
                lives = QuestPointsToLives(questPoints);
                /****************************************************
                 *                                                  *
                 *    Display Message About getting a new heart?    *
                 *                                                  *
                 ****************************************************/
            } }

        /// <summary>
        /// The player attacks
        /// </summary>
        /// <param name="type">0 is primary fire, 1 is secondary</param>
        public void Attack(int type)
        {
            if(type == 0)
            {

            }
        }

        /// <summary>
        /// Reloads the active weapon
        /// </summary>
        public void Reload()
        {

        }

        /// <summary>
        /// Interacts with the environment
        /// </summary>
        public void Interact()
        {

        }

        /// <summary>
        /// Gets and sets the active weapon, if the incoming switch is invalid, it changes it to the first weapon
        /// </summary>
        public int ActiveWeapon
        {
            get
            {
                return activeWeapon;
            }

            set
            {
                if (holster[value] == null)
                    activeWeapon = 1;
            }
        }


        /// <summary>
        /// calculates the number of lives the player should have based on the number of quest points
        /// </summary>
        /// <param name="qPoints"></param>
        /// <returns></returns>
        private int QuestPointsToLives(int qPoints)
        {
            int newLives = 4 + (int)(2 * System.Math.Sqrt(qPoints));
            return newLives;
        }
    }
}
