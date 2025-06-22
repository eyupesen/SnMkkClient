using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnMkkClient.AppEntity
{
    [Serializable]
    public class Settings
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
