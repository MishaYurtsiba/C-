using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Модуль
{
    class Db
    {
        private List<Auction> _Db = new List<Auction>();
        public void Add(Auction Au)
        {
            _Db.Add(Au);
        }
        public List<Auction> GetAll()
        {
            return this._Db;
        }
        public void Remove(Auction Au)
        {
            _Db.Remove(Au);
        }
        
    }
    
}
