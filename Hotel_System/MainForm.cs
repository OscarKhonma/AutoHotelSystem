using System;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Событие кнопки закрытия
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Событие кнопки управления клиентом, чтоб открыть форму клиента
        private void BtnMC_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF = new ManageClientsForm();
            manageCF.ShowDialog();
        }

        //Событие кнопки управления номерами, чтоб открыть форму номеров
        private void BtnMR_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();
            manageRF.ShowDialog();
        }

        //Событие кнопки управления бронью, чтоб открыть форму брони
        private void BtnMRes_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageResF = new ManageReservationsForm();
            manageResF.ShowDialog();
        }
    }
}
