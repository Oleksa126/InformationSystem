using System;
using System.Windows.Forms;
using InformationSystem.Models;
using InformationSystem.BLL;

namespace InformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showClient();
        }

        private void showClient()
        {
            ClientService clientService = new ClientService();
            comboBox1.DataSource = clientService.getAllClient();
            comboBox1.DisplayMember = "firstName";
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {

            Client client = (Client)comboBox1.SelectedItem;
            ClientService clientRepository = new ClientService();
            clientRepository.deleteClientById(client.idClient);
            showClient();
        }

        private void infoAboutClient_Click(object sender, EventArgs e)
        {
            Client client = (Client)comboBox1.SelectedItem;
            ClientService clientService = new ClientService();
            var dataSet = clientService.showInfoAboutClient(client.idClient);

            dgwResults.DataSource = dataSet.Tables[0];
            dgwResults.Refresh();

        }

        private void innerJoin_Click(object sender, EventArgs e)
        {

            ClientService clientService = new ClientService();
            var dataSet = clientService.innerJoin();
            dgwResults.DataSource = dataSet.Tables[0];
            dgwResults.Refresh();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClientService clientService = new ClientService();
            clientService.addClient(
                login.Text.ToString(), 
                password.Text.ToString(), 
                firstName.Text.ToString(), 
                lastName.Text.ToString(), 
                phoneNumber.Text.ToString(), 
                city.Text.ToString(), 
                email.Text.ToString());
            showClient();
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            Client client = (Client)comboBox1.SelectedItem;
            ClientService clientService = new ClientService();

            clientService.updateClient(
               login.Text.ToString(),
               password.Text.ToString(),
               firstName.Text.ToString(),
               lastName.Text.ToString(),
               phoneNumber.Text.ToString(),
               city.Text.ToString(),
               email.Text.ToString(),
               client.idClient);
            showClient();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void leftJoin_Click(object sender, EventArgs e)
        {
            ClientService clientService = new ClientService();
            var dataSet = clientService.leftJoin();
            dgwResults.DataSource = dataSet.Tables[0];
            dgwResults.Refresh();
        }

        private void rightJoin_Click(object sender, EventArgs e)
        {
            ClientService clientService = new ClientService();
            var dataSet = clientService.rightJoin();
            dgwResults.DataSource = dataSet.Tables[0];
            dgwResults.Refresh();
        }

        private void threeCon_Click(object sender, EventArgs e)
        {
            ClientService clientService = new ClientService();
            var dataSet = clientService.threeCon();
            dgwResults.DataSource = dataSet.Tables[0];
            dgwResults.Refresh();
        }
    }
}
