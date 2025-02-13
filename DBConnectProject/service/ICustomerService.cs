using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.service
{
    internal interface ICustomerService
    {
        void customerSave(string id, string companyName, string contactName);

        bool customerUpdate(string id, string contactName);

        void customerDelete(string id);
    }
}
