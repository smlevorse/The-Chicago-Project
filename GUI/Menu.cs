﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheChicagoProject.GUI.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace TheChicagoProject.GUI
{
    // Each GUI overlay is its own Form (think of Windows forms, but the desktop being the game and the forms being these menus)

    class Menu : Control
    {
        // Header of the menu
        private Label header;

        // Buttons on the menu
        private Button buttons;


        public Menu()
        {

            this.Location = new Point(100, 100);
            this.Size = new Point(200, 500);

            InitializeForms();
        }

        public void InitializeForms()
        {
            buttons = new Button();
            buttons.Text = "CLICK ME";
            buttons.Click += buttons_Click;
            buttons.Location = new Point(this.Size.X / 2, (this.Size.Y / 2) + 20);
            buttons.Size = new Point(50, 10);
            buttons.parent = this;
            Add(buttons);

            header = new Label();
            header.Text = "MENU";
            header.Font = null;
            header.Location = new Point(this.Size.X / 2, 10);
            header.Size = new Point(50, 10);
            header.parent = this;
            Add(header);
        }

        void buttons_Click(object sender, EventArgs e)
        {
            Game1.state = GameState.Game;
        }


        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Border, this.GlobalLocation().ToVector2(), Color.White);
            base.Draw(spriteBatch, gameTime);
        }


    }
}
