using System;
using System.Collections.Generic;

namespace AreaManagement
{
    [Serializable]
    class Tenant
    {
        private string name;
        private int id;

        public Tenant(string tName)
        {
            name = tName;
            id = GetNextId();
        }

        public string GetName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }

        //calculates the next id based on existing tenants for this building
        public int GetNextId()
        {
            int maxId = -1;
            foreach (Tenant tenant in Program.building.GetTenants())
            {
                if (tenant.id > maxId)
                {
                    maxId = tenant.id;
                }
            }
            return maxId + 1;
        }
    }
}