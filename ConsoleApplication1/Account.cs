using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public abstract class Account{
        public abstract string GetAccountName(string id);
        }

    public class PremiumAccount : Account {
        public override string GetAccountName(string id) {
            return id;
            }

        public string GetAccountName(string id, string name)
        {
           return String.Format("{0} and {1}",id, name);
        }
        }
    }
