﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Tower_Main
{
    class Button
    {
        //Fields
        private Rectangle area;
        private Point startLocation;
        private bool isHighlighted;
        private Texture2D normalTexture;
        private Texture2D highlightedTexture;

        private int correspondingLevel;

        private bool isLocked; //used for level select

        //Properties
        public Rectangle Area
        {
            get { return area; }
            set { area = value; }
        }
        public Point StartLocation
        {
            get { return startLocation; }
            set { startLocation = value; }
        }
        public int StartX
        {
            get { return startLocation.X; }
            set { startLocation.X = value; }
        }
        public int StartY
        {
            get { return startLocation.Y; }
            set { startLocation.Y = value; }
        }
        public int X
        {
            get { return area.X; }
            set { area.X = value; }
        }
        public int Y
        {
            get { return area.Y; }
            set { area.Y = value; }
        }
        public bool IsHighlighted
        {
            get { return isHighlighted; }
            set { isHighlighted = value; }
        }
        public bool IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }
        public int CorrespondingLevel
        {
            get { return correspondingLevel; }
            set { correspondingLevel = value; }
        }
        public Texture2D DrawnTexture
        {
            get
            {
                if (isHighlighted)
                {
                    return highlightedTexture;
                }
                else
                {
                    return normalTexture;
                }
            }
        }

        //Normal Constructor
        public Button(Texture2D normalTexture, Texture2D highlightedTexture)
        {
            this.normalTexture = normalTexture;
            this.highlightedTexture = highlightedTexture;

            isLocked = false;
            correspondingLevel = -1; //default value if corresponding value not needed
        }

        //Constructor used for level selection
        public Button(Texture2D normalTexture, Texture2D highlightedTexture, int correspondingLevel)
        {
            this.correspondingLevel = correspondingLevel;
            this.normalTexture = normalTexture;
            this.highlightedTexture = highlightedTexture;

            isLocked = false;
        }

        //Virtual Methods/Properties for Slider
        public virtual void CheckAndAlterSlider(bool pressingRight)
        {
            throw new Exception("Do not call this method for Button, call it for Slider only");
        }

        public virtual void CheckAndAlterSlider(MouseState ms, MouseState previousMs)
        {
            throw new Exception("Do not call this method for Button, call it for Slider only");
        }
        public virtual void SetSliderButtonArea()
        {
            throw new Exception("Do not call this method for Button, call it for Slider only");
        }

        public virtual float Length
        {
            get;
            set;
        }
        public virtual float ReturnedValue
        {
            get;
            set;
        }

        public virtual Button SliderButton
        {
            get;
        }
        public virtual Texture2D DisplayedIcon
        {
            get;
        }

        //Virtual Methods/Properties for RebindingButton
        public virtual bool SetNewKey()
        {
            throw new Exception("Do not call this method for Button, call it for Slider only");
        }
        public virtual void SetNewKey(Keys key)
        {
            throw new Exception("Do not call this method for Button, call it for Slider only");
        }

        public virtual bool TryingToRebind
        {
            get;
            set;
        }

        public virtual string VisibleText
        {
            get;
        }
    }
}

