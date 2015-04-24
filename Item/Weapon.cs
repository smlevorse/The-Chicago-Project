﻿//Josiah DeVizia

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TheChicagoProject.GUI;

namespace TheChicagoProject.Item
{
    public class Weapon : Item
    {
        public int rateOfFire;
        private int damage;
        private double reloadTime;
        public int maxClip;
        private int loadedAmmo;
        public double accuracy;

        /// <summary>
        /// Creates a new Weapon Object
        /// </summary>
        /// <param name="rof">The rate of fire of the the Weapon</param>
        /// <param name="dam">The amount of damage the gun does</param>
        /// <param name="reload">The reload time, between 1 and 4 seconds</param>
        /// <param name="name">The name of the gun</param>
        /// <param name="maxClip">The amount of ammo in a fully loaded clip</param>
        /// <param name="accuracy">The angle of the scan on the gun</param>
        public Weapon(int rof, int dam, double reload, string name, int maxClip, double accuracy)
        {
            rateOfFire = rof;
            damage = dam;
            reloadTime = reload;
            this.name = name;
            this.maxClip = maxClip;
            loadedAmmo = maxClip;
            this.accuracy = accuracy;
        }

        /// <summary>
        /// Gets and sets the Damage of the gun
        /// Must be between 1 and 3
        /// </summary>
        public int Damage
        {
            get { return damage; } 
            
            set
            {
                if(value >= 3 || value <= 1)
                {
                    return;
                }

                damage = value;
            }
        }

        /// <summary>
        /// Gets and sets the Reload Time
        /// </summary>
        public double ReloadTime
        {
            get { return reloadTime; }
            
            set
            {
                if(value < 1D || value > 4D)
                {
                    return;
                }

                reloadTime = value;
            }
        }

        /// <summary>
        /// Returns the amount of ammo loaded into the gun
        /// </summary>
        public int LoadedAmmo { get { return loadedAmmo; } set { loadedAmmo = value; } }

        /// <summary>
        /// Reloads the gun
        /// </summary>
        /// <param name="ammo"></param>
        /// <returns>The amount of ammmo loaded into the gun</returns>
        public int Reload(int ammo)
        {
            if(ammo >= maxClip)
            {
                loadedAmmo = maxClip;
                return maxClip;
            }
            else if(ammo > 0)
            {
                loadedAmmo = ammo;
                return ammo;
            }
            else
            {
                return 0;
            }
        }
    }
}
