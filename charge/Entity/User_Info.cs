using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User_Info
    {
        private string _UserID;
        private string _PassWord;
        private string _Levels;
        private string _UserName;
        private bool _state;

        public string UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this._UserID = value;
            }
        }

        public string PassWord
        {
            get
            {
                return this._PassWord;
            }
            set
            {
                this._PassWord = value;
            }
        }

        public string Levels
        {
            get
            {
                return this._Levels;
            }
            set
            {
                this._Levels = value;
            }
        }

        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                this._UserName = value;
            }
        }

        public bool state
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
    }
}