﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using TheChicagoProject.Entity;

namespace TheChicagoProject.AI
{
    /// <summary>
    /// Death from afar.
    /// Will shoot you from 10-13 tiles, preferrably.
    /// Will only run if you're within 8 tiles.
    /// 
    /// Ashwin Ganapathiraju
    /// </summary>
    public class HighAI : AI
    {
        public HighAI(LivingEntity entity)
            : base(entity) {

        }

        public override void Update(GameTime time, EntityManager manager) {
            DijkstraMap map = manager.world.playerMap;
            // Float --> int
            int dist = map.Map[entity.location.IntX][entity.location.IntY];
            Direction furtherDir = findPos(map, -1);
            Direction closerDir = findPos(map, 1);
            if (dist < 8) {
                entity.direction = furtherDir;
                entity.Move();
            } else if (dist < 14) {
                entity.direction = closerDir;
                entity.Attack(0, entity.inventory.GetEquippedPrimary());
            } else {
                entity.direction = closerDir;
                entity.Move();
            }
        }
    }
}
