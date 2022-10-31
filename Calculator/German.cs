using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class German : DescriptionLearn
    {
        private string _TextNetID;
        private string _CIDR;
        private string _Hosts;
        private string _Subnet;        
        public string TextNetID
        {
            get
            {
                return $"Die IP Adresse und die Netzmaske werden mit dem Logischen UND (AND) verglichen. Das Ergebnis bildet die Netz ID.\r\n" +
              $"0 + 0 = 0\r\n0 + 1 = 0\r\n1 + 1 = 1 ";
            }
            set { _TextNetID = value; }
        }

        public string CIDR
        {
            get
            {
                return $"Die X-Stellen des CIDR bilden den Netzanteil (blau) und der Rest (orange) bildet den Hostanteil.";
            }
            set { _CIDR = value; }
        }

        public string Host
        {
            get
            {
                return $"Erster Host: die Netz ID plus 1\r\nBroadcast (BC): der Hostanteil (orange) wird komplett auf 1 gesetzt.\r\n" +
                $"Letzter Host: die BC minus 1";
            }
            set { _Hosts = value; }
        }

        public string Subnet
        {
            get
            {
                return $"Beispiel: Soll das vorhandene Netz, um 3 Subnetze erweitert werden, so muss aus der Tabelle die Spalte zwei  mit 4 Subnetzen" +
                $" ausgewählt werden.\r\nMit 2 bits hoch 2 (2² = 4) können wir 4 Subnetze aufgebaut werden. Der Netzanteil muss, um 2 bits erweitert werden.\r\n" +
                $"Das heißt der blaue Anteil verschiebt sich um 2 Einsen nach rechts und bildet die Subnetzmaske.";
            }
            set { _Subnet = value; }
        }
    }
}
