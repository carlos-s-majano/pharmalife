using Pharmalife.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife.Controllers
{
    class ProviderController
    {
        private readonly ProviderListController providerListController = new ProviderListController();

        public void AddProviderToList(String name, String address, String phone)
        {
            Provider provider = new Provider
            {
                Name = name,
                Address = address,
                Phone = phone
            };
            this.providerListController.InsertIntoEnd(provider);
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
            this.providerListController.InsertIntoEnd(provider);
        }

        public void Save(DataGridView dgv)
        {
            this.providerListController.Insert();
            this.providerListController.GetAllProviders(dgv);
        }

        public void Update(DataGridView dgv)
        {
            this.providerListController.Update();
            this.providerListController.GetAllProviders(dgv);
        }

        public void Delete(DataGridView dgv)
        {
            this.providerListController.Delete();
            this.providerListController.GetAllProviders(dgv);
        }

        public void GetAllProviders(DataGridView dgv)
        {
            this.providerListController.GetAllProviders(dgv);
        }

        public void FillDataGridView(DataGridView dgv)
        {
            this.providerListController.FillDataGridView(dgv);
        }

        public void FillComboBox(ComboBox cbo)
        {
            this.providerListController.FillComboBox(cbo);
        }
    }
}

