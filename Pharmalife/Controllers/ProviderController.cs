using Pharmalife.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.controllers
{
    class ProviderController
    {
        private readonly ProviderListController ProviderListController = new ProviderListController();

        public void AddProviderToList(String name, String address, String phone)
        {
            Provider provider = new Provider
            {
                Name = name,
                Address = address,
                Phone = phone
            };
            this.ProviderListController.InsertIntoEnd(provider);
        }

        public void AddProviderToList(String id, String name, String address, String phone)
        {
            Provider provider = new Provider
            {
                Id = id,
                Name = name,
                Address = address,
                Phone = phone
            };
            this.ProviderListController.InsertIntoEnd(provider);
        }

        public void Save(DataGridView dgv)
        {
            this.ProviderListController.Insert();
            this.ProviderListController.GetAllProviders(dgv);
        }

        public void Update(DataGridView dgv)
        {
            this.ProviderListController.Update();
            this.ProviderListController.GetAllProviders(dgv);
        }

        public void Delete(DataGridView dgv)
        {
            this.ProviderListController.Delete();
            this.ProviderListController.GetAllProviders(dgv);
        }

        public void GetAllProviders(DataGridView dgv)
        {
            this.ProviderListController.GetAllProviders(dgv);
        }

        public void FillDataGridView(DataGridView dgv)
        {
            this.ProviderListController.FillDataGridView(dgv);
        }

        public void FillComboBox(ComboBox cbo)
        {
            this.ProviderListController.FillComboBox(cbo);
        }
    }
}

