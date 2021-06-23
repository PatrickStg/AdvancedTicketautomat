using System;
using System.Collections.Generic;

namespace AdvTicketautomat
{
    class Ticketautomat
    {

        List<Ticket> ticketListe = new List<Ticket>();
        Random rnd = new Random();

        public void hinzufuegen(String ticketName) {
            ticketListe.Add(new Ticket(ticketName, rnd.Next(5, 20), ticketListe.Count+1));
        }

        public void loesche(int ticketId)
        {
            ticketListe.RemoveAt(ticketId-1);
        }

        public void sortiereAuf()
        {
            ticketListe.Sort();
        }

        public List<Ticket> sortiereAufzwei(List<Ticket> ticketListe)
        {

            ticketListe.Sort();
            return ticketListe;
        }

        public void sortiereAb()
        {
            ticketListe.Reverse();
        }

        public List<Ticket> sortiereAbzwei(List<Ticket> ticketListe)
        {
            ticketListe.Reverse();
            return ticketListe;
        }

        public void update(int ticketId, String ticketName)
        {
            loesche(ticketId);
            ticketListe.Add(new Ticket(ticketName, rnd.Next(5, 20), ticketId));
        }

        public List<Ticket> ticketListeAufrufen()
        {
            return ticketListe;
        }
    }
}
