using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvTicketautomat
{
    public partial class Form1 : Form
    {

        Ticketautomat ticketautomat = new Ticketautomat();

        public Form1()
        {
            InitializeComponent();
        }

        private void labelTickets_Click(object sender, EventArgs e)
        {

        }

        private void listTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelH_Click(object sender, EventArgs e)
        {

        }

        private void textH_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            ticketautomat.hinzufuegen(textH.Text);
        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            ticketautomat.update(int.Parse(textB1.Text), textB2.Text);
        }

        private void labelL_Click(object sender, EventArgs e)
        {

        }

        private void textL_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            ticketautomat.loesche(int.Parse(textB1.Text));
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            listTickets.DataSource = ticketautomat.ticketListeAufrufen();
        }

        private void buttonAuf_Click(object sender, EventArgs e)
        {
            listTickets.DataSource = ticketautomat.sortiereAufzwei(ticketautomat.ticketListeAufrufen());
        }

        private void buttonAb_Click(object sender, EventArgs e)
        {
            listTickets.DataSource = ticketautomat.sortiereAbzwei(ticketautomat.ticketListeAufrufen());

        }
    }
}
