// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Data;
using System.Numerics;
using System.Threading;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        
        
        float mouseX = -1000;
        float mouseY = -1;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            int[] highscores = new int[10000];
            Window.SetTitle("Circle Placing");
            Window.SetSize(600, 600);
            Color Red = new Color(255,0,0);
            Color Black = new Color(0,0,0);
           
        }


        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
          
            Window.ClearBackground(Color.OffWhite);
           

            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                mouseX = Input.GetMouseX();
                mouseY = Input.GetMouseY();
            }

            Draw.FillColor = Color.Red;
            Draw.Circle(mouseX, mouseY, 25);
            
        }
    }

}
