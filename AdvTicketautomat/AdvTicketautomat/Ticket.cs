using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvTicketautomat
{
    class Ticket
    {

        private string name;
        private float preis;
        private int ticketid;

        public Ticket()
        {
        }

        public Ticket(String name, float preis, int ticketid)
        {
            this.name = name;
            this.preis = preis;
            this.ticketid = ticketid;
        }        

        public int getTicketId()
        {
            return this.ticketid;
        }

        public void setTicketId(int ticketid)
        {
            this.ticketid = ticketid;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public float getPreis()
        {
            return this.preis;
        }

        public void setPreis(float preis)
        {
            this.preis = preis;
        }

        public String toString() { return "Ticket_" + ticketid + " Name: " + name + "  Preis: " + preis; }
    }
}
