using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class SomeLogic
    {

        public SomeLogic()
        {

        }

        public SomeLogic(int yourID, string yourName, string yourAddress)
        {

        }

        #region Methods
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }

        public List<Object> ShowAll()
        {
            return new List<Object>();
        }

        public List<Player> ShowAllPlayers()
        {
            return new List<Player>()
            {
                new Player(){PlayerID = 1, PlayerName= "Virat",Skills={"Batsmen", "Fielder"} },
                new Player(){PlayerID = 2, PlayerName= "Rohit",Skills={"Batsmen", "Fielder"} },
                new Player(){PlayerID = 3, PlayerName= "Jasprit",Skills={"Bowler", "Fielder"} },
            };
        }
        #endregion

        #region
        int id;
        string name;
        string addr;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return addr; }
            set { addr = value; }
        }
        #endregion
    }
}
