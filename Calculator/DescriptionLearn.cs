using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DescriptionLearn
    {
        // DE
        private string _DE_TextNetID;
        private string _DE_CIDR;
        private string _DE_Hosts;
        private string _DE_Subnet;
        public string DE_TextNetID
        {
            get
            {
                return $"Die IP Adresse und die Netzmaske werden mit dem Logischen UND (AND) verglichen. Das Ergebnis bildet die Netz ID.\r\n" +
              $"0 + 0 = 0\r\n0 + 1 = 0\r\n1 + 1 = 1 ";
            }
            set { _DE_TextNetID = value; }
        }

        public string DE_CIDR
        {
            get
            {
                return $"Die X-Stellen des CIDR bilden den Netzanteil (blau) und der Rest (orange) bildet den Hostanteil.";
            }
            set { _DE_CIDR = value; }
        }

        public string DE_Host
        {
            get
            {
                return $"Erster Host: die Netz ID plus 1\r\nBroadcast (BC): der Hostanteil (orange) wird komplett auf 1 gesetzt.\r\n" +
                $"Letzter Host: die BC minus 1";
            }
            set { _DE_Hosts = value; }
        }

        public string DE_Subnet
        {
            get
            {
                return $"Beispiel: Soll das vorhandene Netz, um 3 Subnetze erweitert werden, so muss aus der Tabelle die Spalte zwei  mit 4 Subnetzen" +
                $" ausgewählt werden.\r\nMit 2 bits hoch 2 (2² = 4) können wir 4 Subnetze aufgebaut werden. Der Netzanteil muss, um 2 bits erweitert werden.\r\n" +
                $"Das heißt der blaue Anteil verschiebt sich um 2 Einsen nach rechts und bildet die Subnetzmaske.";
            }
            set { _DE_Subnet = value; }
        }
        // EN
        private string _EN_TextNetID;
        private string _EN_CIDR;
        private string _EN_Hosts;
        private string _EN_Subnet;
        public string EN_TextNetID
        {
            get
            {
                return $"The IP address and the netmask are compared with the logical AND. The result is the network ID.\r\n" +
              $"0 + 0 = 0\r\n0 + 1 = 0\r\n1 + 1 = 1 ";
            }
            set { _EN_TextNetID = value; }
        }

        public string EN_CIDR
        {
            get
            {
                return $"The number of the CIDR form the network part (blue) and the rest (orange) form the host part.";
            }
            set { _EN_CIDR = value; }
        }

        public string EN_Host
        {
            get
            {
                return $"First host: the network ID plus 1\r\nBroadcast (BC): the host portion (orange) is set to 1 in its entirety.\r\n" +
                $"Letzter Host: die BC minus 1";
            }
            set { _EN_Hosts = value; }
        }

        public string EN_Subnet
        {
            get
            {
                return $"Example: If the existing network is to be expanded by 3 subnets, column two with 4 subnets must be selected from the table." +
                $" \r\nWith 2 bits to the power of 2 (2² = 4), we can set up 4 subnets. The network section must be expanded by 2 bits.\r\n" +
                $"That means the blue part is shifted by 2 ones to the right and forms the subnet mask.";
            }
            set { _EN_Subnet = value; }
        }
    }
}
