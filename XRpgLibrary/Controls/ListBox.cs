using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace XRpgLibrary.Controls
{
    public class ListBox : Control
    {
        #region Event region

        public event EventHandler SelectionChanged;
        public event EventHandler Enter;
        public event EventHandler Leave;

        #endregion

        #region Field region

        List<string> items = new List<string>();

        int startItem;
        int lineCount;

        Texture2D image;
        Texture2D cursor;

        Color selectedColor = Color.Blue;
        int selectedItem;

        #endregion

        #region Property region

        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }
            set
            {
                selectedColor = value;
            }
        }

        public int SelectedIndex
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = (int)MathHelper.Clamp(value, 0f, items.Count);
            }
        }

        public string SelectedItem
        {
            get
            {
                return items[selectedItem];
            }
        }

        public List<string> Items
        {
            get
            {
                return items;
            }
        }

        public override bool HasFocus
        {
            get
            {
                return hasFocus;
            }
            set
            {
                hasFocus = value;

                if (hasFocus)
                {
                    OnEnter(null);
                }
                else
                {
                    OnLeave(null);
                }
            }
        }

        #endregion

        #region Constructor region

        public ListBox(Texture2D background, Texture2D cursor)
            : base()
        {
            hasFocus = false;
            tabStop = false;

            this.image = background;
            this.cursor = cursor;

            this.Size = new Vector2(image.Width, image.Height);

            lineCount = image.Height / SpriteFont.LineSpacing;
            startItem = 0;
            Color = Color.Black;
        }

        #endregion

        #region Abstract Method region

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, Position, Color.White);

            for (int i = 0; i < lineCount; i++)
            {
                if (startItem + i >= items.Count)
                {
                    break;
                }

                if (startItem + i == selectedItem)
                {
                    spriteBatch.DrawString(
                        SpriteFont,
                        items[startItem + i],
                        new Vector2(Position.X, Position.Y + i * SpriteFont.LineSpacing),
                        SelectedColor);
                    spriteBatch.Draw(
                        cursor,
                        new Vector2(
                            Position.X - (cursor.Width + 2),
                            Position.Y + i * SpriteFont.LineSpacing + 5),
                            Color.White);
                }
                else
                {
                    spriteBatch.DrawString(
                        SpriteFont,
                        items[startItem + i],
                        new Vector2(Position.X, 2 + Position.Y + i * SpriteFont.LineSpacing),
                        Color);
                }
            }
        }

        public override void HandleInput(PlayerIndex playerIndex)
        {
            if (!HasFocus)
            {
                return;
            }

            if (InputHandler.KeyReleased(Keys.Down) ||
                InputHandler.ButtonReleased(Buttons.LeftThumbstickDown, PlayerIndex.One))
            {
                if (selectedItem < items.Count - 1)
                {
                    selectedItem++;
                    if (selectedItem >= startItem + lineCount)
                    {
                        startItem = selectedItem - lineCount + 1;
                    }
                    OnSelectionChanged(null);
                }
            }
            else if (InputHandler.KeyReleased(Keys.Up) ||
                InputHandler.ButtonReleased(Buttons.LeftThumbstickUp, PlayerIndex.One))
            {
                if (selectedItem > 0)
                {
                    selectedItem--;
                    if (selectedItem < startItem)
                    {
                        startItem = selectedItem;
                    }
                    OnSelectionChanged(null);
                }
            }

            if (InputHandler.KeyReleased(Keys.Enter) ||
                InputHandler.ButtonReleased(Buttons.A, PlayerIndex.One))
            {
                HasFocus = false;
                OnSelected(null);
            }

            if (InputHandler.KeyReleased(Keys.Escape) ||
                InputHandler.ButtonReleased(Buttons.B, PlayerIndex.One))
            {
                HasFocus = false;
                OnSelected(null);
            }
        }

        #endregion

        #region Method region

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            if (SelectionChanged != null)
            {
                SelectionChanged(this, e);
            }
        }

        protected virtual void OnEnter(EventArgs e)
        {
            if (Enter != null)
            {
                Enter(this, e);
            }
        }

        protected virtual void OnLeave(EventArgs e)
        {
            if (Leave != null)
            {
                Leave(this, e);
            }
        }

        #endregion
    }
}
