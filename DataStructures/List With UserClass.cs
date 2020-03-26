using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace DataStructures
{
    class O365PremiumTenants
    {
        public string GetJsonValue()
        {
            List<O365PulseTenants> lstTenants = new List<O365PulseTenants>();
            lstTenants.Add(new O365PulseTenants { TenantId = "0004e312-8ff1-4404-8f2b-ef8858f7007d" });
            lstTenants.Add(new O365PulseTenants { TenantId = "002b9272-8a0e-4aaa-8df4-fb5b06443dd6" });
            lstTenants.Add(new O365PulseTenants { TenantId = "003f7489-c006-4532-90f3-d1feadc0d1af" });
            lstTenants.Add(new O365PulseTenants { TenantId = "00691924-e082-4301-a3dc-1732afd14289" });
            lstTenants.Add(new O365PulseTenants { TenantId = "006c1e48-e342-47e9-ab5d-0dd9ff89bd96" });
            lstTenants.Add(new O365PulseTenants { TenantId = "0093fee8-6cdb-468e-89d8-c1401eea7c44" });
            return JsonConvert.SerializeObject(lstTenants).ToString();
        }

    }
    public class O365PulseTenants
    {
        public string TenantId { get; set; }
    }
}
