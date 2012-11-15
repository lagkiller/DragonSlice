using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XRpgLibrary
{
    public class RolePlayingGame
    {
        #region Field region

        string name;
        string description;

        #endregion

        #region Property region

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        #endregion

        #region Constructor region

        public RolePlayingGame(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public RolePlayingGame()
        {

        }

        #endregion
    }
}
