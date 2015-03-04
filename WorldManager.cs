﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheChicagoProject.Entity;

namespace TheChicagoProject
{

    /// <summary>
    /// Manages the worlds (maps) of the game.
    /// </summary>
    class WorldManager
    {
        public static Player player;
        public Dictionary<String, World> worlds;
        private String current;

        public World CurrentWorld {
            get { return worlds[current]; }
        }

        public WorldManager() {
            worlds = new Dictionary<String, World>();
            //TODO: Load/Save worlds.
            current = "main";
        }
    }
}
