namespace Utils
{
    public sealed class RegistroVeicoli
        {
            private static RegistroVeicoli istanza;
            private List<IVeicolo> veicoliCreati = new List<IVeicolo>();

            private RegistroVeicoli() { }


            public static RegistroVeicoli GetInstanza()
            {
                if (istanza == null)
                {
                    istanza = new RegistroVeicoli();
                }
                return istanza;
            }

            public void Registra(IVeicolo veicoli)
            {
                veicoliCreati.Add(veicoli);
                Console.WriteLine($"Veicolo registrato.");

            }

            public void StampaTutti()
            {
                foreach (IVeicolo veicolo in veicoliCreati)
                {
                    veicolo.Avvia();
                    veicolo.MostraTipo();
                }
            }
        }
    }
