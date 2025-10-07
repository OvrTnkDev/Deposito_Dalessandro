namespace Utils.Macchina
{
    public class Macchina
    {
        //Propietà (campi)
        public string Motore;
        public int SospensioniMax;
        public float VelocitaMac;
        public int NumeroMod;

        public Macchina(string motore, int sospensioniMax, float velocitaMac, int numeroMod)
        {
            Motore = motore;
            SospensioniMax = sospensioniMax;
            VelocitaMac = velocitaMac;
            NumeroMod = numeroMod;
        }

        public void ModificheVelocita()
        {
            VelocitaMac += 10;
            NumeroMod++;
        }

        public void ModificheMotore(string motore)
        {
            Motore = motore;
            NumeroMod++;
        }

        public void ModificheSospensione(int sospensione)
        {
            SospensioniMax += sospensione;
            NumeroMod++;
        }

        public override string ToString()
        {
            return $"Motore: {Motore}\tSospensioni: {SospensioniMax}\t" +
                   $"Velocità: {VelocitaMac}\tNumero Modifiche: {NumeroMod}";
        }
    }
}
