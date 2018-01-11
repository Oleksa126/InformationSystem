using InformationSystem.DAL;
using InformationSystem.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InformationSystem.BLL
{
    public class ClientService 
    {
        public List<Client> getAllClient()
        {
            ClientRepository clientService = new ClientRepository();
            var clientList = clientService.getAllClient();
            return clientList;

        }

        public void deleteClientById(int id) {
            DataSet dataSet = new DataSet();

            ClientRepository clientRepository = new ClientRepository();
            var dataAdapter = clientRepository.deleteClientById(id);
           
        }

        public DataSet showInfoAboutClient(int id) {
            DataSet dataSet = new DataSet();
            ClientRepository clientRepository = new ClientRepository();

            var dataAdapter = clientRepository.getClientById(id);
            dataAdapter.Fill(dataSet, "Result");

            return dataSet;

        }

        public void addClient(string login, string password, string firstName, string lastName, string phoneNumber, string city, string email) {
            ClientRepository clientRepository = new ClientRepository();

            if (clientRepository.addClient(login, password, firstName, lastName, phoneNumber, city, email))
            {
                MessageBox.Show("add new client");
            }
            else {
                MessageBox.Show("badly(");
            }
           
        }

        public void updateClient(string login, string password, string firstName, string lastName, string phoneNumber, string city, string email, int id) {
            ClientRepository clientRepository = new ClientRepository();

            if (clientRepository.updateClientById(login, password, firstName, lastName, phoneNumber, city, email,id))
            {
                MessageBox.Show("update new client");
            }
            else
            {
                MessageBox.Show("badly(");
            }
        }

        public DataSet innerJoin() {
            DataSet dataSet = new DataSet();
            ClientRepository clientRepository = new ClientRepository();
            var dataAdapter = clientRepository.innerJoin();
            dataAdapter.Fill(dataSet, "Result");
            return dataSet;
        }

        public DataSet leftJoin() {
            DataSet dataSet = new DataSet();
            ClientRepository clientRepository = new ClientRepository();
            var dataAdapter = clientRepository.leftJoin();
            dataAdapter.Fill(dataSet, "Result");
            return dataSet;
        }

        public DataSet rightJoin()
        {
            DataSet dataSet = new DataSet();
            ClientRepository clientRepository = new ClientRepository();
            var dataAdapter = clientRepository.rightJoin();
            dataAdapter.Fill(dataSet, "Result");
            return dataSet;
        }

        public DataSet threeCon() {
            DataSet dataSet = new DataSet();
            ClientRepository clientRepository = new ClientRepository();
            var dataAdapter = clientRepository.threeCon();
            dataAdapter.Fill(dataSet, "Result");
            return dataSet;
        }
    }
}
